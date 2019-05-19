using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015.Persistencia;

namespace DAL
{
    public class AlumnoDAO
    {
        public List<Alumno> traerTodo()
        {
            List<Alumno> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                resultado = unaConexion.EjecutarTupla<Alumno>("SELECT Legajo, Nombre FROM Alumno", new List<Parametro>());
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }
    }
}
