﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Framework.D_2015;
using BIZ;
using BIZ.DTOs;

namespace BLL
{
    public class GestorAlumno
    {
        //public List<Alumno> traerAlumnos()
        //{        
        //    List<Alumno> listaAlumnos = new List<Alumno>();
        //    var unAlumnoDAO = new AlumnoDAO();
        //    listaAlumnos = unAlumnoDAO.traerTodo();

        //    return listaAlumnos;
        //}


        public List<DTOAlumno> traerAlumnos(string cboMateria)
        {
            var listaAlumnos = new List<DTOAlumno>();
            var unAlumnoDAO = new AlumnoDAO();
            listaAlumnos = unAlumnoDAO.traerTodo(cboMateria);

            return listaAlumnos;
        }


        public List<Alumno> traerAlumnos(Alumno unAlumno)
        {
            throw new NotImplementedException();
        
        }

    }
}


