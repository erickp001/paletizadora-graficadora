namespace PaletizadoraV1._0
{
    partial class DibujoGCode
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CeroGCode = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar = new PaletizadoraV1._0.botones();
            this.dibujar = new PaletizadoraV1._0.botones();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.CeroGCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buscar);
            this.panel1.Controls.Add(this.dibujar);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 467);
            this.panel1.TabIndex = 0;
            // 
            // CeroGCode
            // 
            this.CeroGCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CeroGCode.FlatAppearance.BorderSize = 0;
            this.CeroGCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CeroGCode.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.CeroGCode.IconColor = System.Drawing.Color.Black;
            this.CeroGCode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CeroGCode.Location = new System.Drawing.Point(3, 400);
            this.CeroGCode.Name = "CeroGCode";
            this.CeroGCode.Size = new System.Drawing.Size(56, 57);
            this.CeroGCode.TabIndex = 17;
            this.CeroGCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CeroGCode.UseVisualStyleBackColor = true;
            this.CeroGCode.Click += new System.EventHandler(this.CeroGCode_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.buscar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.buscar.BorderColor = System.Drawing.Color.Black;
            this.buscar.BorderRadius = 20;
            this.buscar.BorderSize = 2;
            this.buscar.FlatAppearance.BorderSize = 0;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ForeColor = System.Drawing.Color.White;
            this.buscar.Location = new System.Drawing.Point(439, 198);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(150, 40);
            this.buscar.TabIndex = 15;
            this.buscar.Text = "Buscar Imagen";
            this.buscar.TextColor = System.Drawing.Color.White;
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // dibujar
            // 
            this.dibujar.BackColor = System.Drawing.Color.RoyalBlue;
            this.dibujar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dibujar.BorderColor = System.Drawing.Color.Black;
            this.dibujar.BorderRadius = 20;
            this.dibujar.BorderSize = 2;
            this.dibujar.FlatAppearance.BorderSize = 0;
            this.dibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dibujar.ForeColor = System.Drawing.Color.White;
            this.dibujar.Location = new System.Drawing.Point(439, 283);
            this.dibujar.Name = "dibujar";
            this.dibujar.Size = new System.Drawing.Size(150, 40);
            this.dibujar.TabIndex = 14;
            this.dibujar.Text = "Enviar Imagen";
            this.dibujar.TextColor = System.Drawing.Color.White;
            this.dibujar.UseVisualStyleBackColor = false;
            this.dibujar.Click += new System.EventHandler(this.dibujar_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 13500D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 9000D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 68);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Desplazamiento";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(535, 384);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DibujoGCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 466);
            this.Controls.Add(this.panel1);
            this.Name = "DibujoGCode";
            this.Tag = "";
            this.Text = "Dibujo con código G";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private botones buscar;
        private botones dibujar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton CeroGCode;
    }
}