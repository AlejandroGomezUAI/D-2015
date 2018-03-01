using System;
using System.Collections.Generic;
using BIZ;
using Framework.D_2015.Persistencia;

namespace DAL
{
    public class DetalleCorrelativaDAO
    {
       public List<DetallesCorrelativa> TraerTodo(MateriaConCorrelativas unaMateriaCC)
        {
            List<DetallesCorrelativa> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                List<Parametro> listaParametrosCD = new List<Parametro>();
                listaParametrosCD.Add(new Parametro("IdMateriaCC", unaMateriaCC.IdMateriaCC));
                resultado = unaConexion.EjecutarTupla<DetallesCorrelativa>("SELECT * FROM DetallesCorrelativa where IdMateriaCC = (@IdMateriaCC)", listaParametrosCD);
                return resultado;
            }
            catch (Exception ex)
            {
                //MsgBox("error al traer correlativas");
                throw;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }
    }
}