using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> categorias = new List<Categoria>();
            AccesoBD datos = new AccesoBD();

            try
            {
                datos.setConsulta("select c.Id, c.Descripcion from CATEGORIAS c");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    categorias.Add(aux);
                }
                return categorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void agregar(Categoria nuevo)
        {
            AccesoBD datos = new AccesoBD();
            try
            {
                datos.setConsulta("insert into CATEGORIAS values(@desc)");
                datos.setParametro("@desc", nuevo.Descripcion);
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
