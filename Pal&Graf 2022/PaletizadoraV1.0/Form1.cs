using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace PaletizadoraV1._0
{
    public partial class Menu : Form
    {
       // public static USBcontrol PinguinoBoard;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
 
        public Menu()
        {
            InitializeComponent();
            //CollapseMenu();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 71);
            panelMenu.Controls.Add(leftBorderBtn);
            ControlPosicion.PinguinoBoard = new USBcontrol(0x04D8, 0x003E);
            ControlPosicion.PinguinoBoard.usbEvent += new USBcontrol.usbEventsHandler(usbEventReceiver);
            ControlPosicion.PinguinoBoard.findTargetDevice();

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ControlPosicion.calibradoPaletizadora = false;
        }
        
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(244, 244, 244);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void usbEventReceiver(Object o, EventArgs e)
        {
            if (ControlPosicion.PinguinoBoard.isDeviceAttached)
            {
                label1.Text = "Tarjeta Pingüino conectada";

            }
            else
            {
                label1.Text = "Tarjeta Pingüino desconectada";
            }
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(35, 59, 98);
                currentBtn.ForeColor = color;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
               // currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Color.FromArgb(244, 244, 244);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.Black;
            }
        }
        private void DisableButton()
        {
           if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(244, 244, 244);
                currentBtn.ForeColor = Color.Black;
                //currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
               // currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
            }
            private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        //Colores de la aplicación 
        private void Menu_Load(object sender, EventArgs e)
        {
            TemaColores.ElegirTema("Celeste");
            panelMenu.BackColor = TemaColores.PanelBotones;
            //panelLogo.BackColor = TemaColores.BarraTitulo;
            PanelTitleBar.BackColor = TemaColores.BarraTitulo;
            panelDesktop.BackColor = TemaColores.PanelPadre;
            //panelShadow.BackColor = Color.FromArgb(78, 64, 148);
        }

        private void IngresoManual_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);//El botón cambia de color y de lado
            OpenChildForm(new Automatico());
            /*if (ControlPosicion.calibrado == true && ControlPosicion.PinguinoBoard.isDeviceAttached)
            {
                ActivateButton(sender, RGBColors.color1);//El botón cambia de color y de lado
                OpenChildForm(new Automatico());
            } 
             else 
            {
                ActivateButton(sender, RGBColors.color6);
            }*/


        }
        private void Boton2_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);//El botón cambia de color y de lado
            //OpenChildForm(new FormIngresoAuto());
            dropMenu1.Show(IngresoManual, IngresoManual.Width, 0);
            //OpenChildForm(new FormIngresoAuto());

            /*if (ControlPosicion.calibrado == true && ControlPosicion.PinguinoBoard.isDeviceAttached)
            {
              
                ActivateButton(sender, RGBColors.color2);//El botón cambia de color y de lado
                OpenChildForm(new FormIngresoAuto());
            }
            else
            {
                ActivateButton(sender, RGBColors.color6);
            }*/

        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);//El botón cambia de color y de lado
            //dropMenu1.Show(GuiasAprendizaje, GuiasAprendizaje.Width, 0);
            
        }

        private void botonInicio_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            //Botón para cerrar formularios secundarios
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Enabled = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Black;
            lblTitleChildForm.Text = "Home";
        }


        //Código para mover la aplicación con la barra superior 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        #region botones para min, max and exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region a
        private void button1_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "C";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //-50/*
         
        private void button7_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "g";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //50
        private void button2_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "b";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //100
        private void button3_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "c";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //500
        private void button4_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "d";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //1000
        private void button5_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "e";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //reset
        private void button6_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "f";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //-100
        private void button8_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "h";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //-500
        private void button9_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "i";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //-1000
        private void button10_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "j";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //primera
        private void button20_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "k";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //segunda
        private void button21_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "l";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //tercera
        private void button22_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "m";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //cuarta
        private void button23_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "n";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
        }
        //botonera region
        #endregion

        private void MenuButton_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 189) //Collapse menu
            {
                panelMenu.Width = 100;
                botonInicio.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 190;
                botonInicio.Visible = true;
                btnMenu.Dock = DockStyle.None;
                
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    IngresoManual.Text = "Modos de paletizadora";   
                    EnvioManualSimple.Text = "Modos de graficador";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void EnvioManualSimple_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);//El botón cambia de color y de lado
            dropMenu2.Show(EnvioManualSimple, EnvioManualSimple.Width, 0);
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EnvioManualSimple());
        }

        private void graficadorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Automatico());
        }

        private void dibujoDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DibujoGCode());
        }
        private void calculadoraGráficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormIngresoAuto());
        }
        private void resetPaletiBtn_Click(object sender, EventArgs e)
        {
            string strToSendBuffer = "R";
            ControlPosicion.PinguinoBoard.SendASCII(strToSendBuffer);
            ControlPosicion.calibradoDibujo = false;
            ControlPosicion.calibradoPaletizadora = true;
            ControlPosicion.calibradoGraficadora = false;
            ControlPosicion.posicionActualX = 1;
            ControlPosicion.posicionActualY = 1;
        }

        private void manualBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1GhX6z9FKqX3e9GTM7XFgE2nPfpf8dBEV/edit?usp=sharing&ouid=108128189736182064555&rtpof=true&sd=true");
        
        }

        private void guiasBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.canva.com/design/DAFNkcWNgo0/1kKK0lh9f1rUtiumlWDzIQ/view?utm_content=DAFNkcWNgo0&utm_campaign=designshare&utm_medium=link&utm_source=publishsharelink");
        }

        private void calculadoraGráficaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CalculadoraP());
        }
    }
}
