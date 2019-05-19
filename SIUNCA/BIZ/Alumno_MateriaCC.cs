using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class Alumno_MateriaCC  : Bitacora

    {
        public int IdDetallesAlumnoMateriaCC { get; set; }
        public int IdMateriaCC { get; set; }
        public int LegajoAlumno { get; set; }
        public string Estado { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoAlumno { get; set; }
        public string NombreCarrera { get; set; }
        public string NombreMateria { get; set; }
        //public int Turno { get; set; }
    }
}