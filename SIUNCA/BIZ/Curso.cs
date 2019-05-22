using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class Curso : Bitacora
    {
        public int Aula { get; set; }
        public int CuposMax { get; set; }
        public DateTime FechaInicio { get; set; }
        public int IdCarrera { get; set; }
        public int IdCurso { get; set; }
        public int IdMateriaCC { get; set; }
        public string nombreCurso { get; set; }
        public string NombreMateria { get; set; }
        public string Turno { get; set; }

    }
}