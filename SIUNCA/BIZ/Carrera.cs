using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class Carrera
    {
        public int IdCarrera { get; set; }
        public int Nombre { get; set; }
        public List<Curso> Curso { get; set; }
        public List<Alumno> Alumno { get; set; }
        public List<PlanDeEstudio> PlanDeEstudio { get; set; }
    }
}