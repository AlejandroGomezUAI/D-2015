using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using BIZ.DTOs;
using DAL;
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
                resultado = con.EjecutarTupla<DTOAlumno>(@"select alu.LegajoAlumno, alu.Nombre, alu.Apellido, matcor.IdMateriaCC, matcor.Nombre, almatcc.Estado  from Alumno as alu inner join Alumno_MateriaCC as almatcc
                                                            on alu.LegajoAlumno = almatcc.LegajoAlumno inner join MateriaConCorrelativas as matcor
                                                            on almatcc.IdMAteriaCC = matcor.IdMateriaCC
                                                            where matcor.Nombre = @Nombre", listaParametrosCD);
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
        public void GuardarAsignacionAlumnoAMaterias(List<Alumno_MateriaCC> AlumnoMateriaDetalles)
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
