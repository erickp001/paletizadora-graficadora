namespace PaletizadoraV1._0
{
    partial class STextBox
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxS
            // 
            this.textBoxS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxS.Location = new System.Drawing.Point(7, 7);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(136, 15);
            this.textBoxS.TabIndex = 0;
            this.textBoxS.Enter += new System.EventHandler(this.textBoxS_Enter);
            this.textBoxS.Leave += new System.EventHandler(this.textBoxS_Leave);
            // 
            // STextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBoxS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "STextBox";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(150, 30);
            this.Load += new System.EventHandler(this.STextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxS;
    }
}
