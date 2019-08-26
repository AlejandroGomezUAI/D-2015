using BIZ.Seguridad;
using Framework.D_2015.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAOSeguridad
{
    public class FamiliaDAO
    {
        public List<Familia> TraerTodo()
        {
            Conexion unaConexion = new Conexion("config.xml");
            List<Familia> TraerTodasFamilias = new List<Familia>();

            Familia PatentesAFamilias = new Familia();

            List<Patente> TraerTodasPatentes = new List<Patente>();

            List<FamiliaPatente> TraerTodasFamiliaPatente = new List<FamiliaPatente>();

            List<FamiliaFamilia> TraerTodasFamiliaFamilia = new List<FamiliaFamilia>();

            try
            {
                unaConexion.ConexionIniciar();


                TraerTodasFamilias = unaConexion.EjecutarTupla<Familia>
                    ("SELECT Id, Descripcion FROM Familia", new List<Parametro>());

                TraerTodasPatentes = unaConexion.EjecutarTupla<Patente>
                    ("SELECT Id, Descripcion FROM Patente", new List<Parametro>());

                TraerTodasFamiliaPatente = unaConexion.EjecutarTupla<FamiliaPatente>(("SELECT IdFamilia, IdPatente FROM FamiliaPatente"), new List<Parametro>());

                TraerTodasFamiliaFamilia = unaConexion.EjecutarTupla<FamiliaFamilia>(("SELECT IdFamilia, IdFamiliaHijo FROM FamiliaFamilia"), new List<Parametro>());


                foreach (var item in TraerTodasFamiliaPatente)
                {
                    // Busco y guardo la patente que contiene el item Familia
                    var mm = TraerTodasPatentes.Find(x => x.Id == item.IdPatente);
                    // Y pego/agrego la Patente en la lista de todas las Familias
                    TraerTodasFamilias.Find(o => o.Id == item.IdFamilia).Agregar(mm);
                }

                foreach (var item in TraerTodasFamiliaFamilia)
                {
                    // Busco y guardo la Familia hija que contiene la Familia "padre"
                    var mm = TraerTodasFamilias.Find(x => x.Id == item.IdFamiliaHijo);
                    // Y pego/agrego la Familia hija a la Familia Padre
                    TraerTodasFamilias.Find(o => o.Id == item.IdFamilia).Agregar(mm);
                }
            }

            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                unaConexion.ConexionFinalizar();
            }

            return TraerTodasFamilias;
        }

        public void GuardarPermisos(Familia unaFamilia)
        {
            Conexion unaConexion = new Conexion("config.xml");

            try
            {
                unaConexion.ConexionIniciar();

                unaConexion.TransaccionIniciar();

                List<Parametro> listaParametros = new List<Parametro>();

                listaParametros.Add(new Parametro("@IdFamilia", unaFamilia.Id));

                // Borro todos los Perfiles que tenía la Familia

                // unaConexion.EjecutarSinResultado("DELETE FROM FamiliaPatente WHERE IdFamilia = (@IdFamilia); DELETE FROM UsuarioFamilia WHERE IdFamilia = (@IdFamilia); DELETE FROM FamiliaFamilia WHERE IdFamilia = (@IdFamilia)", listaParametros)
                unaConexion.EjecutarSinResultado("DELETE FROM FamiliaPatente WHERE IdFamilia = (@IdFamilia); DELETE FROM FamiliaFamilia WHERE IdFamilia = (@IdFamilia)", listaParametros);

                // Asigno las Familias

                foreach (var Item in unaFamilia.Lista)
                {
                    List<Parametro> listaParametros2 = new List<Parametro>();

                    if (Item.GetType() == typeof(Familia))
                    {
                        listaParametros2.Add(new Parametro("@IdFamilia", unaFamilia.Id));
                        listaParametros2.Add(new Parametro("@IdFamiliaHijo", Item.Id));
                        unaConexion.EjecutarSinResultado("INSERT INTO FamiliaFamilia (IdFamilia, IdFamiliaHijo) VALUES (@IdFamilia, @IdFamiliaHijo)", listaParametros2);
                    }
                    else if (Item.GetType() == typeof(Patente))
                    {
                        listaParametros2.Add(new Parametro("@IdFamilia", unaFamilia.Id));
                        listaParametros2.Add(new Parametro("@IdPatente", Item.Id));
                        unaConexion.EjecutarSinResultado("INSERT INTO FamiliaPatente (IdFamilia, IdPatente) VALUES (@IdFamilia, @IdPatente)", listaParametros2);
                    }
                }

                unaConexion.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                unaConexion.TransaccionCancelar();
                throw;
            }

            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }


    }
}
