namespace PaletizadoraV1._0
{
    partial class FormIngresoAuto
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colocarPlaca = new PaletizadoraV1._0.botones();
            this.recogerPlaca = new PaletizadoraV1._0.botones();
            this.resetPaletiBtn = new FontAwesome.Sharp.IconButton();
            this.button1 = new PaletizadoraV1._0.botones();
            this.button3 = new PaletizadoraV1._0.botones();
            this.button4 = new PaletizadoraV1._0.botones();
            this.button2 = new PaletizadoraV1._0.botones();
            this.button5 = new PaletizadoraV1._0.botones();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(348, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(130, 122);
            this.listBox1.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineWidth = 3;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.Maximum = 4D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea2.AxisY.Interval = 1D;
            chartArea2.AxisY.Maximum = 4D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.CursorX.Interval = 2D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-10, 88);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Desplazamiento";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Enabled = false;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Posicion";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(517, 308);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(363, 161);
            this.textBox3.MaxLength = 3;
            this.textBox3.Name = "textBox3";
            this.textBox3.ShortcutsEnabled = false;
            this.textBox3.Size = new System.Drawing.Size(99, 20);
            this.textBox3.TabIndex = 24;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.colocarPlaca);
            this.panel1.Controls.Add(this.recogerPlaca);
            this.panel1.Controls.Add(this.resetPaletiBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(22, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 459);
            this.panel1.TabIndex = 29;
            // 
            // colocarPlaca
            // 
            this.colocarPlaca.BackColor = System.Drawing.Color.IndianRed;
            this.colocarPlaca.BackgroundColor = System.Drawing.Color.IndianRed;
            this.colocarPlaca.BorderColor = System.Drawing.Color.Black;
            this.colocarPlaca.BorderRadius = 20;
            this.colocarPlaca.BorderSize = 1;
            this.colocarPlaca.FlatAppearance.BorderSize = 0;
            this.colocarPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colocarPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colocarPlaca.ForeColor = System.Drawing.Color.White;
            this.colocarPlaca.Location = new System.Drawing.Point(486, 218);
            this.colocarPlaca.Name = "colocarPlaca";
            this.colocarPlaca.Size = new System.Drawing.Size(111, 53);
            this.colocarPlaca.TabIndex = 40;
            this.colocarPlaca.Tag = "colocar";
            this.colocarPlaca.Text = "Colocar placa";
            this.colocarPlaca.TextColor = System.Drawing.Color.White;
            this.colocarPlaca.UseVisualStyleBackColor = false;
            this.colocarPlaca.Click += new System.EventHandler(this.controlDePistones);
            // 
            // recogerPlaca
            // 
            this.recogerPlaca.BackColor = System.Drawing.Color.IndianRed;
            this.recogerPlaca.BackgroundColor = System.Drawing.Color.IndianRed;
            this.recogerPlaca.BorderColor = System.Drawing.Color.Black;
            this.recogerPlaca.BorderRadius = 20;
            this.recogerPlaca.BorderSize = 1;
            this.recogerPlaca.FlatAppearance.BorderSize = 0;
            this.recogerPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recogerPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recogerPlaca.ForeColor = System.Drawing.Color.White;
            this.recogerPlaca.Location = new System.Drawing.Point(603, 218);
            this.recogerPlaca.Name = "recogerPlaca";
            this.recogerPlaca.Size = new System.Drawing.Size(111, 53);
            this.recogerPlaca.TabIndex = 39;
            this.recogerPlaca.Tag = "recoger";
            this.recogerPlaca.Text = "Recoger placa";
            this.recogerPlaca.TextColor = System.Drawing.Color.White;
            this.recogerPlaca.UseVisualStyleBackColor = false;
            this.recogerPlaca.Click += new System.EventHandler(this.controlDePistones);
            // 
            // resetPaletiBtn
            // 
            this.resetPaletiBtn.FlatAppearance.BorderSize = 0;
            this.resetPaletiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPaletiBtn.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.resetPaletiBtn.IconColor = System.Drawing.Color.Black;
            this.resetPaletiBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.resetPaletiBtn.Location = new System.Drawing.Point(0, 402);
            this.resetPaletiBtn.Name = "resetPaletiBtn";
            this.resetPaletiBtn.Size = new System.Drawing.Size(43, 57);
            this.resetPaletiBtn.TabIndex = 38;
            this.resetPaletiBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resetPaletiBtn.UseVisualStyleBackColor = true;
            this.resetPaletiBtn.Click += new System.EventHandler(this.resetPaletiBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.button1.BorderColor = System.Drawing.Color.Black;
            this.button1.BorderRadius = 20;
            this.button1.BorderSize = 1;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(603, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 53);
            this.button1.TabIndex = 27;
            this.button1.Text = "Borrar";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.BackgroundColor = System.Drawing.Color.Brown;
            this.button3.BorderColor = System.Drawing.Color.Black;
            this.button3.BorderRadius = 20;
            this.button3.BorderSize = 1;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(547, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 53);
            this.button3.TabIndex = 28;
            this.button3.Text = "Ejecutar";
            this.button3.TextColor = System.Drawing.Color.White;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.BackgroundColor = System.Drawing.Color.IndianRed;
            this.button4.BorderColor = System.Drawing.Color.Black;
            this.button4.BorderRadius = 20;
            this.button4.BorderSize = 1;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(603, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 53);
            this.button4.TabIndex = 33;
            this.button4.Text = "Limpiar lista";
            this.button4.TextColor = System.Drawing.Color.White;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.BackgroundColor = System.Drawing.Color.IndianRed;
            this.button2.BorderColor = System.Drawing.Color.Black;
            this.button2.BorderRadius = 20;
            this.button2.BorderSize = 1;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(486, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 53);
            this.button2.TabIndex = 25;
            this.button2.Text = "Agregar";
            this.button2.TextColor = System.Drawing.Color.White;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.BackgroundColor = System.Drawing.Color.IndianRed;
            this.button5.BorderColor = System.Drawing.Color.Black;
            this.button5.BorderRadius = 20;
            this.button5.BorderSize = 1;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(486, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 53);
            this.button5.TabIndex = 26;
            this.button5.Text = "Editar";
            this.button5.TextColor = System.Drawing.Color.White;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // FormIngresoAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 494);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(190, 0);
            this.Name = "FormIngresoAuto";
            this.Tag = "Ingreso Manual de coordenadas";
            this.Text = "Automatización de acciones";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox3;
        private botones button2;
        private botones button3;
        private botones button1;
        private botones button5;
        private System.Windows.Forms.Panel panel1;
        private botones button4;
        private FontAwesome.Sharp.IconButton resetPaletiBtn;
        private botones colocarPlaca;
        private botones recogerPlaca;
    }
}