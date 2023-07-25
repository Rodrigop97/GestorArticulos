using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class altaArticulo : Form
    {
        private Articulo articulo = null;
        public altaArticulo()
        {
            InitializeComponent();
            Text = "Añadir un articulo";
            cargarImagen("");
        }
        public altaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
            btnAgregar.Text = "Guardar";
            cargarImagen("");
        }
        private void llenarCampos()
        {
            tbxCodigo.Text = articulo.Codigo;
            tbxNombre.Text = articulo.Nombre;
            tbxDescripcion.Text = articulo.Descripcion;
            cbxMarca.SelectedValue = articulo.Marca.Id;
            cbxCategoria.SelectedValue = articulo.Categoria.Id;
            tbxPrecio.Text = articulo.Precio.ToString();
            tbxImagen.Text = articulo.UrlImagen;
            cargarImagen(articulo.UrlImagen);
        }
        private void cargarImagen(string link)
        {
            try
            {
                imagen.Load(link);
            }
            catch (Exception)
            {
                imagen.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");
            }
        }
        private void cargarDesplegables()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cbxMarca.DataSource = marcaNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = categoriaNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception )
            {
                MessageBox.Show("No se puede acceder a los datos, vuevla a intentarlo luego");
                this.Close();
            }
        }
        private void altaArticulo_Load(object sender, EventArgs e)
        {
            cargarDesplegables();
            if (articulo != null)
                llenarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (verificarCampos())
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                if (articulo == null)
                        articulo = new Articulo();
                    try
                    {   
                        articulo.Codigo = tbxCodigo.Text;
                        articulo.Nombre = tbxNombre.Text;
                        articulo.Descripcion = tbxDescripcion.Text;
                        articulo.Marca = (Marca)cbxMarca.SelectedItem;
                        articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                        articulo.UrlImagen = tbxImagen.Text;
                        articulo.Precio = decimal.Parse(tbxPrecio.Text);
                        if (articulo.Id != 0)
                        {
                            articuloNegocio.modificar(articulo);
                            MessageBox.Show("Articulo modificado exitosamente");
                        }
                        else
                        {
                            articuloNegocio.agregar(articulo);
                            MessageBox.Show("Articulo agregado exitosamente");
                        }
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                
            }
        }

        private bool verificarCampos()
        {
            if (tbxCodigo.Text == "")
            {
                tbxCodigo.BackColor = Color.FromArgb(250, 123, 127);
            }
            if (tbxNombre.Text == "")
            {
                tbxNombre.BackColor = Color.FromArgb(250, 123, 127);
            }
            if (tbxPrecio.Text == "")
            {
                tbxPrecio.BackColor = Color.FromArgb(250, 123, 127);
            }
            if (tbxPrecio.Text == "" || tbxNombre.Text == "" || tbxCodigo.Text == "")
            {
                lblObligatorios.Visible = true;
                return false;
            }
            return true;
        }

        private void tbxCodigo_TextChanged(object sender, EventArgs e)
        {
            tbxCodigo.BackColor = Color.White;
        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {
            tbxNombre.BackColor = Color.White;
        }

        private void tbxPrecio_TextChanged(object sender, EventArgs e)
        {
            tbxPrecio.BackColor = Color.White;
        }

        private void tbxImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxImagen.Text);
        }

        private void cbxMarca_Leave(object sender, EventArgs e)
        {
            foreach (var item in cbxMarca.Items)
            {
                if (item.ToString() == cbxMarca.Text)
                    return;
            }
            if (MessageBox.Show("Agregar la marca " + cbxMarca.Text + " a la base de datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                Marca nMarca = new Marca();
                nMarca.Descripcion = cbxMarca.Text;
                try
                {
                    marcaNegocio.agregar(nMarca);
                    cargarDesplegables();
                    cbxMarca.Text = nMarca.Descripcion;
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error, intente mas tarde");
                }
            }
            else
                if (articulo != null)
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                else
                    cbxMarca.Text = cbxMarca.Items[0].ToString();

        }

        private void cbxCategoria_Leave(object sender, EventArgs e)
        {
            foreach (var item in cbxCategoria.Items)
            {
                if (item.ToString() == cbxCategoria.Text)
                    return;
            }
            if (MessageBox.Show("Agregar la categoria " + cbxCategoria.Text + " a la base de datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                Categoria nCategoria = new Categoria();
                nCategoria.Descripcion = cbxCategoria.Text;
                try
                {
                    categoriaNegocio.agregar(nCategoria);
                    cargarDesplegables();
                    cbxCategoria.Text = nCategoria.Descripcion;
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error, intente mas tarde");
                }
            }
            else
                if (articulo != null)
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                else
                    cbxCategoria.Text = cbxCategoria.Items[0].ToString();
        }

        /*
         * PARA SELECCIONAR Y GUARDAR LA IMAGEN DE LOS ARCHIVOS LOCALES
         archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardo la imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
         */
    }
}
