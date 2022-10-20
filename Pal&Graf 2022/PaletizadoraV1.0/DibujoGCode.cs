using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PaletizadoraV1._0
{
    public partial class DibujoGCode : Form
    {
        private bool inCooldown = false;


        string rutaArchivo = string.Empty;
        public DibujoGCode()
        {
            InitializeComponent();
            chart1.Series["Desplazamiento"].Points.AddXY(0, 0);
            ControlPosicion.calibradoDibujo = false;
        }

        private void CeroGCode_Click(object sender, EventArgs e)
        {
            ControlPosicion.PinguinoBoard.SendASCII("R");
            ControlPosicion.calibradoDibujo = true;
            ControlPosicion.calibradoPaletizadora = false;
            ControlPosicion.calibradoGraficadora = false;
            ControlPosicion.posicionActualX = 0;
            ControlPosicion.posicionActualY = 0;
            errorProvider1.Clear();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = openFileDialog.FileName;
                }
                label1.Text = "Ruta de archivo: " + rutaArchivo;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void dibujar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlPosicion.calibradoPaletizadora)
                {
                    dibujo();
                }
                else errorProvider1.SetError(CeroGCode, "Tienes que enviar a punto 0");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void dibujo()
        {
            chart1.Series["Desplazamiento"].Points.Clear();

            TextReader archivo;
            string crudo;

            List<int> xCruda = new List<int>();
            List<int> yCruda = new List<int>();

            archivo = new StreamReader(rutaArchivo);

            crudo = archivo.ReadToEnd();

            char[] arr = crudo.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == 'X')
                {
                    string elemento = "";

                    for (int j = i + 1; j < i + 6; j++)
                    {
                        if (arr[j] != '.')
                        {
                            elemento += Convert.ToString(arr[j]);
                        }
                        else break;
                    }
                    xCruda.Add(Convert.ToInt32(elemento));
                }

                else if (arr[i] == 'Y')
                {
                    string elemento = "";

                    for (int j = i + 1; j < i + 6; j++)
                    {
                        if (arr[j] != '.')
                        {
                            elemento += Convert.ToString(arr[j]);
                        }
                        else break;
                    }
                    yCruda.Add(Convert.ToInt32(elemento));
                }

                else if (arr[i] == 'Z')
                {
                    if (arr[i + 1] == '5')
                    {
                        xCruda.Add(99999);
                        yCruda.Add(99999);
                    }
                }

                else if (arr[i] == 'G')
                {
                    if (arr[i + 6] == '1' && arr[i + 5] == '-')
                    {
                        xCruda.Add(99998);
                        yCruda.Add(99998);
                    }
                }
            }

            int[] xDibujo = xCruda.ToArray();
            int[] yDibujo = yCruda.ToArray();

            int maxX = xDibujo.Distinct().OrderByDescending(x => x).Skip(2).First();
            int maxY = yDibujo.Distinct().OrderByDescending(x => x).Skip(2).First();

            int proporcionMaxX = 12000 / maxX;
            int proporcionMaxY = 7500 / maxY;

            int multiplicador = 1;

            if (proporcionMaxX > proporcionMaxY)
            {
                multiplicador = proporcionMaxY;
            }
            else
                multiplicador = proporcionMaxX;


            for (int i = 0; i < xDibujo.Length; i++)
            {
                if (xDibujo[i] == 99999)
                {
                    ControlPosicion.PinguinoBoard.SendASCII("z");
                }
                else if (xDibujo[i] == 99998)
                {
                    ControlPosicion.PinguinoBoard.SendASCII("v");
                }
                else
                {
                    Automatico.MovMotors((xDibujo[i] * multiplicador) + 1000, (yDibujo[i] * multiplicador) + 1000,1,1);

                    chart1.Series["Desplazamiento"].Points.AddXY(xDibujo[i] * multiplicador, yDibujo[i] * multiplicador);
                }

            }

            archivo.Close();
        }
        private async void CeroGCode_Click_1(object sender, EventArgs e)
        {
            if (inCooldown)
                return;

            inCooldown = true;
            ControlPosicion.PinguinoBoard.SendASCII("z");
            ControlPosicion.PinguinoBoard.SendASCII("h");

            ControlPosicion.PinguinoBoard.SendASCII("R");
            Automatico.MovMotors(1000, 1000, 1, 1);
            ControlPosicion.calibradoDibujo = true;
            ControlPosicion.calibradoPaletizadora = false;
            ControlPosicion.calibradoGraficadora = false;
            ControlPosicion.posicionActualX = 0;
            ControlPosicion.posicionActualY = 0;
            errorProvider1.Clear();
            await Task.Delay(2000);
            inCooldown = false;
        }
    }
}
