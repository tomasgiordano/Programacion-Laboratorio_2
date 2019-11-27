namespace FinalLaboII
{
    partial class RSPyFinalForm
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
            this.btnAgregarAvion = new System.Windows.Forms.Button();
            this.txtAerolineaEmpresa = new System.Windows.Forms.TextBox();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMostrarAvion = new System.Windows.Forms.Button();
            this.btnAgregarTren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarAvion
            // 
            this.btnAgregarAvion.Location = new System.Drawing.Point(21, 12);
            this.btnAgregarAvion.Name = "btnAgregarAvion";
            this.btnAgregarAvion.Size = new System.Drawing.Size(108, 92);
            this.btnAgregarAvion.TabIndex = 0;
            this.btnAgregarAvion.Text = "Agregar Avion";
            this.btnAgregarAvion.UseVisualStyleBackColor = true;
            this.btnAgregarAvion.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtAerolineaEmpresa
            // 
            this.txtAerolineaEmpresa.Location = new System.Drawing.Point(370, 12);
            this.txtAerolineaEmpresa.Name = "txtAerolineaEmpresa";
            this.txtAerolineaEmpresa.Size = new System.Drawing.Size(174, 20);
            this.txtAerolineaEmpresa.TabIndex = 4;
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(370, 47);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(174, 20);
            this.txtVelocidad.TabIndex = 5;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(370, 83);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(174, 21);
            this.cmbFabricante.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aerolinea/Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Velocidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fabricante";
            // 
            // btnMostrarAvion
            // 
            this.btnMostrarAvion.Location = new System.Drawing.Point(21, 140);
            this.btnMostrarAvion.Name = "btnMostrarAvion";
            this.btnMostrarAvion.Size = new System.Drawing.Size(523, 55);
            this.btnMostrarAvion.TabIndex = 12;
            this.btnMostrarAvion.Text = "Enviar Avión";
            this.btnMostrarAvion.UseVisualStyleBackColor = true;
            this.btnMostrarAvion.Click += new System.EventHandler(this.BtnMostrarAvion_Click);
            // 
            // btnAgregarTren
            // 
            this.btnAgregarTren.Location = new System.Drawing.Point(135, 12);
            this.btnAgregarTren.Name = "btnAgregarTren";
            this.btnAgregarTren.Size = new System.Drawing.Size(108, 92);
            this.btnAgregarTren.TabIndex = 13;
            this.btnAgregarTren.Text = "Agregar Tren";
            this.btnAgregarTren.UseVisualStyleBackColor = true;
            this.btnAgregarTren.Click += new System.EventHandler(this.BtnAgregarTren_Click);
            // 
            // RSPyFinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 209);
            this.Controls.Add(this.btnAgregarTren);
            this.Controls.Add(this.btnMostrarAvion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.txtAerolineaEmpresa);
            this.Controls.Add(this.btnAgregarAvion);
            this.Name = "RSPyFinalForm";
            this.Text = "RSP y Final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAvion;
        private System.Windows.Forms.TextBox txtAerolineaEmpresa;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrarAvion;
        private System.Windows.Forms.Button btnAgregarTren;
    }
}

