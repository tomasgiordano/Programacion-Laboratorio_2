namespace ComiqueriaApp
{
    partial class NuevoForm
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
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.groupBoxAgregarProducto = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoProducto = new System.Windows.Forms.ComboBox();
            this.labelTipoProducto = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.groupBoxFigura = new System.Windows.Forms.GroupBox();
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.groupBoxComic = new System.Windows.Forms.GroupBox();
            this.labelAutor = new System.Windows.Forms.Label();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDeComic = new System.Windows.Forms.ComboBox();
            this.labelTipoDeComic = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            this.groupBoxFigura.SuspendLayout();
            this.groupBoxComic.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(6, 63);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 1;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(9, 79);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(239, 68);
            this.richTextBoxDescripcion.TabIndex = 2;
            this.richTextBoxDescripcion.Text = "";
            // 
            // groupBoxAgregarProducto
            // 
            this.groupBoxAgregarProducto.Controls.Add(this.labelStock);
            this.groupBoxAgregarProducto.Controls.Add(this.labelPrecio);
            this.groupBoxAgregarProducto.Controls.Add(this.numericUpDownStock);
            this.groupBoxAgregarProducto.Controls.Add(this.textBoxPrecio);
            this.groupBoxAgregarProducto.Controls.Add(this.labelTipoProducto);
            this.groupBoxAgregarProducto.Controls.Add(this.comboBoxTipoProducto);
            this.groupBoxAgregarProducto.Controls.Add(this.richTextBoxDescripcion);
            this.groupBoxAgregarProducto.Controls.Add(this.labelDescripcion);
            this.groupBoxAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAgregarProducto.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAgregarProducto.Name = "groupBoxAgregarProducto";
            this.groupBoxAgregarProducto.Size = new System.Drawing.Size(254, 204);
            this.groupBoxAgregarProducto.TabIndex = 3;
            this.groupBoxAgregarProducto.TabStop = false;
            this.groupBoxAgregarProducto.Text = "Agregar producto";
            // 
            // comboBoxTipoProducto
            // 
            this.comboBoxTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoProducto.FormattingEnabled = true;
            this.comboBoxTipoProducto.Location = new System.Drawing.Point(9, 35);
            this.comboBoxTipoProducto.Name = "comboBoxTipoProducto";
            this.comboBoxTipoProducto.Size = new System.Drawing.Size(239, 21);
            this.comboBoxTipoProducto.TabIndex = 4;
            this.comboBoxTipoProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoProducto_SelectedIndexChanged);
            // 
            // labelTipoProducto
            // 
            this.labelTipoProducto.AutoSize = true;
            this.labelTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoProducto.Location = new System.Drawing.Point(6, 19);
            this.labelTipoProducto.Name = "labelTipoProducto";
            this.labelTipoProducto.Size = new System.Drawing.Size(91, 13);
            this.labelTipoProducto.TabIndex = 5;
            this.labelTipoProducto.Text = "Tipo de producto:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(8, 173);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 6;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStock.Location = new System.Drawing.Point(127, 173);
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStock.TabIndex = 7;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(5, 155);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 13);
            this.labelPrecio.TabIndex = 6;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(124, 155);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(38, 13);
            this.labelStock.TabIndex = 8;
            this.labelStock.Text = "Stock:";
            // 
            // groupBoxFigura
            // 
            this.groupBoxFigura.Controls.Add(this.labelAltura);
            this.groupBoxFigura.Controls.Add(this.textBoxAltura);
            this.groupBoxFigura.Location = new System.Drawing.Point(12, 222);
            this.groupBoxFigura.Name = "groupBoxFigura";
            this.groupBoxFigura.Size = new System.Drawing.Size(254, 68);
            this.groupBoxFigura.TabIndex = 4;
            this.groupBoxFigura.TabStop = false;
            this.groupBoxFigura.Text = "Figura";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltura.Location = new System.Drawing.Point(6, 19);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(37, 13);
            this.labelAltura.TabIndex = 9;
            this.labelAltura.Text = "Altura:";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(9, 37);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltura.TabIndex = 10;
            // 
            // groupBoxComic
            // 
            this.groupBoxComic.Controls.Add(this.labelTipoDeComic);
            this.groupBoxComic.Controls.Add(this.comboBoxTipoDeComic);
            this.groupBoxComic.Controls.Add(this.labelAutor);
            this.groupBoxComic.Controls.Add(this.textBoxAutor);
            this.groupBoxComic.Location = new System.Drawing.Point(12, 296);
            this.groupBoxComic.Name = "groupBoxComic";
            this.groupBoxComic.Size = new System.Drawing.Size(254, 68);
            this.groupBoxComic.TabIndex = 5;
            this.groupBoxComic.TabStop = false;
            this.groupBoxComic.Text = "Comic";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(6, 19);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(35, 13);
            this.labelAutor.TabIndex = 11;
            this.labelAutor.Text = "Autor:";
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(9, 37);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutor.TabIndex = 12;
            // 
            // comboBoxTipoDeComic
            // 
            this.comboBoxTipoDeComic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDeComic.FormattingEnabled = true;
            this.comboBoxTipoDeComic.Location = new System.Drawing.Point(126, 36);
            this.comboBoxTipoDeComic.Name = "comboBoxTipoDeComic";
            this.comboBoxTipoDeComic.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoDeComic.TabIndex = 6;
            // 
            // labelTipoDeComic
            // 
            this.labelTipoDeComic.AutoSize = true;
            this.labelTipoDeComic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDeComic.Location = new System.Drawing.Point(123, 19);
            this.labelTipoDeComic.Name = "labelTipoDeComic";
            this.labelTipoDeComic.Size = new System.Drawing.Size(77, 13);
            this.labelTipoDeComic.TabIndex = 13;
            this.labelTipoDeComic.Text = "Tipo de comic:";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(12, 377);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(99, 377);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 7;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(191, 377);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // NuevoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(276, 413);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.groupBoxComic);
            this.Controls.Add(this.groupBoxFigura);
            this.Controls.Add(this.groupBoxAgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoForm";
            this.Text = "Nuevo producto";
            this.Load += new System.EventHandler(this.NuevoForm_Load);
            this.groupBoxAgregarProducto.ResumeLayout(false);
            this.groupBoxAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            this.groupBoxFigura.ResumeLayout(false);
            this.groupBoxFigura.PerformLayout();
            this.groupBoxComic.ResumeLayout(false);
            this.groupBoxComic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.GroupBox groupBoxAgregarProducto;
        private System.Windows.Forms.Label labelTipoProducto;
        private System.Windows.Forms.ComboBox comboBoxTipoProducto;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.GroupBox groupBoxFigura;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.GroupBox groupBoxComic;
        private System.Windows.Forms.Label labelTipoDeComic;
        private System.Windows.Forms.ComboBox comboBoxTipoDeComic;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}