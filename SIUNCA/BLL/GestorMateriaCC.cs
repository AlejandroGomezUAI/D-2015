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
    public class GestorMateriaCC
    {
        public List<DTODetallesCorrPlan> TraerListaMateriasCC()
        {
            //List<MateriaConCorrelativas> ListaMateriasCC = new List<MateriaConCorrelativas>();
            //MateriaConCorrelativaDAO unaMateriaCCDAO = new MateriaConCorrelativaDAO();
            //ListaMateriasCC = unaMateriaCCDAO.TraerTodo();
            //return ListaMateriasCC;
            List<DTODetallesCorrPlan> ListaMateriasCC = new List<DTODetallesCorrPlan>();
            MateriaConCorrelativaDAO unaMateriaCCDAO = new MateriaConCorrelativaDAO();
            ListaMateriasCC = unaMateriaCCDAO.TraerTodo();
            return ListaMateriasCC;
        }
        
        public List<MateriaConCorrelativas> TraerListaMateriasCC(Carrera UnaCarrera)
        {
            List<MateriaConCorrelativas> ListaMateriasCC = new List<MateriaConCorrelativas>();
            MateriaConCorrelativaDAO unaMateriaCCDAO = new MateriaConCorrelativaDAO();
            ListaMateriasCC = unaMateriaCCDAO.TraerTodo(UnaCarrera);
            return ListaMateriasCC;
        }

        public void CrearMateriaConCorrelativa(MateriaConCorrelativas UnaMateriaCC, List<DetallesCorrelativa> CorrelativasDetalles)
        {
            // If CorrelativasDetalles.Exists Then
            // End If

            GuardarCorrelativas(UnaMateriaCC, CorrelativasDetalles);
        }

        private void GuardarCorrelativas(MateriaConCorrelativas UnaMateriaCC, List<DetallesCorrelativa> CorrelativasDetalles)
        {
            MateriaConCorrelativaDAO UnaMateriaCCDAO = new MateriaConCorrelativaDAO();
            UnaMateriaCCDAO.Insertar(UnaMateriaCC, CorrelativasDetalles);
        }


      


        public void Modificar(MateriaConCorrelativas unaMatera)
        {
        }
        public void Eliminar(MateriaConCorrelativas unAlumno)
        {
        }
    }

}
