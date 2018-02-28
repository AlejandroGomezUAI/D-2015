using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIZ
{
    public class DetallesPlanDeEstudio : Bitacora
    {
        public int Año { get; set; }
        public int CargaHoraria { get; set; }
        public int IdMateriaCC { get; set; }
        public int IdPlanDeEstudio { get; set; }
        public int IdPlanDetalles { get; set; }
        public int NombreMateria { get; set; }
        public int NumeroMateria { get; set; }
        public int Obligatoriedad { get; set; }

    }
}