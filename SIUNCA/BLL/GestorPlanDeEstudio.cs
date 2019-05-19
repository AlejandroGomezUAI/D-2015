using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;

namespace BLL
{
    public class GestorPlanDeEstudio
    {
        public void CrearPlanDeEstudio(PlanDeEstudio unPlanDeEstudio, List<DetallesPlanDeEstudio> PEDetalles)
        {
            // If
            // End If

            GuardarPlanDeEstudio(unPlanDeEstudio, PEDetalles);
        }

        private void GuardarPlanDeEstudio(PlanDeEstudio unPlanDeEstudio, List<DetallesPlanDeEstudio> PEDetalles)
        {
            PlanDeEstudioDAO UnPEDAO = new PlanDeEstudioDAO();
            UnPEDAO.Insertar(unPlanDeEstudio, PEDetalles);
        }
    }
}
