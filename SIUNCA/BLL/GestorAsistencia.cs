using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015;
using DAL;

namespace BLL
{
    public class GestorAsistencia
    {
        private AsistenciaDAO asistenciaDAO;

        public GestorAsistencia()
        {
            asistenciaDAO = new AsistenciaDAO();
        }

        public void guardarAsistencia(List<Asistencia> listadoAsistencia)
        {
            asistenciaDAO.guardarTodo(listadoAsistencia);
        }

        public bool validarFecha(int idMateria)
        {
            var resultadoFecha = asistenciaDAO.traerUltimaFecha(idMateria).FirstOrDefault();
             
            if (resultadoFecha != null)  
            {
                if (resultadoFecha.Fecha == DateTime.Today)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public List<Asistencia> traerAsistencias(int legajoAlumno, int idMateriaCC)
        {
            return asistenciaDAO.traerAsistenciasAlumno(legajoAlumno, idMateriaCC);
        }

        public void modificarAsistencia(int asistencia, int idasistencia)
        {
            var presente = 0;
            var ausente = 0;

            if (asistencia == 1)
            {
                presente = 1;
                ausente = 0;
                asistenciaDAO.guardarModificacionAsistencia(presente, ausente, idasistencia);
            }
            else
            {
                presente = 0;
                ausente = 1;
                asistenciaDAO.guardarModificacionAsistencia(presente, ausente, idasistencia);
            }
        }
    }
}
