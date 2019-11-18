using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;
using BIZ.DTOs;

namespace BLL
{
    public class GestorPlanDeEstudio
    {
        private PlanDeEstudioDAO UnPEDAO;

        public GestorPlanDeEstudio()
        {
            UnPEDAO = new PlanDeEstudioDAO();
        }

        public void CrearPlanDeEstudio(PlanDeEstudio unPlanDeEstudio, List<DetallesPlanDeEstudio> PEDetalles)
        {
            // If
            // End If
            GuardarPlanDeEstudio(unPlanDeEstudio, PEDetalles);
        }

        private void GuardarPlanDeEstudio(PlanDeEstudio unPlanDeEstudio, List<DetallesPlanDeEstudio> PEDetalles)
        {
            UnPEDAO.Insertar(unPlanDeEstudio, PEDetalles);
        }

        public List<DTODetallesCorrPlan> TraerListaPlanes()
        {
            List<DTODetallesCorrPlan> ListaPlanes = new List<DTODetallesCorrPlan>();
            ListaPlanes = UnPEDAO.TraerTodo();

            return ListaPlanes;
        }

        public List<DTODetallesCorrPlan> TraerListaPlanes(Alumno UnAlumno, Carrera unaCarrera)
        {
            List<DTODetallesCorrPlan> ListaCarrera = new List<DTODetallesCorrPlan>();
            ListaCarrera = UnPEDAO.TraerTodo(UnAlumno, unaCarrera);
            return ListaCarrera;
        }

        public void Modificar(DTODetallesCorrPlan unDTODMPCP)
        {
            UnPEDAO.Modificar(unDTODMPCP);
        }
    }
}
