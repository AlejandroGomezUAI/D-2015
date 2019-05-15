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
    public class AlumnoDAO
    {
        public List<Alumno> TraerTodo(Alumno UnAlumno)
        {
            List<Alumno> resultado = new List<Alumno>();
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("LegajoAlumno", UnAlumno.LegajoAlumno));
                resultado = unaConexion.EjecutarTupla<Alumno>("SELECT Nombre FROM Alumno where LegajoAlumno = (@LegajoAlumno)", listaParametrosCD);
                
                
            }            
            catch (Exception ex)
            {
                // EventViewer log = new EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error);
                //Interaction.MsgBox("error al traer el nombre y apellido del alumno");
                MessageBox.Show("error traer alumno", ex.ToString());
               
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
            return resultado;
        }
        public void GuardarAsignacionAlumnoAMaterias(List<DetallesAlumnoMateriaCC> AlumnoMateriaDetalles)
        {
        }
        public void Crear(object unAlumno)
        {
        }
        public void Modificar(object unAlumno)
        {
        }
        public void Eliminar(object unAlumno)
        {
        }

    }

        
}

