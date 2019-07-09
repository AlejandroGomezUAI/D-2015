using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using BIZ.DTOs;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;

namespace DAL
{
    public class AlumnoDAO
    {
        //public List<Alumno> traerTodo()
        //{
        //    throw new NotImplementedException();
        //}

        public List<DTOAlumno> traerTodo(string cboMateria)
        {
            List<DTOAlumno> resultado = new List<DTOAlumno>();
            var con = new Conexion("config.xml");
            con.ConexionIniciar();

           
            List<Parametro> listaParametrosCD = new List<Parametro>();
            listaParametrosCD.Add(new Parametro("Nombre", cboMateria));

            try
            {
                //cambie mayusculass
                //resultado = con.EjecutarTupla<DTOAlumno>(@"select alu.LegajoAlumno, alu.Nombre, alu.Apellido, asist.Ausente, asist.Presente, almatcc.Estado, almatcc.IdMAteriaCC from Alumno as alu inner join Alumno_MateriaCC as almatcc
                //                                            on alu.LegajoAlumno = almatcc.LegajoAlumno inner join MateriaConCorrelativas as matcor
                //                                            on almatcc.IdMAteriaCC = matcor.IdMateriaCC inner join Asistencia as asist
                //                                            on alu.LegajoAlumno = asist.LegajoAlumno
                //                                            where matcor.Nombre = @Nombre ", listaParametrosCD);

                resultado = con.EjecutarTupla<DTOAlumno>(@"select alu.LegajoAlumno, alu.Nombre, alu.Apellido, CAST(SUM(CAST(asist.Ausente as int)) as varchar) Ausente, CAST(SUM(CAST(asist.Presente as int)) as varchar) Presente, almatcc.Estado, almatcc.IdMAteriaCC from Alumno as alu inner join Alumno_MateriaCC as almatcc
                                                            on alu.LegajoAlumno = almatcc.LegajoAlumno inner join MateriaConCorrelativas as matcor
                                                            on almatcc.IdMAteriaCC = matcor.IdMateriaCC inner join Asistencia as asist
                                                            on alu.LegajoAlumno = asist.LegajoAlumno
                                                            where matcor.Nombre = @Nombre
                                                            group by alu.LegajoAlumno, alu.Nombre, alu.Apellido, almatcc.Estado, almatcc.IdMAteriaCC", listaParametrosCD);
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al traer alumnos" + ex);
                return null;
            }
            finally
            {
                con.ConexionFinalizar();
            }



        }
        public List<Alumno> TraerTodo(Alumno UnAlumno)
        {
            List<Alumno> resultado = new List<Alumno>();
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("LegajoAlumno", UnAlumno.LegajoAlumno));
                resultado = unaConexion.EjecutarTupla<Alumno>("SELECT Nombre, Apellido FROM Alumno WHERE LegajoAlumno = (@LegajoAlumno)", listaParametrosCD);


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
        public void GuardarAsignacionAlumnoAMaterias(Alumno unAlumno, List<Alumno_MateriaCC> AlumnoMateriaDetalles)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaDeParametros = new List<Parametro>();
            listaDeParametros.Add(new Parametro("LegajoAlumno", unAlumno.LegajoAlumno));

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();


                foreach (var item in AlumnoMateriaDetalles)
                {
                    List<Parametro> listaParametrosCD = new List<Parametro>();

                    //listaParametrosCD.Add(new Parametro("IdDetallesDetMatPlanCorrPlan", IdDetallesDetMatPlanCorrPlan));
                    listaParametrosCD.Add(new Parametro("IdMateriaCC", item.IdMateriaCC));
                    listaParametrosCD.Add(new Parametro("LegajoAlumno", item.LegajoAlumno));
                    listaParametrosCD.Add(new Parametro("Estado", item.Estado));


                    //item.IdDetallesDetMatPlanCorrPlan = IdDetallesDetMatPlanCorrPlan;

                    unaConexion.EjecutarSinResultado("INSERT INTO Alumno_MateriaCC (IdMateriaCC, LegajoAlumno, Estado) VALUES (@IdMateriaCC, @LegajoAlumno, @Estado)", listaParametrosCD);
                    //unaConexion.EjecutarSinResultado("INSERT INTO Curso (IdMateriaCC, IdCarrera) VALUES (@IdMateriaCC, @LegajoAlumno, @Estado)", listaParametrosCD);
                }
                unaConexion.TransaccionAceptar();
            }
            catch (Exception x)
            {
                unaConexion.TransaccionCancelar();
                // EventViewer.RegistrarError("VB", "SQL", "ERROR AL PRODUCIR TRANSACCION", EventViewer.TipoEvento._Error)
                //Interaction.MsgBox("error al insertar plan de estudio detalles");
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }

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
