namespace Listas_CircularesAtención_de_procesos
{
    partial class Form1
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
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(12, 23);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(225, 81);
            this.txtMostrar.TabIndex = 4;
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.Transparent;
            this.btnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimular.Location = new System.Drawing.Point(88, 110);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(85, 30);
            this.btnSimular.TabIndex = 3;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 168);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btnSimular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.Button btnSimular;
    }
}

