using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;

namespace BLL
{
    public class GestorPEDetalle
    {
        public List<MateriaConCorrelativas> TraerListaPEDetalles(PlanDeEstudio unPE)
        {
            List<MateriaConCorrelativas> ListaPEdet = new List<MateriaConCorrelativas>();
            DetPEDAO unDETPEDAO = new DetPEDAO();
            ListaPEdet = unDETPEDAO.TraerTodo(unPE);

            //comentando
            return ListaPEdet;
        }
    }
     
}
