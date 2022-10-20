using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletizadoraV1._0
{
    public partial class CalculadoraP : Form
    {
        static bool grados = true;
        private bool inCooldown = false;
        int shiftEnY = 4500;
        int shiftEnX = 6750;
        public CalculadoraP()
        {
            InitializeComponent();
        }
        bool permisoParaDibujar = false;
        private void agregarElemento (object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if(boton.Text == "cos" || boton.Text == "sin" || boton.Text == "tan" 
                || boton.Text == "log" || boton.Text == "ln" || boton.Text == "abs")
            {
                ecuaciontxt.Text += boton.Text + "(";
            }
            else
            {
                ecuaciontxt.Text += boton.Text;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (ecuaciontxt.Text.Length > 1)
            {
                ecuaciontxt.Text = ecuaciontxt.Text.Substring(0, ecuaciontxt.Text.Length - 1);
            }
            else
            {
                ecuaciontxt.Text = "";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ecuaciontxt.Text = "";
        }

        

        //boton Graficar
        private void button21_Click(object sender, EventArgs e)
        {
            permisoParaDibujar = false;
            string ecutxt = ecuaciontxt.Text;
            List<char> ecuArr = ecutxt.ToList();
            List<string> ecuPlay = new List<string>();

            try
            {
                obtenerListaDeElementos(ecuArr, ecuPlay);

                graficar(ecuPlay);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }


        static void obtenerListaDeElementos(List<char> listaChar, List<string> listaElementos)
        {
            List<string> numeros = new List<string>();
            for (int i = 0; i < 10; i++)
                numeros.Add(i.ToString());
            numeros.Add(".");
            List<string> operadores = new List<string>() {
                    "/", "*", "+", "-", "^", "√", "(", ")", "X"
            };
            List<string> opParaMenos = new List<string>() {
                    "/", "*", "+", "-", "^", "√", "("};

            string elemento = string.Empty;

            for (int i = 0; i < listaChar.Count; i++)
            {
                if (numeros.Contains(Convert.ToString(listaChar[i])))
                {
                    elemento += Convert.ToString(listaChar[i]);

                    if (listaChar.Count - 1 != i)
                    {
                        if (!numeros.Contains(Convert.ToString(listaChar[i + 1])))
                        {
                            listaElementos.Add(elemento);
                            elemento = string.Empty;
                        }
                    }
                    else
                    {
                        listaElementos.Add(elemento);
                        elemento = string.Empty;
                    }
                }
                else if (listaChar[i] == 'c' || listaChar[i] == 's' || listaChar[i] == 't'
                    || listaChar[i] == 'l' || listaChar[i] == 'e' || listaChar[i] == 'π'
                    || listaChar[i] == 'a')
                {
                    if (listaChar[i] == 'c')
                    {
                        listaElementos.Add("cos");
                        listaChar.RemoveRange(i, 3);
                        i -= 1;
                    }
                    else if (listaChar[i] == 's')
                    {
                        listaElementos.Add("sin");
                        listaChar.RemoveRange(i, 3);
                        i -= 1;
                    }
                    else if (listaChar[i] == 't')
                    {
                        listaElementos.Add("tan");
                        listaChar.RemoveRange(i, 3);
                        i -= 1;
                    }
                    else if (listaChar[i] == 'l' && listaChar[i + 1] != 'n')
                    {
                        listaElementos.Add("log");
                        listaChar.RemoveRange(i, 3);
                        i -= 1;
                    }
                    else if (listaChar[i] == 'l' && listaChar[i + 1] == 'n')
                    {
                        listaElementos.Add("ln");
                        listaChar.RemoveRange(i, 2);
                        i -= 1;
                    }
                    else if (listaChar[i] == 'e')
                    {
                        listaElementos.Add(Convert.ToString(Math.E));
                    }
                    else if (listaChar[i] == 'π')
                    {
                        listaElementos.Add(Convert.ToString(Math.PI));
                    }
                    else if (listaChar[i] == 'a')
                    {
                        listaElementos.Add("abs");
                        listaChar.RemoveRange(i, 3);
                        i -= 1;
                    }
                }
                else if (operadores.Contains(Convert.ToString(listaChar[i])))
                {
                    listaElementos.Add(Convert.ToString(listaChar[i]));
                }
            }

            for (int i = 0; i < listaElementos.Count; i++)
            {
                if (listaElementos[i] == "-")
                {
                    if (i == 0)
                    {
                        string nuevoElemento = listaElementos[i] + listaElementos[i + 1];
                        listaElementos.RemoveRange(i, 2);
                        listaElementos.Insert(i, nuevoElemento);
                    }
                    else if (opParaMenos.Contains(listaElementos[i-1])
                        && double.TryParse(listaElementos[i+1], out double a))
                    {
                        string nuevoElemento = listaElementos[i] + listaElementos[i+1];
                        listaElementos.RemoveRange(i, 2);
                        listaElementos.Insert(i, nuevoElemento);
                    }
                }
            }
        }

        static string resolverEcuacion(List<string> listaDeElementos)
        {
            if(listaDeElementos.Count == 1)
            {
                return listaDeElementos[0];
            }
            else
            {
                bool bucle = false;
                while (listaDeElementos.Count > 1)
                {
                    bucle = true;
                    
                    while (listaDeElementos.Contains("("))
                    {
                        bucle = false;
                        List<int> indexInicio = new List<int>();
                        List<int> indexFinal = new List<int>();
                        List<string> elementosAResolver = new List<string>();

                        int indexOrdenadoInicio = 1;
                        int indexOrdenadoFinal = 1;

                        //obtiene los indices de los inicios y finales de parentesis
                        for (int i = 0; i < listaDeElementos.Count; i++)
                        {
                            if (listaDeElementos[i] == "(")
                            {
                                indexInicio.Add(i);
                            }
                            else if (listaDeElementos[i] == ")")
                            {
                                indexFinal.Add(i);
                            }
                        }
                        //establece la jerarquia para resolver los parentesis
                        indexInicio.Reverse();
                        for (int i = 0; i < indexFinal.Count; i++)
                        {
                            for (int j = 0; j < indexInicio.Count; j++)
                            {
                                if (indexFinal[i] > indexInicio[j])
                                {
                                    indexOrdenadoFinal = indexFinal[i];
                                    indexOrdenadoInicio = indexInicio[j];
                                    break;
                                }
                            }
                            break;
                        }
                        //obtiene los elementos dentro del parentesis
                        for (int i = indexOrdenadoInicio + 1; i < indexOrdenadoFinal; i++)
                        {
                            elementosAResolver.Add(listaDeElementos[i]);
                        }

                        int borrar = elementosAResolver.Count + 2;
                        string solucionParentesis = resolverEcuacion(elementosAResolver);

                        listaDeElementos.RemoveRange(indexOrdenadoInicio, borrar);

                        listaDeElementos.Insert(indexOrdenadoInicio,solucionParentesis);
                    }

                    if (listaDeElementos.Contains("cos") || listaDeElementos.Contains("sin") || 
                        listaDeElementos.Contains("tan") || listaDeElementos.Contains("log") || 
                        listaDeElementos.Contains("ln") || listaDeElementos.Contains("abs"))
                    {
                        bucle = false;
                        for (int i = 0; i < listaDeElementos.Count; i++)
                        {
                            if (listaDeElementos[i] == "sin" && grados)
                            {
                                double a = Convert.ToDouble(listaDeElementos[i + 1]);
                                double b = (a * (Math.PI)) / 180;
                                
                                double p = Math.Sin(b);
                                listaDeElementos.RemoveRange(i, 2);
                                listaDeElementos.Insert(i, Convert.ToString(p.ToString("N3")));
                                i = 0;
                            }
                            else if (listaDeElementos[i] == "cos" && grados)
                            {
                                double a = Convert.ToDouble(listaDeElementos[i + 1]);
                                double b = (a * (Math.PI)) / 180;

                                double p = Math.Cos(b);
                               /* string k = Convert.ToString(p)*/
                                listaDeElementos.RemoveRange(i, 2);
                                listaDeElementos.Insert(i, Convert.ToString(p.ToString("N3")));
                                i = 0;
                            }
                            else if (listaDeElementos[i] == "sin" && !grados)
                            {
                                double p = Math.Cos(Convert.ToDouble(listaDeElementos[i + 1]));
                                listaDeElementos.RemoveRange(i, 2);
                                listaDeElementos.Insert(i, Convert.ToString(p));
                                i = 0;
                            }
                            else if (listaDeElementos[i] == "cos" && !grados)
                            {
                                double p = Math.Cos(Convert.ToDouble(listaDeElementos[i + 1]));
                                listaDeElementos.RemoveRange(i, 2);
                                listaDeElementos.Insert(i, Convert.ToString(p));
                                i = 0;
                            }
                            else if (listaDeElementos[i] == "tan" && grados)
                            {
                                double a = Convert.ToDouble(listaDeElementos[i + 1]);
                                double b = (a * (Math.PI)) / 180;

                                double p = Math.Tan(b);
                                listaDeElementos.RemoveRange(i, 2);
                                listaDeElementos.Insert(i, Convert.ToString(p.ToString("N3")));
                                i = 0;
                            }
                            else if (listaDeElementos[i] == "tan" && !grados)
                            {
                                double p = Math.Tan(Convert.ToDouble(listaDeElementos[i + 1]));
                                listaDeElementos.RemoveRange(i, 2);
                                listaDeElementos.Insert(i, Convert.ToString(p));
                                i = 0;
                            }
                            else if (listaDeElementos[i] == "log")
                            {
                                double p = Math.Log10(Convert.ToDouble(listaDeElementos[i + 1]));
                                listaDeElementos.RemoveRange(i, 2);
                                listaDeElementos.Insert(i, Convert.ToString(p));
                                i = 0;
                            }
                            else if (listaDeElementos[i] == "ln")
                            {
                                double p = Math.Log(Convert.ToDouble(listaDeElementos[i + 1]));
                                listaDeElementos.RemoveRange(i, 2);
                                listaDeElementos.Insert(i, Convert.ToString(p));
                                i = 0;
                            }
                            else if (listaDeElementos[i] == "abs")
                            {
                                double p = Math.Abs(Convert.ToDouble(listaDeElementos[i + 1]));
                                listaDeElementos.RemoveRange(i, 2);
                                listaDeElementos.Insert(i, Convert.ToString(p));
                                i = 0;
                            }
                        }
                    }

                    else if(listaDeElementos.Contains("√") || listaDeElementos.Contains("^"))
                    {
                        bucle = false;
                        for (int i = 0; i < listaDeElementos.Count; i++)
                        {

                            if (listaDeElementos[i] == "^")
                            {
                                double p = Math.Pow(Convert.ToDouble(listaDeElementos[i - 1]),
                                    Convert.ToDouble(listaDeElementos[i + 1]));

                                listaDeElementos.RemoveRange(i - 1, 3);
                                listaDeElementos.Insert(i - 1, Convert.ToString(p));
                                i = 0; 
                            }
                            else if (listaDeElementos[i] == "√")
                            {
                                double p = Math.Sqrt(Convert.ToDouble(listaDeElementos[i + 1]));
                                listaDeElementos.RemoveRange(i, 2);
                                listaDeElementos.Insert(i, Convert.ToString(p));
                                i = 0;
                            }
                        }
                    }

                    else if (listaDeElementos.Contains("*") || listaDeElementos.Contains("/"))
                    {
                        bucle = false;
                        for (int i = 0; i < listaDeElementos.Count; i++)
                        {
                            if (listaDeElementos[i] == "*")
                            {
                                double p = Convert.ToDouble(listaDeElementos[i - 1]) *
                                    Convert.ToDouble(listaDeElementos[i + 1]);
                                listaDeElementos.RemoveRange(i - 1, 3);
                                listaDeElementos.Insert(i - 1, Convert.ToString(p));
                                i = 0;
                            }
                            else if (listaDeElementos[i] == "/")
                            {
                                double p = Convert.ToDouble(listaDeElementos[i - 1])
                                    / Convert.ToDouble(listaDeElementos[i + 1]);
                                listaDeElementos.RemoveRange(i - 1, 3);
                                listaDeElementos.Insert(i - 1, Convert.ToString(p));
                                i = 0;
                            }
                        }
                    }

                    else if (listaDeElementos.Contains("+") || listaDeElementos.Contains("-"))
                    {
                        bucle = false;
                        for (int i = 0; i < listaDeElementos.Count; i++)
                        {
                            if (listaDeElementos[i] == "+")
                            {
                                double p = Convert.ToDouble(listaDeElementos[i - 1])
                                    + Convert.ToDouble(listaDeElementos[i + 1]);

                                listaDeElementos.RemoveRange(i - 1, 3);
                                listaDeElementos.Insert(i - 1, Convert.ToString(p));
                                i = 0;
                            }
                            else if (listaDeElementos[i] == "-")
                            {
                                double p = Convert.ToDouble(listaDeElementos[i - 1])
                                    - Convert.ToDouble(listaDeElementos[i + 1]);

                                listaDeElementos.RemoveRange(i - 1, 3);
                                listaDeElementos.Insert(i - 1, Convert.ToString(p));
                                i = 0;
                            }
                        }
                    }
                    if (bucle)
                    {
                        MessageBox.Show("error de sintaxis");
                        break;
                    }
                }
                if (!bucle)
                {
                    return listaDeElementos[0];
                }
                else
                    return "";
            }
        }

        //cambiar GRADOS/RADIANES
        private void button25_Click(object sender, EventArgs e)
        {
            if(label1.Text == "GRADOS")
            {
                label1.Text = "RADIANES";
                grados = false;
            }
            else
            {
                label1.Text = "GRADOS";
                grados=true;
            }
        }


        private void graficar(List<string> listaDeElementos)
        {
            chart1.Series["Series1"].Points.Clear();
            double xRango = Convert.ToDouble(txtRangoX.Text);
            double resolucion = Convert.ToDouble(txtResolucion.Text);
            double x = xRango * (-1);
            List<double> listaX = new List<double>();
            List<double> listaY = new List<double>();

            for (double i = 0; i < ((xRango*2)+1) / resolucion; i++)
            {
                List<string> lista = new List<string>(listaDeElementos);

                for(int j = 0; j < lista.Count; j++)
                {
                    if(lista[j] == "X")
                    {
                        lista[j] = Convert.ToString(x);
                    }
                }

                string y = resolverEcuacion(lista);

                if (Double.IsInfinity(Convert.ToDouble(y)))
                {
                    if (Double.IsNegativeInfinity(Convert.ToDouble(y)))
                    {
                        listaX.Add(x);
                        listaY.Add(-999999999999999);
                        chart1.Series["Series1"].Points.AddXY(x, -999999999999999);
                    }
                    else
                    {
                        listaX.Add(x);
                        listaY.Add(999999999999999);
                        chart1.Series["Series1"].Points.AddXY(x, 999999999999999);
                    }
                    
                }
                else if (!y.Contains("E"))
                {
                    listaX.Add(x);
                    listaY.Add(Convert.ToDouble(y));
                    chart1.Series["Series1"].Points.AddXY(x, Convert.ToDouble(y));
                }
                x+=resolucion;
            }

            if (permisoParaDibujar)
            {
                if (ControlPosicion.calibradoPaletizadora)
                {
                    double r, R, O, o;
                    r = listaX.Max();
                    R = listaX.Min();
                    o = listaY.Max();
                    O = listaY.Min();

                    double mX, mY;

                    mX = 6500 / (Math.Max(Math.Abs(R), r));
                    mY = 4300 / (Math.Max(Math.Abs(O), o));

                    List<int> listaA = new List<int>();
                    List<int> listaB = new List<int>();

                    for (int i = 0; i < listaX.Count; i++)
                    {
                        listaA.Add(Convert.ToInt32(listaX[i] * mX));
                        listaB.Add(Convert.ToInt32(listaY[i] * mY));
                    }

                    double resolucionMotores = 100;
                    int salto;
                    if (listaX.Count < 150)
                    {
                        salto = 1;
                    }
                    else
                    {
                        salto = Convert.ToInt32(Math.Floor(listaX.Count / resolucionMotores));
                    }

                    Automatico.MovMotors(listaA[0] + shiftEnX, listaB[0] + shiftEnY, 1, 1);
                    ControlPosicion.PinguinoBoard.SendASCII("v");

                    for (int i = 0; i < listaX.Count; i += salto)
                    {
                        Automatico.MovMotors(listaA[i] + shiftEnX, listaB[i] + shiftEnY, 1, 1);
                    }
                    ControlPosicion.PinguinoBoard.SendASCII("z");
                }
                else
                    MessageBox.Show("Tienes que calibrarlo");
                
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string ecutxt = ecuaciontxt.Text;
            List<char> ecuArr = ecutxt.ToList();
            List<string> ecuPlay = new List<string>();
            try
            {
                obtenerListaDeElementos(ecuArr, ecuPlay);

                ecuaciontxt.Text = resolverEcuacion(ecuPlay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button34_Click(object sender, EventArgs e)
        {
           
        }
        private void GraficarBtn_Click(object sender, EventArgs e)
        {
            permisoParaDibujar = false;
            string ecutxt = ecuaciontxt.Text;
            List<char> ecuArr = ecutxt.ToList();
            List<string> ecuPlay = new List<string>();

            try
            {
                obtenerListaDeElementos(ecuArr, ecuPlay);

                graficar(ecuPlay);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private async void resetPaletiBtn_Click(object sender, EventArgs e)
        {
            if (inCooldown)
                return;

            inCooldown = true;
            ControlPosicion.PinguinoBoard.SendASCII("R");
            Automatico.MovMotors(6750, 4500, 1, 1);
            ControlPosicion.posicionActualX = 0;
            ControlPosicion.posicionActualY = 0;
            ControlPosicion.calibradoDibujo = false;
            ControlPosicion.calibradoPaletizadora = false;
            ControlPosicion.calibradoGraficadora = true;
            await Task.Delay(2000);
            inCooldown = false;
        }

        private async void GraficarWMotorBtn_Click(object sender, EventArgs e)
        {
            if (ControlPosicion.calibradoPaletizadora)
            {
                if (inCooldown)
                    return;

                inCooldown = true;
                permisoParaDibujar = true;
                string ecutxt = ecuaciontxt.Text;
                List<char> ecuArr = ecutxt.ToList();
                List<string> ecuPlay = new List<string>();
                try
                {
                    obtenerListaDeElementos(ecuArr, ecuPlay);

                    graficar(ecuPlay);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                await Task.Delay(2000);
                inCooldown = false;
            }
            else
            {
                MessageBox.Show("Debes enviar a punto 0");
            }
        }
    }
}
