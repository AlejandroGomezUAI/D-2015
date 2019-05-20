using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;

namespace DAL
{
    public class DetalleAlumnoMateriaDAO
    {
        public List<Alumno_MateriaCC> TraerTodo(Alumno unAlumno)
        {
            List<Alumno_MateriaCC> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("LegajoAlumno", unAlumno.LegajoAlumno));
                resultado = unaConexion.EjecutarTupla<Alumno_MateriaCC>("SELECT NombreMateria, NombreMateriaCC FROM DetallesCorrelativa where IdMateriaCC = (@IdMateriaCC)", listaParametrosCD);
                return resultado;
            }
            catch (Exception ex)
            {
                //MsgBox("error al traer correlativas");
                MessageBox.Show("error al traer aprobadas", ex.ToString());
                return null;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }
    }
}
