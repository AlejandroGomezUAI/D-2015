using BIZ.Seguridad;
using Framework.D_2015.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAOSeguridad
{
    public class PatenteDAO
    {
        public List<Patente> TraerTodo()
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Patente> resultado = new List<Patente>();

            List<Patente> TraerTodasPatentes = new List<Patente>();


            try
            {
                unaConexion.ConexionIniciar();

                resultado = unaConexion.EjecutarTupla<Patente>
                    ("SELECT Id, Descripcion FROM Patente", new List<Parametro>());
            }
            catch (Exception ex)
            {
                return null;
            }

            finally
            {
                unaConexion.ConexionFinalizar();
            }

            return resultado;
        }

    }
}
