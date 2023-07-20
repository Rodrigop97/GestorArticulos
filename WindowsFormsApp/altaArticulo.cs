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
        }
        public altaArticulo(Articulo articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
            llenarCampos();
        }
        private void llenarCampos()
        {
            tbxCodigo.Text = articulo.Codigo;
            tbxNombre.Text = articulo.Nombre;
            tbxDescripcion.Text = articulo.Descripcion;
            //cbxMarca.Text = 
            //cbxCategoria.Text = 
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
        private void altaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            cbxCategoria.Items.Clear();
            cbxMarca.Items.Clear();
            try
            {
                cbxMarca.DataSource = marcaNegocio.listar();
                cbxCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (verificarCampos())
            {
                try
                {   
                    articulo = new Articulo();
                    ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                    articulo.Codigo = tbxCodigo.Text;
                    articulo.Nombre = tbxNombre.Text;
                    articulo.Descripcion = tbxDescripcion.Text;
                    articulo.Precio = decimal.Parse(tbxPrecio.Text);

                    if (articulo.Id != 0)
                    {

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
    }
}
