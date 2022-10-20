namespace PaletizadoraV1._0
{
    partial class EnvioManualSimple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEnvCoorSimp = new System.Windows.Forms.Panel();
            this.resetPaletiBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEjeY = new System.Windows.Forms.TextBox();
            this.txtEjeX = new System.Windows.Forms.TextBox();
            this.EnviarCoord1 = new FontAwesome.Sharp.IconButton();
            this.cosox = new FontAwesome.Sharp.IconButton();
            this.cosoY = new FontAwesome.Sharp.IconButton();
            this.botones4 = new PaletizadoraV1._0.botones();
            this.botones3 = new PaletizadoraV1._0.botones();
            this.botones2 = new PaletizadoraV1._0.botones();
            this.botones1 = new PaletizadoraV1._0.botones();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelEnvCoorSimp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelEnvCoorSimp
            // 
            this.panelEnvCoorSimp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelEnvCoorSimp.Controls.Add(this.resetPaletiBtn);
            this.panelEnvCoorSimp.Controls.Add(this.panel2);
            this.panelEnvCoorSimp.Controls.Add(this.txtEjeY);
            this.panelEnvCoorSimp.Controls.Add(this.txtEjeX);
            this.panelEnvCoorSimp.Controls.Add(this.EnviarCoord1);
            this.panelEnvCoorSimp.Controls.Add(this.cosox);
            this.panelEnvCoorSimp.Controls.Add(this.cosoY);
            this.panelEnvCoorSimp.Location = new System.Drawing.Point(22, 2);
            this.panelEnvCoorSimp.Name = "panelEnvCoorSimp";
            this.panelEnvCoorSimp.Size = new System.Drawing.Size(725, 434);
            this.panelEnvCoorSimp.TabIndex = 13;
            // 
            // resetPaletiBtn
            // 
            this.resetPaletiBtn.FlatAppearance.BorderSize = 0;
            this.resetPaletiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPaletiBtn.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.resetPaletiBtn.IconColor = System.Drawing.Color.Black;
            this.resetPaletiBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.resetPaletiBtn.Location = new System.Drawing.Point(0, 382);
            this.resetPaletiBtn.Name = "resetPaletiBtn";
            this.resetPaletiBtn.Size = new System.Drawing.Size(43, 52);
            this.resetPaletiBtn.TabIndex = 38;
            this.resetPaletiBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resetPaletiBtn.UseVisualStyleBackColor = true;
            this.resetPaletiBtn.Click += new System.EventHandler(this.resetPaletiBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.botones4);
            this.panel2.Controls.Add(this.botones3);
            this.panel2.Controls.Add(this.botones1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.botones2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(493, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 434);
            this.panel2.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Acciones con la pinza";
            // 
            // txtEjeY
            // 
            this.txtEjeY.Location = new System.Drawing.Point(325, 139);
            this.txtEjeY.MaxLength = 1;
            this.txtEjeY.Name = "txtEjeY";
            this.txtEjeY.ShortcutsEnabled = false;
            this.txtEjeY.Size = new System.Drawing.Size(83, 20);
            this.txtEjeY.TabIndex = 14;
            this.txtEjeY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // txtEjeX
            // 
            this.txtEjeX.Location = new System.Drawing.Point(111, 139);
            this.txtEjeX.MaxLength = 1;
            this.txtEjeX.Name = "txtEjeX";
            this.txtEjeX.ShortcutsEnabled = false;
            this.txtEjeX.Size = new System.Drawing.Size(83, 20);
            this.txtEjeX.TabIndex = 13;
            this.txtEjeX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // EnviarCoord1
            // 
            this.EnviarCoord1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnviarCoord1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.EnviarCoord1.FlatAppearance.BorderSize = 0;
            this.EnviarCoord1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.EnviarCoord1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnviarCoord1.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnviarCoord1.IconChar = FontAwesome.Sharp.IconChar.RulerCombined;
            this.EnviarCoord1.IconColor = System.Drawing.Color.Black;
            this.EnviarCoord1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EnviarCoord1.IconSize = 60;
            this.EnviarCoord1.Location = new System.Drawing.Point(224, 217);
            this.EnviarCoord1.Name = "EnviarCoord1";
            this.EnviarCoord1.Size = new System.Drawing.Size(90, 96);
            this.EnviarCoord1.TabIndex = 12;
            this.EnviarCoord1.Text = "Enviar";
            this.EnviarCoord1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EnviarCoord1.UseVisualStyleBackColor = true;
            this.EnviarCoord1.Click += new System.EventHandler(this.EnviarCoord1_Click);
            // 
            // cosox
            // 
            this.cosox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cosox.FlatAppearance.BorderSize = 0;
            this.cosox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cosox.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosox.ForeColor = System.Drawing.Color.Black;
            this.cosox.IconChar = FontAwesome.Sharp.IconChar.RulerHorizontal;
            this.cosox.IconColor = System.Drawing.Color.Black;
            this.cosox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cosox.IconSize = 40;
            this.cosox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cosox.Location = new System.Drawing.Point(118, 73);
            this.cosox.Name = "cosox";
            this.cosox.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.cosox.Size = new System.Drawing.Size(76, 69);
            this.cosox.TabIndex = 5;
            this.cosox.Tag = "Calculadora";
            this.cosox.Text = "Eje X";
            this.cosox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cosox.UseVisualStyleBackColor = true;
            // 
            // cosoY
            // 
            this.cosoY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cosoY.FlatAppearance.BorderSize = 0;
            this.cosoY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cosoY.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosoY.ForeColor = System.Drawing.Color.Black;
            this.cosoY.IconChar = FontAwesome.Sharp.IconChar.RulerVertical;
            this.cosoY.IconColor = System.Drawing.Color.Black;
            this.cosoY.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cosoY.IconSize = 40;
            this.cosoY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cosoY.Location = new System.Drawing.Point(325, 62);
            this.cosoY.Name = "cosoY";
            this.cosoY.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.cosoY.Size = new System.Drawing.Size(83, 71);
            this.cosoY.TabIndex = 6;
            this.cosoY.Tag = "Calculadora";
            this.cosoY.Text = "Eje Y";
            this.cosoY.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cosoY.UseVisualStyleBackColor = true;
            // 
            // botones4
            // 
            this.botones4.BackColor = System.Drawing.Color.Transparent;
            this.botones4.BackgroundColor = System.Drawing.Color.Transparent;
            this.botones4.BackgroundImage = global::PaletizadoraV1._0.Properties.Resources.PinzaCerrada;
            this.botones4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botones4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botones4.BorderRadius = 20;
            this.botones4.BorderSize = 0;
            this.botones4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botones4.FlatAppearance.BorderSize = 0;
            this.botones4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones4.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botones4.ForeColor = System.Drawing.Color.Black;
            this.botones4.Location = new System.Drawing.Point(84, 253);
            this.botones4.Name = "botones4";
            this.botones4.Size = new System.Drawing.Size(85, 112);
            this.botones4.TabIndex = 38;
            this.botones4.Tag = "h";
            this.botones4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botones4.TextColor = System.Drawing.Color.Black;
            this.botones4.UseVisualStyleBackColor = false;
            this.botones4.Click += new System.EventHandler(this.controlDePistones);
            // 
            // botones3
            // 
            this.botones3.BackColor = System.Drawing.Color.Transparent;
            this.botones3.BackgroundColor = System.Drawing.Color.Transparent;
            this.botones3.BackgroundImage = global::PaletizadoraV1._0.Properties.Resources.PinzaAbierta;
            this.botones3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botones3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botones3.BorderRadius = 20;
            this.botones3.BorderSize = 0;
            this.botones3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botones3.FlatAppearance.BorderSize = 0;
            this.botones3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones3.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botones3.ForeColor = System.Drawing.Color.Black;
            this.botones3.Location = new System.Drawing.Point(84, 253);
            this.botones3.Name = "botones3";
            this.botones3.Size = new System.Drawing.Size(85, 112);
            this.botones3.TabIndex = 37;
            this.botones3.Tag = "y";
            this.botones3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botones3.TextColor = System.Drawing.Color.Black;
            this.botones3.UseVisualStyleBackColor = false;
            this.botones3.Click += new System.EventHandler(this.controlDePistones);
            // 
            // botones2
            // 
            this.botones2.BackColor = System.Drawing.Color.Transparent;
            this.botones2.BackgroundColor = System.Drawing.Color.Transparent;
            this.botones2.BackgroundImage = global::PaletizadoraV1._0.Properties.Resources.Sintroducir;
            this.botones2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botones2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botones2.BorderRadius = 20;
            this.botones2.BorderSize = 0;
            this.botones2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botones2.FlatAppearance.BorderSize = 0;
            this.botones2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones2.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botones2.ForeColor = System.Drawing.Color.Black;
            this.botones2.Location = new System.Drawing.Point(84, 66);
            this.botones2.Name = "botones2";
            this.botones2.Size = new System.Drawing.Size(120, 181);
            this.botones2.TabIndex = 36;
            this.botones2.Tag = "z";
            this.botones2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botones2.TextColor = System.Drawing.Color.Black;
            this.botones2.UseVisualStyleBackColor = false;
            this.botones2.Click += new System.EventHandler(this.controlDePistones);
            // 
            // botones1
            // 
            this.botones1.BackColor = System.Drawing.Color.Transparent;
            this.botones1.BackgroundColor = System.Drawing.Color.Transparent;
            this.botones1.BackgroundImage = global::PaletizadoraV1._0.Properties.Resources.SRetirart;
            this.botones1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botones1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botones1.BorderRadius = 10;
            this.botones1.BorderSize = 0;
            this.botones1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botones1.FlatAppearance.BorderSize = 0;
            this.botones1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botones1.ForeColor = System.Drawing.Color.Black;
            this.botones1.Location = new System.Drawing.Point(61, 96);
            this.botones1.Name = "botones1";
            this.botones1.Size = new System.Drawing.Size(129, 119);
            this.botones1.TabIndex = 34;
            this.botones1.Tag = "v";
            this.botones1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botones1.TextColor = System.Drawing.Color.Black;
            this.botones1.UseVisualStyleBackColor = false;
            this.botones1.Click += new System.EventHandler(this.controlDePistones);
            // 
            // EnvioManualSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 434);
            this.Controls.Add(this.panelEnvCoorSimp);
            this.Name = "EnvioManualSimple";
            this.Text = "Envío simple de coordenadas";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelEnvCoorSimp.ResumeLayout(false);
            this.panelEnvCoorSimp.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton cosox;
        private FontAwesome.Sharp.IconButton cosoY;
        private FontAwesome.Sharp.IconButton EnviarCoord1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelEnvCoorSimp;
        private System.Windows.Forms.TextBox txtEjeX;
        private System.Windows.Forms.TextBox txtEjeY;
        private System.Windows.Forms.Panel panel2;
        private botones botones4;
        private botones botones3;
        private botones botones2;
        private botones botones1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton resetPaletiBtn;
    }
}