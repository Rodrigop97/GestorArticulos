using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        static public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoBD datos = new AccesoBD();

            try
            {
                datos.setConsulta("select a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdMarca, m.Descripcion Marca , a.IdCategoria, c.Descripcion Categoria , a.ImagenUrl, a.Precio from ARTICULOS a, CATEGORIAS c, MARCAS m where a.IdMarca = m.Id and a.IdCategoria = c.Id");
                datos.ejecutarLectura();
                
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    
                    Marca auxm = new Marca();
                    auxm.Id = (int)datos.Lector["IdMarca"];
                    auxm.Descripcion = (string)datos.Lector["Marca"];
                    aux.Marca = auxm;
                    Categoria auxc = new Categoria();
                    auxc.Id = (int)datos.Lector["IdCategoria"];
                    auxc.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Categoria = auxc;
                    aux.UrlImagen= (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    articulos.Add(aux);
                }
                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
