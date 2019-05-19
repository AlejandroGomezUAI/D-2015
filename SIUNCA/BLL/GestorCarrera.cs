using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;

namespace BLL
{
    
        public class GestorCarrera
        {
            public List<Carrera> TraerListaCarreras()
            {
                List<Carrera> ListaCarrera = new List<Carrera>();
                CarreraDAO unaCarreraDAO = new CarreraDAO();
                ListaCarrera = unaCarreraDAO.TraerTodo();
            
                return ListaCarrera;
            }

            public List<Alumno> TraerCarrera(Alumno UnAlumno)
            {
                List<Alumno> unaCarrera = new List<Alumno>();
                CarreraDAO unaCarreraDAO = new CarreraDAO();
                unaCarrera = unaCarreraDAO.TraerTodo(UnAlumno);
                return unaCarrera;
            }
        }
    
}
