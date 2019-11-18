using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.D_2015.Persistencia;
using BIZ;

namespace DAL
{
    public class AsistenciaDAO
    {
        private Conexion con;

        public AsistenciaDAO()
        {
            con = new Conexion("config.xml");
        }

        public void guardarTodo(List<Asistencia> listadoAsistencia)
        {
            try
            {
                con.ConexionIniciar();
                con.TransaccionIniciar();

                foreach (var item in listadoAsistencia)
                {
                    var parametros = new List<Parametro>();

                    parametros.Add(new Parametro("Ausente", item.Ausente.ToString()));
                    parametros.Add(new Parametro("Presente", item.Presente.ToString()));
                    parametros.Add(new Parametro("Fecha", item.Fecha));
                    parametros.Add(new Parametro("IdMateriaCC", item.IdMateriaCC));
                    parametros.Add(new Parametro("LegajoAlumno", item.LegajoAlumno));

                    con.EjecutarSinResultado("INSERT INTO Asistencia (Ausente, Presente, Fecha, IdMateriaCC, LegajoAlumno) VALUES (@Ausente, @Presente, @Fecha, @IdMateriaCC, @LegajoAlumno)", parametros);
                }
                con.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en AsistenciaDAO" + ex.Data);
                con.TransaccionCancelar();
            }
            finally
            {
                con.ConexionFinalizar();
            }

        }
    }
}
