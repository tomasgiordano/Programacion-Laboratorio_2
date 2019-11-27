namespace ComiqueriaApp
{
    partial class ModificarProductoForm
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
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxPrecioActual = new System.Windows.Forms.TextBox();
            this.labelPrecioActual = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelNuevoPrecio = new System.Windows.Forms.Label();
            this.textBoxNuevoPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(13, 19);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(74, 13);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Descripción";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(13, 128);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(51, 13);
            this.labelError.TabIndex = 1;
            this.labelError.Text = "labelError";
            // 
            // textBoxPrecioActual
            // 
            this.textBoxPrecioActual.Location = new System.Drawing.Point(16, 66);
            this.textBoxPrecioActual.Name = "textBoxPrecioActual";
            this.textBoxPrecioActual.ReadOnly = true;
            this.textBoxPrecioActual.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioActual.TabIndex = 2;
            // 
            // labelPrecioActual
            // 
            this.labelPrecioActual.AutoSize = true;
            this.labelPrecioActual.Location = new System.Drawing.Point(13, 50);
            this.labelPrecioActual.Name = "labelPrecioActual";
            this.labelPrecioActual.Size = new System.Drawing.Size(72, 13);
            this.labelPrecioActual.TabIndex = 3;
            this.labelPrecioActual.Text = "Precio actual:";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(12, 163);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(100, 163);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelNuevoPrecio
            // 
            this.labelNuevoPrecio.AutoSize = true;
            this.labelNuevoPrecio.Location = new System.Drawing.Point(13, 89);
            this.labelNuevoPrecio.Name = "labelNuevoPrecio";
            this.labelNuevoPrecio.Size = new System.Drawing.Size(74, 13);
            this.labelNuevoPrecio.TabIndex = 6;
            this.labelNuevoPrecio.Text = "Nuevo precio:";
            // 
            // textBoxNuevoPrecio
            // 
            this.textBoxNuevoPrecio.Location = new System.Drawing.Point(16, 105);
            this.textBoxNuevoPrecio.Name = "textBoxNuevoPrecio";
            this.textBoxNuevoPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxNuevoPrecio.TabIndex = 7;
            this.textBoxNuevoPrecio.TextChanged += new System.EventHandler(this.textBoxNuevoPrecio_TextChanged);
            // 
            // ModificarProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(392, 198);
            this.Controls.Add(this.textBoxNuevoPrecio);
            this.Controls.Add(this.labelNuevoPrecio);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.labelPrecioActual);
            this.Controls.Add(this.textBoxPrecioActual);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelDescripcion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarProductoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar producto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ModificarProductoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxPrecioActual;
        private System.Windows.Forms.Label labelPrecioActual;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelNuevoPrecio;
        private System.Windows.Forms.TextBox textBoxNuevoPrecio;
    }
}