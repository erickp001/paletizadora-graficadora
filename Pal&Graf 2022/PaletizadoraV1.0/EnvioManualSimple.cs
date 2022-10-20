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
    public partial class EnvioManualSimple : Form
    {
        static public bool Permiso = true;
        private bool inCooldown = false;
        

        public EnvioManualSimple()
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

        private void EnviarCoord1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (ControlPosicion.calibradoPaletizadora == true)
            {
                var boton = ((Button)sender);
                try
                {
                    if (FormIngresoAuto.Permiso)
                    {
                        int lectorx = Convert.ToInt32(txtEjeX.Text);
                        int lectory = Convert.ToInt32(txtEjeY.Text);
                        Automatico.MovMotors((lectorx - 1) * 4500, (lectory - 1) * 3000, 1, 1);
                    }
                    else errorProvider1.SetError(botones2, "Tienes que retirar el pistón");
                    
                }
                catch (Exception error)
                {
                    errorProvider1.SetError(EnviarCoord1, error.Message);
                }
            }
            else errorProvider1.SetError(resetPaletiBtn, "Tienes que enviar a punto 0");

        }


        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 48) || (e.KeyChar >= 53 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(EnviarCoord1, "Ingrese una coordenada válida");
                e.Handled = true;
                return;
            }
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
                if (Convert.ToString(boton.Tag) == "v")
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
            catch (Exception error) { errorProvider1.SetError(botones2, "Debes retraer el pistón"); }
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

    }
}
