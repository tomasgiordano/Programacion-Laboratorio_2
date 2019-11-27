namespace RPP
{
    partial class RPPForm
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
            this.btnAgregarTren = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtAerolinea = new System.Windows.Forms.TextBox();
            this.btnAgregarAvion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregarTren
            // 
            this.btnAgregarTren.Location = new System.Drawing.Point(432, 15);
            this.btnAgregarTren.Name = "btnAgregarTren";
            this.btnAgregarTren.Size = new System.Drawing.Size(108, 92);
            this.btnAgregarTren.TabIndex = 25;
            this.btnAgregarTren.Text = "Comprar Tren";
            this.btnAgregarTren.UseVisualStyleBackColor = true;
            this.btnAgregarTren.Click += new System.EventHandler(this.BtnAgregarTren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Velocidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Aerolinea";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(118, 50);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(174, 20);
            this.txtEmpresa.TabIndex = 19;
            // 
            // txtAerolinea
            // 
            this.txtAerolinea.Location = new System.Drawing.Point(118, 15);
            this.txtAerolinea.Name = "txtAerolinea";
            this.txtAerolinea.Size = new System.Drawing.Size(174, 20);
            this.txtAerolinea.TabIndex = 18;
            // 
            // btnAgregarAvion
            // 
            this.btnAgregarAvion.Location = new System.Drawing.Point(318, 15);
            this.btnAgregarAvion.Name = "btnAgregarAvion";
            this.btnAgregarAvion.Size = new System.Drawing.Size(108, 92);
            this.btnAgregarAvion.TabIndex = 15;
            this.btnAgregarAvion.Text = "Comprar Avion";
            this.btnAgregarAvion.UseVisualStyleBackColor = true;
            this.btnAgregarAvion.Click += new System.EventHandler(this.BtnAgregarAvion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Empresa";
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(118, 86);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(174, 20);
            this.txtVelocidad.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 307);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.btnAgregarTren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtAerolinea);
            this.Controls.Add(this.btnAgregarAvion);
            this.Name = "Form1";
            this.Text = "RPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarTren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtAerolinea;
        private System.Windows.Forms.Button btnAgregarAvion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVelocidad;
    }
}

