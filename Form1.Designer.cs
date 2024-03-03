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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPrecioPromedio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPromedioCuenta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrar.Location = new System.Drawing.Point(184, 30);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(120, 27);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Precio";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrarPrecio_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(184, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Precio promedio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnPrecioPromedio_Click);
            // 
            // lbPrecioPromedio
            // 
            this.lbPrecioPromedio.AutoSize = true;
            this.lbPrecioPromedio.Location = new System.Drawing.Point(83, 124);
            this.lbPrecioPromedio.Name = "lbPrecioPromedio";
            this.lbPrecioPromedio.Size = new System.Drawing.Size(13, 13);
            this.lbPrecioPromedio.TabIndex = 1;
            this.lbPrecioPromedio.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promedio de los precios de los automóviles";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Se tiene un total de:";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "$ ";
            // 
            // lbPromedioCuenta
            // 
            this.lbPromedioCuenta.AutoSize = true;
            this.lbPromedioCuenta.Location = new System.Drawing.Point(146, 181);
            this.lbPromedioCuenta.Name = "lbPromedioCuenta";
            this.lbPromedioCuenta.Size = new System.Drawing.Size(13, 13);
            this.lbPromedioCuenta.TabIndex = 0;
            this.lbPromedioCuenta.Text = "0";
            this.lbPromedioCuenta.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "automóviles superior al precio promedio";
            this.label5.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPrecioPromedio);
            this.Controls.Add(this.lbPromedioCuenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbinicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.btnMostrarPrecio_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbinicio;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPrecioPromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPromedioCuenta;
        private System.Windows.Forms.Label label5;
    }
}

