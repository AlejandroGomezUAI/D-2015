using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;

namespace BLL
{
    public class GestorAlumno
    {
        public List<Alumno> traerAlumnos()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            var unAlumnoDAO = new AlumnoDAO();
            listaAlumnos = unAlumnoDAO.traerTodo();

            return listaAlumnos;

        }
    }
}
