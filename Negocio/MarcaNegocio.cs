using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> marcas = new List<Marca>();
            AccesoBD datos = new AccesoBD();

            try
            {
                datos.setConsulta("select m.Id, m.Descripcion from MARCAS m");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    marcas.Add(aux);
                }
                return marcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void agregar(Marca nuevo)
        {
            AccesoBD datos = new AccesoBD();
            try
            {
                datos.setConsulta("insert into MARCAS values(@desc)");
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
