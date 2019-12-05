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

        public List<Asistencia> traerUltimaFecha(int idMateria)
        {
            List<Asistencia> resultado = new List<Asistencia>();
            var parametros = new List<Parametro>();

            try
            {
                con.ConexionIniciar();

                parametros.Add(new Parametro("IdMateriaCC", idMateria));

                resultado = con.EjecutarTupla<Asistencia>(@"SELECT TOP 1 IdAsistencia, Ausente, Presente, Fecha, IdMateriaCC, LegajoAlumno 
                                                            FROM asistencia 
                                                            WHERE IdMateriaCC = (@IdMateriaCC) 
                                                            ORDER BY Fecha DESC", parametros);

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en AsistenciaDAO" + ex.Data);
                return null;
            }
            finally
            {
                con.ConexionFinalizar();
            }
        }

        public List<Asistencia> traerAsistenciasAlumno(int legajoAlumno, int idMateriaCC)
        {
            List<Asistencia> resultado = new List<Asistencia>();
            var parametros = new List<Parametro>();

            try
            {
                con.ConexionIniciar();

                parametros.Add(new Parametro("LegajoAlumno", legajoAlumno));
                parametros.Add(new Parametro("IdMateriaCC", idMateriaCC));

                resultado = con.EjecutarTupla<Asistencia>(@"SELECT IdAsistencia, Fecha, Ausente, Presente, IdMateriaCC, LegajoAlumno 
                                                            FROM Asistencia 
                                                            WHERE IdMateriaCC = @IdMateriaCC AND LegajoAlumno = @LegajoAlumno", parametros);

                return resultado;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en AsistenciaDAO" + ex.Data);
                return null;
            }
            finally
            {
                con.ConexionFinalizar();
            }
        }

        public void guardarModificacionAsistencia(int presente, int ausente, int idasistencia)
        {
            var parametros = new List<Parametro>();

            try
            {
                con.ConexionIniciar();

                parametros.Add(new Parametro("Presente", presente.ToString()));
                parametros.Add(new Parametro("Ausente", ausente.ToString()));
                parametros.Add(new Parametro("IdAsistencia", idasistencia));

                con.EjecutarSinResultado(@"UPDATE Asistencia SET Ausente = @Presente, presente = @Ausente
                                           WHERE IdAsistencia = @IdAsistencia ", parametros);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en AsistenciaDAO" + ex.Data);
            }
            finally
            {
                con.ConexionFinalizar();
            }
        }
    }
}
