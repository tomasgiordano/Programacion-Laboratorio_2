namespace Clase08
{
    partial class FormEmpleado
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelPuesto = new System.Windows.Forms.Label();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.maskedTextBoxLegajo = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxPuesto = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxSalario = new System.Windows.Forms.MaskedTextBox();
            this.buttonEmpresa = new System.Windows.Forms.Button();
            this.buttonAgregarItem = new System.Windows.Forms.Button();
            this.buttonLimpiarForm = new System.Windows.Forms.Button();
            this.richTextBoxConsola = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 12);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(12, 39);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido";
            // 
            // labelPuesto
            // 
            this.labelPuesto.AutoSize = true;
            this.labelPuesto.Location = new System.Drawing.Point(12, 91);
            this.labelPuesto.Name = "labelPuesto";
            this.labelPuesto.Size = new System.Drawing.Size(40, 13);
            this.labelPuesto.TabIndex = 3;
            this.labelPuesto.Text = "Puesto";
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Location = new System.Drawing.Point(12, 65);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(39, 13);
            this.labelLegajo.TabIndex = 2;
            this.labelLegajo.Text = "Legajo";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(12, 118);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(39, 13);
            this.labelSalario.TabIndex = 4;
            this.labelSalario.Text = "Salario";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(97, 9);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(172, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(97, 36);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(172, 20);
            this.textBoxApellido.TabIndex = 6;
            // 
            // maskedTextBoxLegajo
            // 
            this.maskedTextBoxLegajo.Location = new System.Drawing.Point(97, 62);
            this.maskedTextBoxLegajo.Name = "maskedTextBoxLegajo";
            this.maskedTextBoxLegajo.Size = new System.Drawing.Size(172, 20);
            this.maskedTextBoxLegajo.TabIndex = 7;
            // 
            // comboBoxPuesto
            // 
            this.comboBoxPuesto.FormattingEnabled = true;
            this.comboBoxPuesto.Location = new System.Drawing.Point(97, 88);
            this.comboBoxPuesto.Name = "comboBoxPuesto";
            this.comboBoxPuesto.Size = new System.Drawing.Size(172, 21);
            this.comboBoxPuesto.TabIndex = 8;
            // 
            // maskedTextBoxSalario
            // 
            this.maskedTextBoxSalario.Location = new System.Drawing.Point(97, 115);
            this.maskedTextBoxSalario.Name = "maskedTextBoxSalario";
            this.maskedTextBoxSalario.Size = new System.Drawing.Size(172, 20);
            this.maskedTextBoxSalario.TabIndex = 9;
            // 
            // buttonEmpresa
            // 
            this.buttonEmpresa.Location = new System.Drawing.Point(12, 158);
            this.buttonEmpresa.Name = "buttonEmpresa";
            this.buttonEmpresa.Size = new System.Drawing.Size(75, 23);
            this.buttonEmpresa.TabIndex = 10;
            this.buttonEmpresa.Text = "Empresa";
            this.buttonEmpresa.UseVisualStyleBackColor = true;
            this.buttonEmpresa.Click += new System.EventHandler(this.buttonEmpresa_Click);
            // 
            // buttonAgregarItem
            // 
            this.buttonAgregarItem.Location = new System.Drawing.Point(194, 158);
            this.buttonAgregarItem.Name = "buttonAgregarItem";
            this.buttonAgregarItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarItem.TabIndex = 11;
            this.buttonAgregarItem.Text = "Agregar";
            this.buttonAgregarItem.UseVisualStyleBackColor = true;
            this.buttonAgregarItem.Click += new System.EventHandler(this.buttonAgregarItem_Click);
            // 
            // buttonLimpiarForm
            // 
            this.buttonLimpiarForm.Location = new System.Drawing.Point(113, 158);
            this.buttonLimpiarForm.Name = "buttonLimpiarForm";
            this.buttonLimpiarForm.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarForm.TabIndex = 12;
            this.buttonLimpiarForm.Text = "Limpiar";
            this.buttonLimpiarForm.UseVisualStyleBackColor = true;
            this.buttonLimpiarForm.Click += new System.EventHandler(this.buttonLimpiarForm_Click);
            // 
            // richTextBoxConsola
            // 
            this.richTextBoxConsola.Location = new System.Drawing.Point(12, 202);
            this.richTextBoxConsola.Name = "richTextBoxConsola";
            this.richTextBoxConsola.Size = new System.Drawing.Size(257, 151);
            this.richTextBoxConsola.TabIndex = 13;
            this.richTextBoxConsola.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 364);
            this.Controls.Add(this.richTextBoxConsola);
            this.Controls.Add(this.buttonLimpiarForm);
            this.Controls.Add(this.buttonAgregarItem);
            this.Controls.Add(this.buttonEmpresa);
            this.Controls.Add(this.maskedTextBoxSalario);
            this.Controls.Add(this.comboBoxPuesto);
            this.Controls.Add(this.maskedTextBoxLegajo);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelPuesto);
            this.Controls.Add(this.labelLegajo);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelPuesto;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLegajo;
        private System.Windows.Forms.ComboBox comboBoxPuesto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSalario;
        private System.Windows.Forms.Button buttonEmpresa;
        private System.Windows.Forms.Button buttonAgregarItem;
        private System.Windows.Forms.Button buttonLimpiarForm;
        private System.Windows.Forms.RichTextBox richTextBoxConsola;
    }
}

