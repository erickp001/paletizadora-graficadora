namespace PaletizadoraV1._0
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.EnvioManualSimple = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.botonInicio = new System.Windows.Forms.PictureBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.IngresoManual = new FontAwesome.Sharp.IconButton();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.manualBtn = new FontAwesome.Sharp.IconButton();
            this.guiasBtn = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetPaletiBtn = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.dropMenu1 = new PaletizadoraV1._0.DropMenu(this.components);
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraGráficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropMenu2 = new PaletizadoraV1._0.DropMenu(this.components);
            this.dibujoDeImagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraGráficaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonInicio)).BeginInit();
            this.PanelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dropMenu1.SuspendLayout();
            this.dropMenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Lavender;
            this.panelMenu.Controls.Add(this.EnvioManualSimple);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.botonInicio);
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.IngresoManual);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(190, 516);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EnvioManualSimple
            // 
            this.EnvioManualSimple.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnvioManualSimple.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.EnvioManualSimple.FlatAppearance.BorderSize = 0;
            this.EnvioManualSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnvioManualSimple.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnvioManualSimple.ForeColor = System.Drawing.Color.Black;
            this.EnvioManualSimple.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.EnvioManualSimple.IconColor = System.Drawing.Color.Black;
            this.EnvioManualSimple.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EnvioManualSimple.IconSize = 40;
            this.EnvioManualSimple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnvioManualSimple.Location = new System.Drawing.Point(-7, 297);
            this.EnvioManualSimple.Name = "EnvioManualSimple";
            this.EnvioManualSimple.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EnvioManualSimple.Size = new System.Drawing.Size(207, 71);
            this.EnvioManualSimple.TabIndex = 7;
            this.EnvioManualSimple.Tag = "ola";
            this.EnvioManualSimple.Text = "Modos de graficador";
            this.EnvioManualSimple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnvioManualSimple.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EnvioManualSimple.UseVisualStyleBackColor = true;
            this.EnvioManualSimple.Click += new System.EventHandler(this.EnvioManualSimple_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenu.IconColor = System.Drawing.Color.Black;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(133, 18);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(45, 37);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Tag = "menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // botonInicio
            // 
            this.botonInicio.Image = global::PaletizadoraV1._0.Properties.Resources.degem_systems_prov_2x;
            this.botonInicio.Location = new System.Drawing.Point(15, 14);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(112, 43);
            this.botonInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonInicio.TabIndex = 0;
            this.botonInicio.TabStop = false;
            this.botonInicio.Tag = "foto";
            this.botonInicio.Click += new System.EventHandler(this.botonInicio_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(311, 223);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(0, 0);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // IngresoManual
            // 
            this.IngresoManual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IngresoManual.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.IngresoManual.FlatAppearance.BorderSize = 0;
            this.IngresoManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngresoManual.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresoManual.ForeColor = System.Drawing.Color.Black;
            this.IngresoManual.IconChar = FontAwesome.Sharp.IconChar.LaptopCode;
            this.IngresoManual.IconColor = System.Drawing.Color.Black;
            this.IngresoManual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IngresoManual.IconSize = 40;
            this.IngresoManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IngresoManual.Location = new System.Drawing.Point(-7, 220);
            this.IngresoManual.Name = "IngresoManual";
            this.IngresoManual.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.IngresoManual.Size = new System.Drawing.Size(207, 71);
            this.IngresoManual.TabIndex = 1;
            this.IngresoManual.Tag = "computadora";
            this.IngresoManual.Text = "Modos de paletizadora";
            this.IngresoManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IngresoManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IngresoManual.UseVisualStyleBackColor = true;
            this.IngresoManual.Click += new System.EventHandler(this.Boton2_Click);
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.PanelTitleBar.Controls.Add(this.btnExit);
            this.PanelTitleBar.Controls.Add(this.btnMinimize);
            this.PanelTitleBar.Controls.Add(this.btnMaximize);
            this.PanelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(190, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(788, 71);
            this.PanelTitleBar.TabIndex = 1;
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.iconCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 70;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(35, 2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(69, 69);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconCurrentChildForm.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 15;
            this.btnExit.Location = new System.Drawing.Point(758, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 20);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 15;
            this.btnMinimize.Location = new System.Drawing.Point(704, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 20);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 15;
            this.btnMaximize.Location = new System.Drawing.Point(728, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(27, 20);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.Location = new System.Drawing.Point(110, 18);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(86, 31);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Gray;
            this.panelDesktop.Controls.Add(this.manualBtn);
            this.panelDesktop.Controls.Add(this.guiasBtn);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.resetPaletiBtn);
            this.panelDesktop.Controls.Add(this.panelShadow);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(190, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(788, 516);
            this.panelDesktop.TabIndex = 3;
            // 
            // manualBtn
            // 
            this.manualBtn.FlatAppearance.BorderSize = 0;
            this.manualBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualBtn.ForeColor = System.Drawing.Color.White;
            this.manualBtn.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.manualBtn.IconColor = System.Drawing.Color.White;
            this.manualBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.manualBtn.IconSize = 70;
            this.manualBtn.Location = new System.Drawing.Point(246, 347);
            this.manualBtn.Name = "manualBtn";
            this.manualBtn.Size = new System.Drawing.Size(94, 146);
            this.manualBtn.TabIndex = 8;
            this.manualBtn.Text = "Manual de usuario";
            this.manualBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.manualBtn.UseVisualStyleBackColor = true;
            this.manualBtn.Click += new System.EventHandler(this.manualBtn_Click);
            // 
            // guiasBtn
            // 
            this.guiasBtn.FlatAppearance.BorderSize = 0;
            this.guiasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guiasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guiasBtn.ForeColor = System.Drawing.Color.White;
            this.guiasBtn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.guiasBtn.IconColor = System.Drawing.Color.White;
            this.guiasBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.guiasBtn.IconSize = 70;
            this.guiasBtn.Location = new System.Drawing.Point(404, 347);
            this.guiasBtn.Name = "guiasBtn";
            this.guiasBtn.Size = new System.Drawing.Size(120, 146);
            this.guiasBtn.TabIndex = 7;
            this.guiasBtn.Text = "Guías de aprendizaje";
            this.guiasBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guiasBtn.UseVisualStyleBackColor = true;
            this.guiasBtn.Click += new System.EventHandler(this.guiasBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PaletizadoraV1._0.Properties.Resources.PaletizadoraDibujo50percent;
            this.pictureBox1.Location = new System.Drawing.Point(269, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // resetPaletiBtn
            // 
            this.resetPaletiBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetPaletiBtn.FlatAppearance.BorderSize = 0;
            this.resetPaletiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPaletiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPaletiBtn.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.resetPaletiBtn.IconColor = System.Drawing.Color.Black;
            this.resetPaletiBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.resetPaletiBtn.Location = new System.Drawing.Point(710, 432);
            this.resetPaletiBtn.Name = "resetPaletiBtn";
            this.resetPaletiBtn.Size = new System.Drawing.Size(78, 84);
            this.resetPaletiBtn.TabIndex = 5;
            this.resetPaletiBtn.Text = "Punto 0";
            this.resetPaletiBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resetPaletiBtn.UseVisualStyleBackColor = true;
            this.resetPaletiBtn.Visible = false;
            this.resetPaletiBtn.Click += new System.EventHandler(this.resetPaletiBtn_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(0, 0);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(788, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // dropMenu1
            // 
            this.dropMenu1.IsMainMenu = false;
            this.dropMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItem,
            this.graficadorToolStripMenuItem,
            this.calculadoraGráficaToolStripMenuItem});
            this.dropMenu1.MenuItemHeight = 25;
            this.dropMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.dropMenu1.Name = "dropMenu1";
            this.dropMenu1.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.dropMenu1.Size = new System.Drawing.Size(162, 70);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mToolStripMenuItem.Text = "Manual";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // graficadorToolStripMenuItem
            // 
            this.graficadorToolStripMenuItem.Name = "graficadorToolStripMenuItem";
            this.graficadorToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.graficadorToolStripMenuItem.Text = "Semiautomático";
            this.graficadorToolStripMenuItem.Click += new System.EventHandler(this.graficadorToolStripMenuItem_Click_1);
            // 
            // calculadoraGráficaToolStripMenuItem
            // 
            this.calculadoraGráficaToolStripMenuItem.Name = "calculadoraGráficaToolStripMenuItem";
            this.calculadoraGráficaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.calculadoraGráficaToolStripMenuItem.Text = "Automatización";
            this.calculadoraGráficaToolStripMenuItem.Click += new System.EventHandler(this.calculadoraGráficaToolStripMenuItem_Click);
            // 
            // dropMenu2
            // 
            this.dropMenu2.IsMainMenu = false;
            this.dropMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dibujoDeImagenesToolStripMenuItem,
            this.calculadoraGráficaToolStripMenuItem1});
            this.dropMenu2.MenuItemHeight = 25;
            this.dropMenu2.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.dropMenu2.Name = "dropMenu2";
            this.dropMenu2.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.dropMenu2.Size = new System.Drawing.Size(180, 48);
            // 
            // dibujoDeImagenesToolStripMenuItem
            // 
            this.dibujoDeImagenesToolStripMenuItem.Name = "dibujoDeImagenesToolStripMenuItem";
            this.dibujoDeImagenesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.dibujoDeImagenesToolStripMenuItem.Text = "Dibujo de imágenes";
            this.dibujoDeImagenesToolStripMenuItem.Click += new System.EventHandler(this.dibujoDeImagenesToolStripMenuItem_Click);
            // 
            // calculadoraGráficaToolStripMenuItem1
            // 
            this.calculadoraGráficaToolStripMenuItem1.Name = "calculadoraGráficaToolStripMenuItem1";
            this.calculadoraGráficaToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.calculadoraGráficaToolStripMenuItem1.Text = "Calculadora gráfica";
            this.calculadoraGráficaToolStripMenuItem1.Click += new System.EventHandler(this.calculadoraGráficaToolStripMenuItem1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(978, 516);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonInicio)).EndInit();
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dropMenu1.ResumeLayout(false);
            this.dropMenu2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton IngresoManual;
        private System.Windows.Forms.Panel PanelTitleBar;
        private FontAwesome.Sharp.IconButton iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.PictureBox botonInicio;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton EnvioManualSimple;
        private DropMenu dropMenu1;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraGráficaToolStripMenuItem;
        private DropMenu dropMenu2;
        private System.Windows.Forms.ToolStripMenuItem dibujoDeImagenesToolStripMenuItem;
        private FontAwesome.Sharp.IconButton resetPaletiBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton manualBtn;
        private FontAwesome.Sharp.IconButton guiasBtn;
        private System.Windows.Forms.ToolStripMenuItem calculadoraGráficaToolStripMenuItem1;
    }
}

