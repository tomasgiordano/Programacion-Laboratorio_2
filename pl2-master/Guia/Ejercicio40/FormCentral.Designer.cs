namespace Ejercicio40
{
    partial class FormCentral
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
            this.buttonGenerarLlamada = new System.Windows.Forms.Button();
            this.buttonFacturacionTotal = new System.Windows.Forms.Button();
            this.buttonFacturacionLocal = new System.Windows.Forms.Button();
            this.buttonFacturacionProvincial = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerarLlamada
            // 
            this.buttonGenerarLlamada.Location = new System.Drawing.Point(12, 12);
            this.buttonGenerarLlamada.Name = "buttonGenerarLlamada";
            this.buttonGenerarLlamada.Size = new System.Drawing.Size(175, 23);
            this.buttonGenerarLlamada.TabIndex = 0;
            this.buttonGenerarLlamada.Text = "Generar llamada";
            this.buttonGenerarLlamada.UseVisualStyleBackColor = true;
            this.buttonGenerarLlamada.Click += new System.EventHandler(this.buttonGenerarLlamada_Click);
            // 
            // buttonFacturacionTotal
            // 
            this.buttonFacturacionTotal.Location = new System.Drawing.Point(12, 41);
            this.buttonFacturacionTotal.Name = "buttonFacturacionTotal";
            this.buttonFacturacionTotal.Size = new System.Drawing.Size(175, 23);
            this.buttonFacturacionTotal.TabIndex = 1;
            this.buttonFacturacionTotal.Text = "Facturación total";
            this.buttonFacturacionTotal.UseVisualStyleBackColor = true;
            this.buttonFacturacionTotal.Click += new System.EventHandler(this.buttonFacturacionTotal_Click);
            // 
            // buttonFacturacionLocal
            // 
            this.buttonFacturacionLocal.Location = new System.Drawing.Point(12, 70);
            this.buttonFacturacionLocal.Name = "buttonFacturacionLocal";
            this.buttonFacturacionLocal.Size = new System.Drawing.Size(175, 23);
            this.buttonFacturacionLocal.TabIndex = 2;
            this.buttonFacturacionLocal.Text = "Facturación local";
            this.buttonFacturacionLocal.UseVisualStyleBackColor = true;
            this.buttonFacturacionLocal.Click += new System.EventHandler(this.buttonFacturacionLocal_Click);
            // 
            // buttonFacturacionProvincial
            // 
            this.buttonFacturacionProvincial.Location = new System.Drawing.Point(12, 99);
            this.buttonFacturacionProvincial.Name = "buttonFacturacionProvincial";
            this.buttonFacturacionProvincial.Size = new System.Drawing.Size(175, 23);
            this.buttonFacturacionProvincial.TabIndex = 3;
            this.buttonFacturacionProvincial.Text = "Facturación provincial";
            this.buttonFacturacionProvincial.UseVisualStyleBackColor = true;
            this.buttonFacturacionProvincial.Click += new System.EventHandler(this.buttonFacturacionProvincial_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSalir.Location = new System.Drawing.Point(12, 128);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(175, 23);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FormCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonSalir;
            this.ClientSize = new System.Drawing.Size(199, 160);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonFacturacionProvincial);
            this.Controls.Add(this.buttonFacturacionLocal);
            this.Controls.Add(this.buttonFacturacionTotal);
            this.Controls.Add(this.buttonGenerarLlamada);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCentral";
            this.Text = "FormCentral";
            this.Load += new System.EventHandler(this.FormCentral_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerarLlamada;
        private System.Windows.Forms.Button buttonFacturacionTotal;
        private System.Windows.Forms.Button buttonFacturacionLocal;
        private System.Windows.Forms.Button buttonFacturacionProvincial;
        private System.Windows.Forms.Button buttonSalir;
    }
}