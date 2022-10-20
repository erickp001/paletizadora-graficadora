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
    public partial class Automatico : Form
    {
        private bool inCooldown = false;
        static public bool PermisoPinza = true;
        public Automatico()
        {
            InitializeComponent();
            if (ControlPosicion.PinzaClose)
            {
                botones3.Visible = false;
            }
            else
                botones4.Visible = false;
            if (ControlPosicion.vastagoOut)
            {
                botones1.Visible = false;
            }
            else
                botones2.Visible = false;

        }

        public static void MovMotors(int nuevaPosicionX, int nuevaPosicionY, int multiplicadorDePasosX, int multiplicadorDePasosY)
        {
            //Motor 1 X
            int steps1;
            byte stepsMotor1HighByte, stepsMotor1LowByte, signo1;
            steps1 = (nuevaPosicionX - ControlPosicion.posicionActualX) * multiplicadorDePasosX;
            signo1 = Convert.ToByte((steps1 < 0) ? 0 : 1);
            stepsMotor1HighByte = (byte)((Math.Abs(steps1) & 0xFF00) >> 8);
            stepsMotor1LowByte = (byte)(Math.Abs(steps1) & 0x00FF);

            //Motor 2 Y
            int steps2;
            byte stepsMotor2HighByte, stepsMotor2LowByte, signo2;
            steps2 = (nuevaPosicionY - ControlPosicion.posicionActualY) * multiplicadorDePasosY;
            signo2 = Convert.ToByte((steps2 < 0) ? 1 : 0);
            stepsMotor2HighByte = (byte)((Math.Abs(steps2) & 0xFF00) >> 8);
            stepsMotor2LowByte = (byte)(Math.Abs(steps2) & 0x00FF);

            if(steps1 != 0 && steps2 != 0)
            {
                ControlPosicion.PinguinoBoard.MotorDualMove(signo1, stepsMotor1HighByte, stepsMotor1LowByte,
                    signo2, stepsMotor2HighByte, stepsMotor2LowByte);
            }
            else if (steps1 != 0 && steps2 == 0)
            {
                ControlPosicion.PinguinoBoard.Motor1Move(signo1, stepsMotor1HighByte, stepsMotor1LowByte);
            }
            else if (steps1 == 0 && steps2 != 0)
            {
                ControlPosicion.PinguinoBoard.Motor2Move(signo2, stepsMotor2HighByte, stepsMotor2LowByte);
            }
            ControlPosicion.posicionActualX = nuevaPosicionX;
            ControlPosicion.posicionActualY = nuevaPosicionY;
        }


        private void enviarCoordenadas(object sender, EventArgs e)
        {
          
                if(ControlPosicion.calibradoPaletizadora == true)
                {
                var boton = ((Button)sender);

                int coordX = Convert.ToInt32(Convert.ToString(boton.Tag).Substring(0, 1));
                int coordY = Convert.ToInt32(Convert.ToString(boton.Tag).Substring(1, 1));
                    try
                    {
                        if (FormIngresoAuto.Permiso)
                        {
                        MovMotors((coordX - 1) * 4500, (coordY - 1) * 3000, 1, 1);
                        }
                        else errorProvider1.SetError(botones2, "Tienes que retirar el pistón");
                    }
                    catch (Exception error) { errorProvider1.SetError(botones2, "Ha ocurrido un error"); }
                }
                else errorProvider1.SetError(resetPaletiBtn, "Tienes que enviar a punto 0");
        }
        private void controlDePistones(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (Convert.ToString(boton.Tag) == "h")
            {
                botones3.Visible = true;
                botones4.Visible = false;
                botones3.BringToFront();
                ControlPosicion.PinzaClose = false;
            }
            else if (Convert.ToString(boton.Tag) == "y")
            {
                botones3.Visible = false;
                botones4.Visible = true;
                botones4.BringToFront();
                ControlPosicion.PinzaClose = true;
            }
            try
            {
                
                ControlPosicion.PinguinoBoard.SendASCII(Convert.ToString(boton.Tag));
                if(Convert.ToString(boton.Tag) == "v")
                {
                    botones2.BringToFront();
                    errorProvider1.Clear();
                    FormIngresoAuto.Permiso = false;
                    botones2.Visible = true;
                    botones1.Visible = false;
                    ControlPosicion.vastagoOut = true;
                }
                else if (Convert.ToString(boton.Tag) == "z")
                {
                    FormIngresoAuto.Permiso = true;
                    botones1.BringToFront();
                    botones2.Visible = false;
                    botones1.Visible = true;
                    ControlPosicion.vastagoOut = false;
                }
            }
            catch (Exception error) { errorProvider1.SetError(botones2, error.Message); }
        }

        private async void resetPaletiBtn_Click(object sender, EventArgs e)
            {
                 if (inCooldown)
                return;

                inCooldown = true;
                ControlPosicion.PinguinoBoard.SendASCII("z");
                ControlPosicion.PinguinoBoard.SendASCII("h");

                ControlPosicion.PinguinoBoard.SendASCII("R");
                ControlPosicion.calibradoDibujo = false;
                ControlPosicion.calibradoPaletizadora = true;
                ControlPosicion.calibradoGraficadora = false;
                ControlPosicion.posicionActualX = 1;
                ControlPosicion.posicionActualY = 1;
                errorProvider1.Clear();
                await Task.Delay(2000);
                inCooldown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
