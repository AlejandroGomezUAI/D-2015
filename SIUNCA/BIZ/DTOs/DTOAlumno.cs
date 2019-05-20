using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ.DTOs
{
    public class DTOAlumno
    {
        public int LegajoAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdMateriaCC { get; set; }
        public string Materia { get; set; }
        public string Estado { get; set; }
    }
}
