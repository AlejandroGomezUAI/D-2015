using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class Asistencia : Bitacora
    {
        public int Ausente { get; set; }
        public int Estado { get; set; }
        public int Fecha { get; set; }
        public int IdAsistencia { get; set; }
        public int IdMateriaCC { get; set; }
        public int LegajoAlumno { get; set; }
        public int Presente { get; set; }

    }
}