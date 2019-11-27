namespace FormParcial
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
            this.btnRotarPlaneta = new System.Windows.Forms.Button();
            this.btnOrbitarSatelites = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblOrbita = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblRotacion = new System.Windows.Forms.Label();
            this.btnCrearSatelite = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRotarPlaneta
            // 
            this.btnRotarPlaneta.Location = new System.Drawing.Point(12, 12);
            this.btnRotarPlaneta.Name = "btnRotarPlaneta";
            this.btnRotarPlaneta.Size = new System.Drawing.Size(200, 50);
            this.btnRotarPlaneta.TabIndex = 0;
            this.btnRotarPlaneta.Text = "Rotar Planeta";
            this.btnRotarPlaneta.UseVisualStyleBackColor = true;
            // 
            // btnOrbitarSatelites
            // 
            this.btnOrbitarSatelites.Location = new System.Drawing.Point(326, 12);
            this.btnOrbitarSatelites.Name = "btnOrbitarSatelites";
            this.btnOrbitarSatelites.Size = new System.Drawing.Size(200, 50);
            this.btnOrbitarSatelites.TabIndex = 1;
            this.btnOrbitarSatelites.Text = "Orbitar Satélites";
            this.btnOrbitarSatelites.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrearSatelite);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.lblRotacion);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblOrbita);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satélites";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblOrbita
            // 
            this.lblOrbita.AutoSize = true;
            this.lblOrbita.Location = new System.Drawing.Point(22, 75);
            this.lblOrbita.Name = "lblOrbita";
            this.lblOrbita.Size = new System.Drawing.Size(81, 13);
            this.lblOrbita.TabIndex = 2;
            this.lblOrbita.Text = "Duración Orbita";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lblRotacion
            // 
            this.lblRotacion.AutoSize = true;
            this.lblRotacion.Location = new System.Drawing.Point(22, 112);
            this.lblRotacion.Name = "lblRotacion";
            this.lblRotacion.Size = new System.Drawing.Size(96, 13);
            this.lblRotacion.TabIndex = 4;
            this.lblRotacion.Text = "Duración Rotación";
            // 
            // btnCrearSatelite
            // 
            this.btnCrearSatelite.Location = new System.Drawing.Point(289, 25);
            this.btnCrearSatelite.Name = "btnCrearSatelite";
            this.btnCrearSatelite.Size = new System.Drawing.Size(206, 112);
            this.btnCrearSatelite.TabIndex = 3;
            this.btnCrearSatelite.Text = "Crear Satélite";
            this.btnCrearSatelite.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(538, 277);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrbitarSatelites);
            this.Controls.Add(this.btnRotarPlaneta);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRotarPlaneta;
        private System.Windows.Forms.Button btnOrbitarSatelites;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrearSatelite;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblRotacion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblOrbita;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombre;
    }
}

