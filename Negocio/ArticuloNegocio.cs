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
        public List<Articulo> listar()
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
        public void modificar(Articulo articulo)
        {
            AccesoBD datos = new AccesoBD();
            try
            {
                datos.setConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, IdMarca = @idMarca, IdCategoria = @idCat, ImagenUrl = @img, Precio = @precio where Id = @id");
                datos.setParametro("@id", articulo.Id);
                datos.setParametro("@codigo", articulo.Codigo);
                datos.setParametro("@nombre", articulo.Nombre);
                datos.setParametro("@desc", articulo.Descripcion);
                datos.setParametro("@idMarca", articulo.Marca.Id);
                datos.setParametro("@idCat", articulo.Categoria.Id);
                datos.setParametro("@img", articulo.UrlImagen);
                datos.setParametro("@precio", articulo.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoBD datos = new AccesoBD();
            try
            {
                
                datos.setConsulta("Insert into ARTICULOS values(@codigo,@nombre,@descripcion,@idMarca, @idCategoria, @imagen, @precio)");
                datos.setParametro("@codigo", nuevo.Codigo);
                datos.setParametro("@nombre", nuevo.Nombre);
                datos.setParametro("@descripcion", nuevo.Descripcion);
                datos.setParametro("@idMarca", nuevo.Marca.Id);
                datos.setParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setParametro("@imagen", nuevo.UrlImagen);
                datos.setParametro("@precio", nuevo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
