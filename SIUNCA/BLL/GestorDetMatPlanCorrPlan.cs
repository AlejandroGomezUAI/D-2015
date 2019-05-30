using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;

namespace BLL
{
    public class GestorDetMatPlanCorrPlan
    {
        //public List<MateriaConCorrelativas> TraerListaMateriasCC()
        //{
        //    List<MateriaConCorrelativas> ListaMateriasCC = new List<MateriaConCorrelativas>();
        //    MateriaConCorrelativaDAO unaMateriaCCDAO = new MateriaConCorrelativaDAO();
        //    ListaMateriasCC = unaMateriaCCDAO.TraerTodo();
        //    return ListaMateriasCC;
        //}

        //public List<MateriaConCorrelativas> TraerListaMateriasCC(Carrera UnaCarrera)
        //{
        //    List<MateriaConCorrelativas> ListaMateriasCC = new List<MateriaConCorrelativas>();
        //    MateriaConCorrelativaDAO unaMateriaCCDAO = new MateriaConCorrelativaDAO();
        //    ListaMateriasCC = unaMateriaCCDAO.TraerTodo(UnaCarrera);
        //    return ListaMateriasCC;
        //}

        static public void CrearDetMatPlanCorrPlan(List<DetallesDetMatPlanCorrPlan> DetallesMPCP)
        {
            // If CorrelativasDetalles.Exists Then
            // End If

            GuardarCorrelativas(DetallesMPCP);
        }

        static private void GuardarCorrelativas(List<DetallesDetMatPlanCorrPlan> DetallesMPCP)
        {
            GestorDetMatPlanCorrPlanDAO UnaMateriaCCDAO = new GestorDetMatPlanCorrPlanDAO();
            UnaMateriaCCDAO.Insertar(DetallesMPCP);
        }


    }
}
