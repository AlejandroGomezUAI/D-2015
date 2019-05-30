using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using Framework.D_2015.Persistencia;
using System.Windows.Forms;


namespace DAL
{
    public class GestorDetMatPlanCorrPlanDAO
    {
        public void Insertar(List<DetallesDetMatPlanCorrPlan> DetallesMPCP)
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Parametro> listaDeParametros = new List<Parametro>();
            //listaDeParametros.Add(new Parametro("Nombre", Convert.ToString(UnaMateriaCC.Nombre)));
            //listaDeParametros.Add(new Parametro("IdPlanDetalles", unDetPE.IdPlanDetalles));
            //listaDeParametros.Add(new Parametro("IdPlanDetalles2", unDetPE2.IdPlanDetalles));           

            try
            {
                unaConexion.ConexionIniciar();
                unaConexion.TransaccionIniciar();
                //unaConexion.EjecutarSinResultado("INSERT INTO MateriaConCorrelativas (Nombre) VALUES (@Nombre)", listaDeParametros);

                int IdDetallesDetMatPlanCorrPlan = unaConexion.EjecutarEscalar<int>("SELECT MAX(IdDetallesDetMatPlanCorrPlan) FROM DetallesDetMatPlanCorrPlan", new List<Parametro>());


                foreach (var item in DetallesMPCP)
                {
                    List<Parametro> listaParametrosCD = new List<Parametro>();


                    listaParametrosCD.Add(new Parametro("IdMateriaCC", IdDetallesDetMatPlanCorrPlan));
                    listaParametrosCD.Add(new Parametro("IdPlanDetalles", item.IdPlanDetalles));
                    listaParametrosCD.Add(new Parametro("IdPlanDetalles2", item.IdPlanDetalles2));

                    item.IdDetallesDetMatPlanCorrPlan = IdDetallesDetMatPlanCorrPlan;

                    unaConexion.EjecutarSinResultado("INSERT INTO DetallesDetMatPlanCorrPlan (IdPlanDetalles, IdPlanDetalles2) VALUES (@IdPlanDetalles, @IdPlanDetalles2)", listaParametrosCD);
                }

                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                // EventViewer.RegistrarError("VB", "SQL", "ERROR AL PRODUCIR TRANSACCION", EventViewer.TipoEvento._Error)
                MessageBox.Show("error guardando MPCP");
                throw ;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }



        //public List<MateriaConCorrelativas> TraerTodo()
        //{
        //    List<MateriaConCorrelativas> resultado;
        //    Conexion unaConexion = new Conexion("config.xml");
        //    unaConexion.ConexionIniciar();
        //    try
        //    {
        //        resultado = unaConexion.EjecutarTupla<MateriaConCorrelativas>("SELECT IdMateriaCC, Nombre FROM MateriaConCorrelativas", new List<Parametro>());
        //        // resultado = unaConexion.EjecutarTupla(Of MateriaConCorrelativas)("SELECT * FROM MateriaConCorrelativas", New List(Of Parametro))
        //        return resultado;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
        //        //Interaction.MsgBox("error al traer materias con correlativas");
        //        MessageBox.Show("Error al traer materias", ex.Message.ToString());
        //        return null;
        //        //throw new ApplicationException("ERROOOOORR TRAER MATERIAS", ex);
        //    }
        //    finally
        //    {
        //        unaConexion.ConexionFinalizar();
        //    }
        //}

        //public List<MateriaConCorrelativas> TraerTodo(Carrera UnaCarrera)
        //{
        //    List<MateriaConCorrelativas> resultado;
        //    Conexion unaConexion = new Conexion("config.xml");
        //    unaConexion.ConexionIniciar();
        //    try
        //    {
        //        List<Parametro> listaParametrosCD = new List<Parametro>();


        //        listaParametrosCD.Add(new Parametro("Nombre", UnaCarrera.Nombre));

        //        resultado = unaConexion.EjecutarTupla<MateriaConCorrelativas>("Select m.Nombre, m.IdMateriaCC from MateriaConCorrelativas m Inner join detallesplandeestudio d on d.idmateriacc = m.idmateriacc Inner join plandeestudio p on d.idplandeestudio = p.idplandeestudio inner join carrera c on p.IdCarrera = c.IdCarrera where c.Nombre = (@Nombre)", listaParametrosCD);
        //        return resultado;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
        //        // Interaction.MsgBox("error al traer materias con correlativas");
        //        throw new ApplicationException("Host name could not be obtained", ex);
        //    }
        //    finally
        //    {
        //        unaConexion.ConexionFinalizar();
        //    }
        //}
    }
}
