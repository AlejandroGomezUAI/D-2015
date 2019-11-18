using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;
using System.Collections;
using BIZ.DTOs;

namespace DAL
{

    public class PlanDeEstudioDAO
    {
        private Conexion con;

        public PlanDeEstudioDAO()
        {
            con = new Conexion("config.xml");
        }

        public void Insertar(PlanDeEstudio unPlanDeEstudio, List<DetallesPlanDeEstudio> PEDetalles)
        {
            List<Parametro> listaDeParametros = new List<Parametro>();
            listaDeParametros.Add(new Parametro("Nombre", unPlanDeEstudio.Nombre));
            listaDeParametros.Add(new Parametro("NombreCarrera", unPlanDeEstudio.NombreCarrera));
            listaDeParametros.Add(new Parametro("IdCarrera", unPlanDeEstudio.IdCarrera));
            try
            {
                con.ConexionIniciar();
                con.TransaccionIniciar();
                con.EjecutarSinResultado("INSERT INTO PlanDeEstudio (IdCarrera, Nombre) VALUES (@IdCarrera, @Nombre)", listaDeParametros);

                int IdPlanDeEstudio = con.EjecutarEscalar<int>("SELECT MAX(IdPlanDeEstudio) FROM PlanDeEstudio", new List<Parametro>());

                foreach (var item in PEDetalles)
                {
                    List<Parametro> listaParametrosPED = new List<Parametro>();

                    listaParametrosPED.Add(new Parametro("NumeroMateria", item.NumeroMateria));
                    listaParametrosPED.Add(new Parametro("Obligatoriedad", item.Obligatoriedad));
                    listaParametrosPED.Add(new Parametro("IdPlanDeEstudio", IdPlanDeEstudio));
                    listaParametrosPED.Add(new Parametro("IdMateriaCC", item.IdMateriaCC));
                    listaParametrosPED.Add(new Parametro("Año", item.Año));
                    listaParametrosPED.Add(new Parametro("NombreMateria", item.NombreMateria));

                    item.IdPlanDeEstudio = IdPlanDeEstudio;

                    con.EjecutarSinResultado("INSERT INTO DetallesPlanDeEstudio (IdPlanDeEstudio, IdMateriaCC, Obligatoriedad, NumeroMateria, Año) VALUES(@IdPlanDeEstudio, @IdMateriaCC, @Obligatoriedad, @NumeroMateria, @Año)", listaParametrosPED);
                }

                con.TransaccionAceptar();
            }
            catch (Exception x)
            {
                con.TransaccionCancelar();
                // EventViewer.RegistrarError("VB", "SQL", "ERROR AL PRODUCIR TRANSACCION", EventViewer.TipoEvento._Error)
                //Interaction.MsgBox("error al insertar plan de estudio detalles");
            }
            finally
            {
                con.ConexionFinalizar();
            }    
        }

        public void Modificar(DTODetallesCorrPlan unDTODMPCP)
        {
            List<Parametro> listaParametros = new List<Parametro>();

            listaParametros.Add(new Parametro("IdPlanDeEstudio", unDTODMPCP.IdPlanDeEstudio));
            listaParametros.Add(new Parametro("Nombre", unDTODMPCP.Nombre));    

            try
            {
                con.ConexionIniciar();
                con.TransaccionIniciar();

                con.EjecutarSinResultado("UPDATE PlanDeEstudio SET Nombre = (@Nombre) WHERE IdPlanDeEstudio = (@IdPlanDeEstudio)", listaParametros);
                con.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                con.TransaccionCancelar();
                MessageBox.Show("error modificando Plan");
            }

            finally
            {
                con.ConexionFinalizar();
            }
        }

        public List<DTODetallesCorrPlan> TraerTodo()
        {
            List<DTODetallesCorrPlan> resultado;
            con.ConexionIniciar();
            try
            {
                resultado = con.EjecutarTupla<DTODetallesCorrPlan>("SELECT IdPlanDeEstudio, Nombre FROM PlanDeEstudio", new List<Parametro>());
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
            finally
            {
                con.ConexionFinalizar();
            }
        }

        public List<DTODetallesCorrPlan> TraerTodo(Alumno UnAlumno, Carrera unaCarrera)
        {
            List<DTODetallesCorrPlan> resultado;
            con.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();

                listaParametrosCD.Add(new Parametro("LegajoAlumno", UnAlumno.LegajoAlumno));
                listaParametrosCD.Add(new Parametro("IdCarrera", unaCarrera.IdCarrera));
                resultado = con.EjecutarTupla<DTODetallesCorrPlan>("SELECT pe.Nombre, pe.IdPlanDeEstudio from PlanDeEstudio pe INNER JOIN Carrera c on pe.IdCarrera = c.IdCarrera INNER JOIN Alumno a on a.IdCarrera = c.IdCarrera where a.LegajoAlumno = (@LegajoAlumno) and c.IdCarrera = (@IdCarrera)", listaParametrosCD);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
            finally
            {
                con.ConexionFinalizar();
            }
            return resultado;
        }
    }
}
