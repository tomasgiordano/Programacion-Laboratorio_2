namespace Clase06
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
            this.lblTextPalabras = new System.Windows.Forms.Label();
            this.lblTextFinalizaA = new System.Windows.Forms.Label();
            this.lblTextPalabrasTxtResultado = new System.Windows.Forms.Label();
            this.lblCantFinalizaA = new System.Windows.Forms.Label();
            this.lblCantPalabras = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button20palabras = new System.Windows.Forms.Button();
            this.button100letras = new System.Windows.Forms.Button();
            this.button3primerasA = new System.Windows.Forms.Button();
            this.button3primerasO = new System.Windows.Forms.Button();
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTextPalabras
            // 
            this.lblTextPalabras.AutoSize = true;
            this.lblTextPalabras.Location = new System.Drawing.Point(12, 9);
            this.lblTextPalabras.Name = "lblTextPalabras";
            this.lblTextPalabras.Size = new System.Drawing.Size(48, 13);
            this.lblTextPalabras.TabIndex = 0;
            this.lblTextPalabras.Text = "Palabras";
            // 
            // lblTextFinalizaA
            // 
            this.lblTextFinalizaA.AutoSize = true;
            this.lblTextFinalizaA.Location = new System.Drawing.Point(12, 32);
            this.lblTextFinalizaA.Name = "lblTextFinalizaA";
            this.lblTextFinalizaA.Size = new System.Drawing.Size(82, 13);
            this.lblTextFinalizaA.TabIndex = 1;
            this.lblTextFinalizaA.Text = "Subcadena \"A\"";
            // 
            // lblTextPalabrasTxtResultado
            // 
            this.lblTextPalabrasTxtResultado.AutoSize = true;
            this.lblTextPalabrasTxtResultado.Location = new System.Drawing.Point(12, 54);
            this.lblTextPalabrasTxtResultado.Name = "lblTextPalabrasTxtResultado";
            this.lblTextPalabrasTxtResultado.Size = new System.Drawing.Size(48, 13);
            this.lblTextPalabrasTxtResultado.TabIndex = 2;
            this.lblTextPalabrasTxtResultado.Text = "Palabras";
            // 
            // lblCantFinalizaA
            // 
            this.lblCantFinalizaA.AutoSize = true;
            this.lblCantFinalizaA.Location = new System.Drawing.Point(109, 32);
            this.lblCantFinalizaA.Name = "lblCantFinalizaA";
            this.lblCantFinalizaA.Size = new System.Drawing.Size(13, 13);
            this.lblCantFinalizaA.TabIndex = 3;
            this.lblCantFinalizaA.Text = "0";
            // 
            // lblCantPalabras
            // 
            this.lblCantPalabras.AutoSize = true;
            this.lblCantPalabras.Location = new System.Drawing.Point(109, 9);
            this.lblCantPalabras.Name = "lblCantPalabras";
            this.lblCantPalabras.Size = new System.Drawing.Size(13, 13);
            this.lblCantPalabras.TabIndex = 4;
            this.lblCantPalabras.Text = "0";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 70);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(462, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // button20palabras
            // 
            this.button20palabras.Location = new System.Drawing.Point(399, 96);
            this.button20palabras.Name = "button20palabras";
            this.button20palabras.Size = new System.Drawing.Size(75, 23);
            this.button20palabras.TabIndex = 6;
            this.button20palabras.Text = "20 palabras";
            this.button20palabras.UseVisualStyleBackColor = true;
            this.button20palabras.Click += new System.EventHandler(this.button20palabras_Click);
            // 
            // button100letras
            // 
            this.button100letras.Location = new System.Drawing.Point(318, 96);
            this.button100letras.Name = "button100letras";
            this.button100letras.Size = new System.Drawing.Size(75, 23);
            this.button100letras.TabIndex = 7;
            this.button100letras.Text = "100 letras";
            this.button100letras.UseVisualStyleBackColor = true;
            this.button100letras.Click += new System.EventHandler(this.button100letras_Click);
            // 
            // button3primerasA
            // 
            this.button3primerasA.Location = new System.Drawing.Point(205, 96);
            this.button3primerasA.Name = "button3primerasA";
            this.button3primerasA.Size = new System.Drawing.Size(107, 23);
            this.button3primerasA.TabIndex = 8;
            this.button3primerasA.Text = "3 primeras \"A\"";
            this.button3primerasA.UseVisualStyleBackColor = true;
            this.button3primerasA.Click += new System.EventHandler(this.button3primerasA_Click);
            // 
            // button3primerasO
            // 
            this.button3primerasO.Location = new System.Drawing.Point(92, 96);
            this.button3primerasO.Name = "button3primerasO";
            this.button3primerasO.Size = new System.Drawing.Size(107, 23);
            this.button3primerasO.TabIndex = 9;
            this.button3primerasO.Text = "3 primeras \"O\"";
            this.button3primerasO.UseVisualStyleBackColor = true;
            this.button3primerasO.Click += new System.EventHandler(this.button3primerasO_Click);
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Location = new System.Drawing.Point(12, 125);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(462, 313);
            this.rtxtTexto.TabIndex = 10;
            this.rtxtTexto.Text = "";
            this.rtxtTexto.TextChanged += new System.EventHandler(this.rtxtTexto_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.rtxtTexto);
            this.Controls.Add(this.button3primerasO);
            this.Controls.Add(this.button3primerasA);
            this.Controls.Add(this.button100letras);
            this.Controls.Add(this.button20palabras);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblCantPalabras);
            this.Controls.Add(this.lblCantFinalizaA);
            this.Controls.Add(this.lblTextPalabrasTxtResultado);
            this.Controls.Add(this.lblTextFinalizaA);
            this.Controls.Add(this.lblTextPalabras);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Clase 06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextPalabras;
        private System.Windows.Forms.Label lblTextFinalizaA;
        private System.Windows.Forms.Label lblTextPalabrasTxtResultado;
        private System.Windows.Forms.Label lblCantFinalizaA;
        private System.Windows.Forms.Label lblCantPalabras;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button20palabras;
        private System.Windows.Forms.Button button100letras;
        private System.Windows.Forms.Button button3primerasA;
        private System.Windows.Forms.Button button3primerasO;
        private System.Windows.Forms.RichTextBox rtxtTexto;
    }
}

