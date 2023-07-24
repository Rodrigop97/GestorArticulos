namespace WindowsFormsApp
{
    partial class altaArticulo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.tbxImagen = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblObligatorios = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(3, 147);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 98);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(3, 196);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(3, 294);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(42, 13);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Imagen";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(3, 245);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(258, 49);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(261, 237);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 7;
            this.imagen.TabStop = false;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxCodigo.Location = new System.Drawing.Point(123, 3);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbxCodigo.TabIndex = 0;
            this.tbxCodigo.TextChanged += new System.EventHandler(this.tbxCodigo_TextChanged);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(123, 52);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(100, 20);
            this.tbxNombre.TabIndex = 1;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(123, 101);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbxDescripcion.TabIndex = 2;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(123, 248);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbxPrecio.TabIndex = 5;
            this.tbxPrecio.TextChanged += new System.EventHandler(this.tbxPrecio_TextChanged);
            // 
            // tbxImagen
            // 
            this.tbxImagen.Location = new System.Drawing.Point(123, 297);
            this.tbxImagen.Name = "tbxImagen";
            this.tbxImagen.Size = new System.Drawing.Size(100, 20);
            this.tbxImagen.TabIndex = 6;
            this.tbxImagen.Leave += new System.EventHandler(this.tbxImagen_Leave);
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(123, 150);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(114, 21);
            this.cbxMarca.TabIndex = 3;
            this.cbxMarca.Leave += new System.EventHandler(this.cbxMarca_Leave);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(123, 199);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(114, 21);
            this.cbxCategoria.TabIndex = 4;
            this.cbxCategoria.Leave += new System.EventHandler(this.cbxCategoria_Leave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(33, 395);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(135, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblObligatorios
            // 
            this.lblObligatorios.AutoSize = true;
            this.lblObligatorios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorios.Location = new System.Drawing.Point(42, 9);
            this.lblObligatorios.Name = "lblObligatorios";
            this.lblObligatorios.Size = new System.Drawing.Size(178, 15);
            this.lblObligatorios.TabIndex = 19;
            this.lblObligatorios.Text = "Llenar los campos obligatorios";
            this.lblObligatorios.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblCodigo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxCodigo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxImagen, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbxCategoria, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxPrecio, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblImagen, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcion, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxMarca, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPrecio, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxDescripcion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMarca, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCategoria, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 346);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // altaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 430);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblObligatorios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.imagen);
            this.Name = "altaArticulo";
            this.Text = "altaArticulo";
            this.Load += new System.EventHandler(this.altaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.TextBox tbxImagen;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblObligatorios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}