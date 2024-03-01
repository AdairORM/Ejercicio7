namespace Ejercicio7
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
            this.lbinicio = new System.Windows.Forms.Label();
            this.lbArregloPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbinicio
            // 
            this.lbinicio.AutoSize = true;
            this.lbinicio.Location = new System.Drawing.Point(29, 37);
            this.lbinicio.Name = "lbinicio";
            this.lbinicio.Size = new System.Drawing.Size(130, 13);
            this.lbinicio.TabIndex = 0;
            this.lbinicio.Text = "Precio de los automóviles:";
            this.lbinicio.UseMnemonic = false;
            // 
            // lbArregloPrecio
            // 
            this.lbArregloPrecio.AutoSize = true;
            this.lbArregloPrecio.Location = new System.Drawing.Point(31, 70);
            this.lbArregloPrecio.Name = "lbArregloPrecio";
            this.lbArregloPrecio.Size = new System.Drawing.Size(42, 13);
            this.lbArregloPrecio.TabIndex = 1;
            this.lbArregloPrecio.Text = "Mostrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbArregloPrecio);
            this.Controls.Add(this.lbinicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbinicio;
        private System.Windows.Forms.Label lbArregloPrecio;
    }
}

