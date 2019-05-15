using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class Alumno : Bitacora
    {
        public string Apellido { get; set; }
        public int Email { get; set; }
        public int IdCarrera { get; set; }
        public int LegajoAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public int Sexo { get; set; }
        public List<Asistencia> Asistencia { get; set; }
        public List<Evaluacion> Evaluacion { get; set; }
        public Promedio Promedio { get; set; }
        public List<AlumnoMateria> AlumnoMateria { get; set; }

    }
}