using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;

namespace BLL
{
    public class GestorCurso
    {
        public List<Curso> TraerFechasInicioCursos(MateriaConCorrelativas unaMateria)
        {
            List<Curso> ListaCursos = new List<Curso>();
            CursoDAO unCursoDAO = new CursoDAO();
            ListaCursos = unCursoDAO.TraerTodo(unaMateria);
            return ListaCursos;
        }

        public List<Curso> TraerCuposMaxCurso(Curso uncurso)
        {
            List<Curso> ListaCursos = new List<Curso>();
            CursoDAO unCursoDAO = new CursoDAO();
            ListaCursos = unCursoDAO.TraerCuposCurso(uncurso);
            return ListaCursos;
        }
    }
}
