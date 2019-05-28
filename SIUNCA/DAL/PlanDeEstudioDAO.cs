using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;
using System.Collections;

namespace DAL
{

    public class PlanDeEstudioDAO
    {
        public void Insertar(PlanDeEstudio unPlanDeEstudio, List<DetallesPlanDeEstudio> PEDetalles)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaDeParametros = new List<Parametro>();
            listaDeParametros.Add(new Parametro("Nombre", unPlanDeEstudio.Nombre));
            listaDeParametros.Add(new Parametro("NombreCarrera", unPlanDeEstudio.NombreCarrera));
            listaDeParametros.Add(new Parametro("IdCarrera", unPlanDeEstudio.IdCarrera));
            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                unaConexion.EjecutarSinResultado("INSERT INTO PlanDeEstudio (IdCarrera, Nombre, NombreCarrera) VALUES (@IdCarrera, @Nombre, @NombreCarrera)", listaDeParametros);

                int IdPlanDeEstudio = unaConexion.EjecutarEscalar<int>("SELECT MAX(IdPlanDeEstudio) FROM PlanDeEstudio", new List<Parametro>());


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

                    unaConexion.EjecutarSinResultado("INSERT INTO DetallesPlanDeEstudio (IdPlanDeEstudio, IdMateriaCC, Obligatoriedad, NumeroMateria, NombreMateria, Año) VALUES(@IdPlanDeEstudio, @IdMateriaCC, @Obligatoriedad, @NumeroMateria, @NombreMateria, @Año)", listaParametrosPED);
                }

                unaConexion.TransaccionAceptar();
            }
            catch (Exception x)
            {
                unaConexion.TransaccionCancelar();
                // EventViewer.RegistrarError("VB", "SQL", "ERROR AL PRODUCIR TRANSACCION", EventViewer.TipoEvento._Error)
                //Interaction.MsgBox("error al insertar plan de estudio detalles");
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }

            
        }
        public List<PlanDeEstudio> TraerTodo()
        {
            List<PlanDeEstudio> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                resultado = unaConexion.EjecutarTupla<PlanDeEstudio>("SELECT IdPlanDeEstudio, Nombre FROM PlanDeEstudio", new List<Parametro>());
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
