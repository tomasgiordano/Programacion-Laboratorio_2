namespace SistemaSolar
{
    partial class FormSistemaSolar
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
            this.btnRotarPlaneta = new System.Windows.Forms.Button();
            this.btnOrbitarSatelite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSatelite = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txRota = new System.Windows.Forms.TextBox();
            this.txOrbita = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRotarPlaneta
            // 
            this.btnRotarPlaneta.Location = new System.Drawing.Point(21, 39);
            this.btnRotarPlaneta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRotarPlaneta.Name = "btnRotarPlaneta";
            this.btnRotarPlaneta.Size = new System.Drawing.Size(285, 47);
            this.btnRotarPlaneta.TabIndex = 3;
            this.btnRotarPlaneta.Text = "Rotar Planeta";
            this.btnRotarPlaneta.UseVisualStyleBackColor = true;
            this.btnRotarPlaneta.Click += new System.EventHandler(this.btnRotarPlaneta_Click);
            // 
            // btnOrbitarSatelite
            // 
            this.btnOrbitarSatelite.Location = new System.Drawing.Point(331, 39);
            this.btnOrbitarSatelite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrbitarSatelite.Name = "btnOrbitarSatelite";
            this.btnOrbitarSatelite.Size = new System.Drawing.Size(215, 47);
            this.btnOrbitarSatelite.TabIndex = 4;
            this.btnOrbitarSatelite.Text = "Orbitar Satélites";
            this.btnOrbitarSatelite.UseVisualStyleBackColor = true;
            this.btnOrbitarSatelite.Click += new System.EventHandler(this.btnOrbitarSatelite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSatelite);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txRota);
            this.groupBox1.Controls.Add(this.txOrbita);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Location = new System.Drawing.Point(21, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(525, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satelites";
            // 
            // btnSatelite
            // 
            this.btnSatelite.Location = new System.Drawing.Point(287, 36);
            this.btnSatelite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSatelite.Name = "btnSatelite";
            this.btnSatelite.Size = new System.Drawing.Size(208, 88);
            this.btnSatelite.TabIndex = 7;
            this.btnSatelite.Text = "Crear Satélite";
            this.btnSatelite.UseVisualStyleBackColor = true;
            this.btnSatelite.Click += new System.EventHandler(this.btnSatelite_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Duracion Rotacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Duracion Orbita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // txRota
            // 
            this.txRota.Location = new System.Drawing.Point(127, 110);
            this.txRota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txRota.Name = "txRota";
            this.txRota.Size = new System.Drawing.Size(127, 20);
            this.txRota.TabIndex = 9;
            // 
            // txOrbita
            // 
            this.txOrbita.Location = new System.Drawing.Point(127, 71);
            this.txOrbita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txOrbita.Name = "txOrbita";
            this.txOrbita.Size = new System.Drawing.Size(127, 20);
            this.txOrbita.TabIndex = 8;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(127, 36);
            this.txNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(127, 20);
            this.txNombre.TabIndex = 7;
            // 
            // FormSistemaSolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 272);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrbitarSatelite);
            this.Controls.Add(this.btnRotarPlaneta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSistemaSolar";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRotarPlaneta;
        private System.Windows.Forms.Button btnOrbitarSatelite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txRota;
        private System.Windows.Forms.TextBox txOrbita;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Button btnSatelite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

