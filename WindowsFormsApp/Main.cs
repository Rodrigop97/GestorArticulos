using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsApp
{
    public partial class Main : Form
    {
        public List<Articulo> listaArticulos { get; set; } = null;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarLista();
            cargarFiltros();
        }

        
        private void cargarLista()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();   
            listaArticulos = articuloNegocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            ocultarColumnas();
            try
            {
                cargarImagen((string)dgvArticulos["UrlImagen", 0].Value);
            }
            catch (Exception)
            {
            }
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null) 
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
                lblCodigo.Text = "Codigo: " + seleccionado.Codigo;
                lblDescripcion.Text = seleccionado.Descripcion;
            }
        }

        private void cargarImagen(string link)
        {
            try
            {
                imagen.Load(link);
            }
            catch (Exception )
            {
                imagen.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            altaArticulo alta = new altaArticulo();
            alta.ShowDialog();
            borrarFiltros();
            cargarLista();

        }

        private void tbxBusqueda_TextChanged(object sender, EventArgs e)
        {
            establecerFiltros();
        }

        private void cargarFiltros()
        {
            cbxPrecio.Items.Clear();
            cbxPrecio.Items.Add("");
            cbxPrecio.Items.Add("Mayor a");
            cbxPrecio.Items.Add("Menor a");

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            cbxCategoria.Items.Clear();
            cbxMarca.Items.Clear();
            try
            {
                List<Marca> marcas = marcaNegocio.listar();
                Marca nMarca = new Marca();
                nMarca.Descripcion = "Todos";
                marcas.Insert(0, nMarca);
                List<Categoria> categorias = categoriaNegocio.listar();
                Categoria nCategoria = new Categoria();
                nCategoria.Descripcion = "Todos";
                categorias.Insert(0, nCategoria);
                cbxMarca.DataSource = marcas;
                cbxCategoria.DataSource = categorias;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cbxMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            establecerFiltros();
        }

        private void cbxCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            establecerFiltros();
        }
        private void establecerFiltros()
        {
            string filtroMarca, filtroCategoria, filtroPrecio;
            filtroMarca = cbxMarca.Text;
            filtroCategoria = cbxCategoria.Text;
            filtroPrecio = cbxPrecio.Text;

            List<Articulo> listaFiltrada;
            listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(tbxBusqueda.Text.ToUpper()));

            if (filtroMarca != "Todos")
            {
                listaFiltrada = listaFiltrada.FindAll(x => x.Marca.Descripcion == filtroMarca);
            }
            if (filtroCategoria != "Todos")
            {
                listaFiltrada = listaFiltrada.FindAll(x => x.Categoria.Descripcion == filtroCategoria);
            }
            if (filtroPrecio == "Mayor a" && tbxPrecio.Text != "")
            {
                listaFiltrada = listaFiltrada.FindAll(x => x.Precio > decimal.Parse(tbxPrecio.Text));
            }
            if (filtroPrecio == "Menor a" && tbxPrecio.Text != "")
            {
                listaFiltrada = listaFiltrada.FindAll(x => x.Precio < decimal.Parse(tbxPrecio.Text));
            }
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
        }

        private void tbxPrecio_TextChanged(object sender, EventArgs e)
        {
            if (tbxPrecio.Text != "" && soloNumeros(tbxPrecio.Text))
                establecerFiltros();
        }

        private void cbxPrecio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxPrecio.SelectedItem.ToString() != "")
            {
                tbxPrecio.Enabled = true;
            }
            else
            {
                tbxPrecio.Enabled = false;
                tbxPrecio.Text = "";
            }
            establecerFiltros();
        }
        private void borrarFiltros()
        {
            tbxBusqueda.Text = "";
            cbxMarca.SelectedIndex = 0;
            cbxCategoria.SelectedIndex = 0;
            cbxPrecio.SelectedIndex = 0;
            tbxPrecio.Clear();
            tbxPrecio.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                altaArticulo altaArticulo = new altaArticulo(seleccionado);
                altaArticulo.ShowDialog();
                borrarFiltros();
                cargarLista();
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("No se selecciono ningun elemento");
                borrarFiltros();
            }
            catch (Exception)
            {}
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char item in cadena)
            {
                if (!(char.IsNumber(item)) && item != ',')
                {
                    lblAdvertenciaPrecio.Visible = true;
                    return false;
                }
            }
            lblAdvertenciaPrecio.Visible = false;
            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                borrarFiltros();
                articuloNegocio.eliminar(seleccionado);
                cargarLista();
                MessageBox.Show("Articulo eliminado exitosamente");
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("No se selecciono ningun elemento");
                borrarFiltros();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar el articulo, intente mas tarde");
            }
        }
    }
}
