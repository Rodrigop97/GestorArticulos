namespace WindowsFormsApp
{
    partial class Main
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblFiltro1 = new System.Windows.Forms.Label();
            this.tbxBusqueda = new System.Windows.Forms.TextBox();
            this.lblFiltro2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiltro4 = new System.Windows.Forms.Label();
            this.lblFiltro3 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxPrecio = new System.Windows.Forms.ComboBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(2, 1);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.Size = new System.Drawing.Size(617, 256);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(459, 263);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(625, 1);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(280, 256);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 2;
            this.imagen.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(540, 263);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblFiltro1
            // 
            this.lblFiltro1.AutoSize = true;
            this.lblFiltro1.Location = new System.Drawing.Point(13, 265);
            this.lblFiltro1.Name = "lblFiltro1";
            this.lblFiltro1.Size = new System.Drawing.Size(111, 13);
            this.lblFiltro1.TabIndex = 5;
            this.lblFiltro1.Text = "Busqueda por nombre";
            // 
            // tbxBusqueda
            // 
            this.tbxBusqueda.Location = new System.Drawing.Point(130, 262);
            this.tbxBusqueda.Name = "tbxBusqueda";
            this.tbxBusqueda.Size = new System.Drawing.Size(126, 20);
            this.tbxBusqueda.TabIndex = 6;
            this.tbxBusqueda.TextChanged += new System.EventHandler(this.tbxBusqueda_TextChanged);
            // 
            // lblFiltro2
            // 
            this.lblFiltro2.AutoSize = true;
            this.lblFiltro2.Location = new System.Drawing.Point(12, 289);
            this.lblFiltro2.Name = "lblFiltro2";
            this.lblFiltro2.Size = new System.Drawing.Size(37, 13);
            this.lblFiltro2.TabIndex = 7;
            this.lblFiltro2.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filtro de busqueda";
            // 
            // lblFiltro4
            // 
            this.lblFiltro4.AutoSize = true;
            this.lblFiltro4.Location = new System.Drawing.Point(12, 314);
            this.lblFiltro4.Name = "lblFiltro4";
            this.lblFiltro4.Size = new System.Drawing.Size(37, 13);
            this.lblFiltro4.TabIndex = 9;
            this.lblFiltro4.Text = "Precio";
            // 
            // lblFiltro3
            // 
            this.lblFiltro3.AutoSize = true;
            this.lblFiltro3.Location = new System.Drawing.Point(253, 292);
            this.lblFiltro3.Name = "lblFiltro3";
            this.lblFiltro3.Size = new System.Drawing.Size(52, 13);
            this.lblFiltro3.TabIndex = 10;
            this.lblFiltro3.Text = "Categoria";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(67, 286);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 11;
            this.cbxMarca.SelectionChangeCommitted += new System.EventHandler(this.cbxMarca_SelectionChangeCommitted);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(311, 289);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 12;
            this.cbxCategoria.SelectionChangeCommitted += new System.EventHandler(this.cbxCategoria_SelectionChangeCommitted);
            // 
            // cbxPrecio
            // 
            this.cbxPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrecio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxPrecio.FormattingEnabled = true;
            this.cbxPrecio.Location = new System.Drawing.Point(67, 311);
            this.cbxPrecio.Name = "cbxPrecio";
            this.cbxPrecio.Size = new System.Drawing.Size(121, 21);
            this.cbxPrecio.TabIndex = 13;
            this.cbxPrecio.SelectionChangeCommitted += new System.EventHandler(this.cbxPrecio_SelectionChangeCommitted);
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Enabled = false;
            this.tbxPrecio.Location = new System.Drawing.Point(194, 311);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(126, 20);
            this.tbxPrecio.TabIndex = 14;
            this.tbxPrecio.TextChanged += new System.EventHandler(this.tbxPrecio_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 344);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.cbxPrecio);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lblFiltro3);
            this.Controls.Add(this.lblFiltro4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFiltro2);
            this.Controls.Add(this.tbxBusqueda);
            this.Controls.Add(this.lblFiltro1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "Main";
            this.Text = "Lista de articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblFiltro1;
        private System.Windows.Forms.TextBox tbxBusqueda;
        private System.Windows.Forms.Label lblFiltro2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFiltro4;
        private System.Windows.Forms.Label lblFiltro3;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxPrecio;
        private System.Windows.Forms.TextBox tbxPrecio;
    }
}

