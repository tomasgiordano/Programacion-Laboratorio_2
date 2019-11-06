namespace AdminPersonas
{
    partial class frmVisorDataTable
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
            this.btnAgregarABD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarABD
            // 
            this.btnAgregarABD.Location = new System.Drawing.Point(93, 236);
            this.btnAgregarABD.Name = "btnAgregarABD";
            this.btnAgregarABD.Size = new System.Drawing.Size(98, 23);
            this.btnAgregarABD.TabIndex = 4;
            this.btnAgregarABD.Text = "Agregar a BD";
            this.btnAgregarABD.UseVisualStyleBackColor = true;
            this.btnAgregarABD.Click += new System.EventHandler(this.btnAgregarABD_Click);
            // 
            // frmVisorDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 274);
            this.Controls.Add(this.btnAgregarABD);
            this.Name = "frmVisorDataTable";
            this.Text = "frmVisorDataTable";
            this.Controls.SetChildIndex(this.btnAgregarABD, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarABD;
    }
}