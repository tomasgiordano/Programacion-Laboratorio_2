namespace CentralitaWindowsForms
{
    partial class FormProvincial
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
            this.cmbFranjaHoraria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFranjaHoraria
            // 
            this.cmbFranjaHoraria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFranjaHoraria.FormattingEnabled = true;
            this.cmbFranjaHoraria.Location = new System.Drawing.Point(12, 187);
            this.cmbFranjaHoraria.Name = "cmbFranjaHoraria";
            this.cmbFranjaHoraria.Size = new System.Drawing.Size(188, 21);
            this.cmbFranjaHoraria.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Franja horaria:";
            // 
            // FormProvincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFranjaHoraria);
            this.Name = "FormProvincial";
            this.Text = "FormProvincial";
            this.Controls.SetChildIndex(this.cmbFranjaHoraria, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFranjaHoraria;
        private System.Windows.Forms.Label label4;
    }
}