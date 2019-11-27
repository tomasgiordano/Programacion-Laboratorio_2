namespace Hilos
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
            this.buttonIniciarProceso = new System.Windows.Forms.Button();
            this.buttonMostrarMensaje = new System.Windows.Forms.Button();
            this.labelProgreso = new System.Windows.Forms.Label();
            this.progressBarProgreso = new System.Windows.Forms.ProgressBar();
            this.labelTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIniciarProceso
            // 
            this.buttonIniciarProceso.Location = new System.Drawing.Point(12, 141);
            this.buttonIniciarProceso.Name = "buttonIniciarProceso";
            this.buttonIniciarProceso.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciarProceso.TabIndex = 0;
            this.buttonIniciarProceso.Text = "Iniciar";
            this.buttonIniciarProceso.UseVisualStyleBackColor = true;
            this.buttonIniciarProceso.Click += new System.EventHandler(this.buttonIniciarProceso_Click);
            // 
            // buttonMostrarMensaje
            // 
            this.buttonMostrarMensaje.Location = new System.Drawing.Point(122, 141);
            this.buttonMostrarMensaje.Name = "buttonMostrarMensaje";
            this.buttonMostrarMensaje.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrarMensaje.TabIndex = 1;
            this.buttonMostrarMensaje.Text = "Mostrar";
            this.buttonMostrarMensaje.UseVisualStyleBackColor = true;
            this.buttonMostrarMensaje.Click += new System.EventHandler(this.buttonMostrarMensaje_Click);
            // 
            // labelProgreso
            // 
            this.labelProgreso.AutoSize = true;
            this.labelProgreso.Location = new System.Drawing.Point(12, 46);
            this.labelProgreso.Name = "labelProgreso";
            this.labelProgreso.Size = new System.Drawing.Size(58, 13);
            this.labelProgreso.TabIndex = 2;
            this.labelProgreso.Text = "Progreso...";
            // 
            // progressBarProgreso
            // 
            this.progressBarProgreso.Location = new System.Drawing.Point(12, 62);
            this.progressBarProgreso.Name = "progressBarProgreso";
            this.progressBarProgreso.Size = new System.Drawing.Size(185, 23);
            this.progressBarProgreso.TabIndex = 3;
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(12, 9);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(67, 13);
            this.labelTexto.TabIndex = 4;
            this.labelTexto.Text = "Random text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 177);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.progressBarProgreso);
            this.Controls.Add(this.labelProgreso);
            this.Controls.Add(this.buttonMostrarMensaje);
            this.Controls.Add(this.buttonIniciarProceso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciarProceso;
        private System.Windows.Forms.Button buttonMostrarMensaje;
        private System.Windows.Forms.Label labelProgreso;
        private System.Windows.Forms.ProgressBar progressBarProgreso;
        private System.Windows.Forms.Label labelTexto;
    }
}

