using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            cargarImagen((string)dgvArticulos["UrlImagen", 0].Value);
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null) 
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
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
            if (filtroPrecio == "Mayor a")
            {
                listaFiltrada = listaFiltrada.FindAll(x => x.Precio > decimal.Parse(tbxPrecio.Text));
            }
            if (filtroPrecio == "Menor a")
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
        }

        private void tbxPrecio_TextChanged(object sender, EventArgs e)
        {
            if (tbxPrecio.Text != "")
                establecerFiltros();
        }

        private void cbxPrecio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxPrecio.SelectedItem.ToString() != "")
                tbxPrecio.Enabled = true;
            else
                tbxPrecio.Enabled = false;
        }
    }
}
