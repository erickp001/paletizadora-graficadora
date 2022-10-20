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
    
    public partial class FormIngresoAuto : Form
    {
        int nInstrucciones = 0;
        static public bool Permiso = true;
        string rutaArchivo = string.Empty;
        private bool inCooldown = false;

        public FormIngresoAuto()
        {
            InitializeComponent();
            Graficar();
            ControlPosicion.PinguinoBoard.SendASCII("z");
            ControlPosicion.PinguinoBoard.SendASCII("h");
            Permiso = true;

        }
        
        
        //ejecutar
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ControlPosicion.calibradoPaletizadora)
                {
                    ejecutarLista();
                }
                else
                {
                    errorProvider1.SetError(resetPaletiBtn, "No está calibrado");
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        //agregar
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                agregarALaListbox();
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        //Eliminar
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            nInstrucciones = 0;
            Graficar();
        }
        //Borrar
        private void button1_Click_1(object sender, EventArgs e)
        {
            int Select = Convert.ToInt32(listBox1.SelectedIndex.ToString());
            if (Select >= 0)
            {
                listBox1.Items.RemoveAt(Select);
            }
            Graficar();
        }
        //Editar
        private void button5_Click_1(object sender, EventArgs e)
        {
            int Select = Convert.ToInt32(listBox1.SelectedIndex.ToString());
            if (Select >= 0 && textBox3.Text != "")
            {
                double cambio = Convert.ToDouble(textBox3.Text);
                listBox1.Items.RemoveAt(Select);
                listBox1.Items.Insert(Select, cambio);
            }
            Graficar();
        }
        //Graficando la lista
        private void Graficar()
        {
            chart1.Series["Desplazamiento"].Points.Clear();
            int total = Convert.ToInt32(listBox1.Items.Count.ToString());
            chart1.Series["Desplazamiento"].Points.AddXY(ControlPosicion.posicionActualX, ControlPosicion.posicionActualY);
            for (int i = 0; i < total; i++)
            {/*
                if (listBox1.Items[i].ToString() != "sacar" && listBox1.Items[i].ToString()
                    != "meter" && listBox1.Items[i].ToString() !=
                    "cerrar" && listBox1.Items[i].ToString() != "abrir")
                {
                    string Lista = listBox1.Items[i].ToString();
                    int Longitud = Lista.Length;
                    int valorX = Convert.ToInt32(Lista.Substring(0, 1));
                    int valorY = Convert.ToInt32(Lista.Substring(2, 1));
                    chart1.Series["Desplazamiento"].Points.AddXY(valorX, valorY);
                }*/
                if (listBox1.Items[i].ToString() != "recoger" && listBox1.Items[i].ToString()
                    != "colocar")
                {
                    string Lista = listBox1.Items[i].ToString();
                    int Longitud = Lista.Length;
                    int valorX = Convert.ToInt32(Lista.Substring(0, 1));
                    int valorY = Convert.ToInt32(Lista.Substring(2, 1));
                    chart1.Series["Desplazamiento"].Points.AddXY(valorX, valorY);
                }
            }

        }

        private void controlDePistones(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            try
            {
                listBox1.Items.Add(Convert.ToString(boton.Tag));
                nInstrucciones++;
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 47 && e.KeyChar <= 48) || (e.KeyChar >= 53 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(textBox3, "Sintaxis inválida");
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    agregarALaListbox();
                }
                catch(Exception error) { MessageBox.Show(error.Message); }
            }
        }

        private void agregarALaListbox()
        {
            errorProvider1.Clear();

            if (textBox3.Text != "")
            {
                string texto = textBox3.Text.Trim();
                if (texto.Length == 3)
                {
                    string punto = Convert.ToString(texto.ElementAt(1));
                    if (punto == ".")
                    {
                        listBox1.Items.Add(texto);
                        nInstrucciones++;
                        Graficar();
                        textBox3.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(textBox3, "Sintaxis incorrecta");
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox3, "Sintaxis incorrecta");
                }
            }

        }

        private void ejecutarLista()
        {
            Graficar();
            errorProvider1.Clear();
            for (int i = 0; i < nInstrucciones; i++)
            {
                string elementoLista = listBox1.Items[i].ToString();

                 if (elementoLista == "colocar")
                 {
                    ControlPosicion.PinguinoBoard.SendASCII("v");
                    ControlPosicion.PinguinoBoard.SendASCII("h");
                    ControlPosicion.PinguinoBoard.SendASCII("z");
                    ControlPosicion.PinzaClose = false;
                 }
                 else if(elementoLista == "recoger")
                {
                    ControlPosicion.PinguinoBoard.SendASCII("v");
                    ControlPosicion.PinguinoBoard.SendASCII("y");
                    ControlPosicion.PinguinoBoard.SendASCII("z");
                    ControlPosicion.PinzaClose= true;
                }

                else
                {
                    if (Permiso == true)
                    {
                        int valorX = Convert.ToInt32(elementoLista.Substring(0, 1));
                        int valorY = Convert.ToInt32(elementoLista.Substring(2, 1));

                        Automatico.MovMotors((valorX - 1) * 4500, (valorY - 1) * 3000, 1, 1);
                    }
                    else if (Permiso == false)
                    {
                        errorProvider1.SetError(textBox3, "Retira el piston");
                    }
                }
            }
        }

        private async void resetPaletiBtn_Click(object sender, EventArgs e)
        {
            if (inCooldown)
                return;

            inCooldown = true;
            ControlPosicion.PinguinoBoard.SendASCII("z");
            ControlPosicion.PinguinoBoard.SendASCII("h");

            string strToSendBuffer = "R";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
            ControlPosicion.calibradoDibujo = false;
            ControlPosicion.calibradoPaletizadora = true;
            ControlPosicion.calibradoGraficadora = false;
            ControlPosicion.posicionActualX = 1;
            ControlPosicion.posicionActualY = 1;
            errorProvider1.Clear();
            await Task.Delay(2000);
            inCooldown = false;
        }

        private void FormIngresoAuto_Load(object sender, EventArgs e)
        {

        }
    }
}
