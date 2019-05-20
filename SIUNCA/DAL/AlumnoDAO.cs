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
                resultado = con.EjecutarTupla<DTOAlumno>(@"select alu.LegajoAlumno, alu.nombre, alu.apellido, matcor.IdMateriaCC, matcor.Nombre, almatcc.Estado  from Alumno as alu inner join Alumno_MateriaCC as almatcc
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
    }
}
