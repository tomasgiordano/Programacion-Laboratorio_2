namespace Clase_10
{
    partial class FrmCatedra
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
            this.gbxAlumnos = new System.Windows.Forms.GroupBox();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.lbxAlumnos = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbxAlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.lbxAlumnosCalificados = new System.Windows.Forms.ListBox();
            this.gbxAlumnos.SuspendLayout();
            this.gbxAlumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAlumnos
            // 
            this.gbxAlumnos.Controls.Add(this.cmbOrdenar);
            this.gbxAlumnos.Controls.Add(this.lbxAlumnos);
            this.gbxAlumnos.Controls.Add(this.btnModificar);
            this.gbxAlumnos.Controls.Add(this.btnCalificar);
            this.gbxAlumnos.Controls.Add(this.btnAgregar);
            this.gbxAlumnos.Location = new System.Drawing.Point(12, 12);
            this.gbxAlumnos.Name = "gbxAlumnos";
            this.gbxAlumnos.Size = new System.Drawing.Size(513, 221);
            this.gbxAlumnos.TabIndex = 0;
            this.gbxAlumnos.TabStop = false;
            this.gbxAlumnos.Text = "Alumnos";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Location = new System.Drawing.Point(6, 189);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(501, 21);
            this.cmbOrdenar.TabIndex = 4;
            this.cmbOrdenar.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenar_SelectedIndexChanged);
            // 
            // lbxAlumnos
            // 
            this.lbxAlumnos.FormattingEnabled = true;
            this.lbxAlumnos.Location = new System.Drawing.Point(6, 50);
            this.lbxAlumnos.Name = "lbxAlumnos";
            this.lbxAlumnos.Size = new System.Drawing.Size(501, 134);
            this.lbxAlumnos.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(409, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 25);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(212, 19);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(98, 25);
            this.btnCalificar.TabIndex = 1;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 25);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbxAlumnosCalificados
            // 
            this.gbxAlumnosCalificados.Controls.Add(this.lbxAlumnosCalificados);
            this.gbxAlumnosCalificados.Location = new System.Drawing.Point(12, 239);
            this.gbxAlumnosCalificados.Name = "gbxAlumnosCalificados";
            this.gbxAlumnosCalificados.Size = new System.Drawing.Size(513, 199);
            this.gbxAlumnosCalificados.TabIndex = 1;
            this.gbxAlumnosCalificados.TabStop = false;
            this.gbxAlumnosCalificados.Text = "Alumnos Calificados";
            // 
            // lbxAlumnosCalificados
            // 
            this.lbxAlumnosCalificados.FormattingEnabled = true;
            this.lbxAlumnosCalificados.Location = new System.Drawing.Point(6, 25);
            this.lbxAlumnosCalificados.Name = "lbxAlumnosCalificados";
            this.lbxAlumnosCalificados.Size = new System.Drawing.Size(501, 160);
            this.lbxAlumnosCalificados.TabIndex = 0;
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 443);
            this.Controls.Add(this.gbxAlumnosCalificados);
            this.Controls.Add(this.gbxAlumnos);
            this.Name = "FrmCatedra";
            this.Text = "FrmCatedra";
            this.gbxAlumnos.ResumeLayout(false);
            this.gbxAlumnosCalificados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAlumnos;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.ListBox lbxAlumnos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbxAlumnosCalificados;
        private System.Windows.Forms.ListBox lbxAlumnosCalificados;
    }
}