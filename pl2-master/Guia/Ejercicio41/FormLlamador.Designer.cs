namespace Ejercicio41
{
    partial class FormLlamador
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
            this.textBoxNumeroDestino = new System.Windows.Forms.TextBox();
            this.groupBoxPanel = new System.Windows.Forms.GroupBox();
            this.buttonNumeral = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonAsterisco = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLlamar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxNumeroOrigen = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.comboBoxFranja = new System.Windows.Forms.ComboBox();
            this.groupBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumeroDestino
            // 
            this.textBoxNumeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroDestino.Location = new System.Drawing.Point(22, 12);
            this.textBoxNumeroDestino.Name = "textBoxNumeroDestino";
            this.textBoxNumeroDestino.ReadOnly = true;
            this.textBoxNumeroDestino.Size = new System.Drawing.Size(278, 22);
            this.textBoxNumeroDestino.TabIndex = 0;
            this.textBoxNumeroDestino.Text = "Número destino";
            this.textBoxNumeroDestino.TextChanged += new System.EventHandler(this.textBoxNumeroDestino_TextChanged);
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.Controls.Add(this.buttonNumeral);
            this.groupBoxPanel.Controls.Add(this.button0);
            this.groupBoxPanel.Controls.Add(this.button9);
            this.groupBoxPanel.Controls.Add(this.button8);
            this.groupBoxPanel.Controls.Add(this.button6);
            this.groupBoxPanel.Controls.Add(this.button5);
            this.groupBoxPanel.Controls.Add(this.buttonAsterisco);
            this.groupBoxPanel.Controls.Add(this.button7);
            this.groupBoxPanel.Controls.Add(this.button4);
            this.groupBoxPanel.Controls.Add(this.button3);
            this.groupBoxPanel.Controls.Add(this.button2);
            this.groupBoxPanel.Controls.Add(this.button1);
            this.groupBoxPanel.Location = new System.Drawing.Point(22, 38);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Size = new System.Drawing.Size(146, 208);
            this.groupBoxPanel.TabIndex = 1;
            this.groupBoxPanel.TabStop = false;
            this.groupBoxPanel.Text = "Panel";
            // 
            // buttonNumeral
            // 
            this.buttonNumeral.Location = new System.Drawing.Point(98, 157);
            this.buttonNumeral.Name = "buttonNumeral";
            this.buttonNumeral.Size = new System.Drawing.Size(40, 40);
            this.buttonNumeral.TabIndex = 11;
            this.buttonNumeral.Text = "#";
            this.buttonNumeral.UseVisualStyleBackColor = true;
            this.buttonNumeral.Click += new System.EventHandler(this.buttonNumeral_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(52, 157);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(40, 40);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(98, 111);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(52, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(98, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(52, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonAsterisco
            // 
            this.buttonAsterisco.Location = new System.Drawing.Point(6, 157);
            this.buttonAsterisco.Name = "buttonAsterisco";
            this.buttonAsterisco.Size = new System.Drawing.Size(40, 40);
            this.buttonAsterisco.TabIndex = 5;
            this.buttonAsterisco.Text = "*";
            this.buttonAsterisco.UseVisualStyleBackColor = true;
            this.buttonAsterisco.Click += new System.EventHandler(this.buttonAsterisco_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 4;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLlamar
            // 
            this.buttonLlamar.Enabled = false;
            this.buttonLlamar.Location = new System.Drawing.Point(182, 38);
            this.buttonLlamar.Name = "buttonLlamar";
            this.buttonLlamar.Size = new System.Drawing.Size(118, 23);
            this.buttonLlamar.TabIndex = 0;
            this.buttonLlamar.Text = "Llamar";
            this.buttonLlamar.UseVisualStyleBackColor = true;
            this.buttonLlamar.Click += new System.EventHandler(this.buttonLlamar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(182, 67);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(118, 23);
            this.buttonLimpiar.TabIndex = 2;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // textBoxNumeroOrigen
            // 
            this.textBoxNumeroOrigen.Location = new System.Drawing.Point(182, 96);
            this.textBoxNumeroOrigen.Name = "textBoxNumeroOrigen";
            this.textBoxNumeroOrigen.Size = new System.Drawing.Size(118, 20);
            this.textBoxNumeroOrigen.TabIndex = 3;
            this.textBoxNumeroOrigen.Text = "Número origen";
            this.textBoxNumeroOrigen.Click += new System.EventHandler(this.textBoxNumeroOrigen_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSalir.Location = new System.Drawing.Point(182, 122);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(118, 23);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // comboBoxFranja
            // 
            this.comboBoxFranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFranja.Enabled = false;
            this.comboBoxFranja.FormattingEnabled = true;
            this.comboBoxFranja.Location = new System.Drawing.Point(22, 260);
            this.comboBoxFranja.Name = "comboBoxFranja";
            this.comboBoxFranja.Size = new System.Drawing.Size(278, 21);
            this.comboBoxFranja.TabIndex = 0;
            // 
            // FormLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonSalir;
            this.ClientSize = new System.Drawing.Size(325, 298);
            this.Controls.Add(this.comboBoxFranja);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.textBoxNumeroOrigen);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonLlamar);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.textBoxNumeroDestino);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLlamador";
            this.Text = "FormLlamador";
            this.Load += new System.EventHandler(this.FormLlamador_Load);
            this.groupBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeroDestino;
        private System.Windows.Forms.GroupBox groupBoxPanel;
        private System.Windows.Forms.Button buttonLlamar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxNumeroOrigen;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ComboBox comboBoxFranja;
        private System.Windows.Forms.Button buttonAsterisco;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNumeral;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}