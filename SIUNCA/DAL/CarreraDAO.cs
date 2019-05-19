﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015.Persistencia;


namespace DAL
{
    public class CarreraDAO
    {
        public List<Carrera>  TraerTodo()
        { 
            List<Carrera> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                resultado = unaConexion.EjecutarTupla<Carrera>("SELECT IdCarrera, Nombre FROM Carrera", new List<Parametro>());
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }

       

        public List<Alumno> TraerTodo(Alumno UnAlumno)
        {
            List<Alumno> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();

                listaParametrosCD.Add(new Parametro("LegajoAlumno", UnAlumno.LegajoAlumno));

                resultado = unaConexion.EjecutarTupla<Alumno>("Select c.* from Carrera c Inner join Alumno a on a.IdCarrera = c.IdCarrera where a.LegajoAlumno = (@LegajoAlumno)", listaParametrosCD);
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }
    }

}
