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
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarLista();
        }
        
        private void cargarLista()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();   
            List<Articulo> listaArticulos = articuloNegocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
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
    }
}
