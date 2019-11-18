using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.D_2015.Persistencia;
using BIZ;
using BIZ.Seguridad;

namespace DAL
{
    public class UsuarioDAO
    {
        private Conexion con;

        public UsuarioDAO()
        {
            con = new Conexion("Config.xml");
        }

        public List<Usuario> trarTodo(Usuario usuario)
        {
            var resultado = new List<Usuario>();
            con.ConexionIniciar();

            List<Parametro> listaParametrosCD = new List<Parametro>();
            listaParametrosCD.Add(new Parametro("email", usuario.email));
            listaParametrosCD.Add(new Parametro("password", usuario.password));
            listaParametrosCD.Add(new Parametro("rol", usuario.rol));

            try
            {
                resultado = con.EjecutarTupla<Usuario>(@"SELECT iduser, username, password, email, rol FROM tbl_user
                                                           WHERE email = @email and password = @password and rol =                                                @rol", listaParametrosCD);

                return resultado;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.ConexionFinalizar();
            }
        }

        public List<Usuario> TraerTodo()
        {
            List<Usuario> resultado = new List<Usuario>();
            try
            {
                con.ConexionIniciar();

                resultado = con.EjecutarTupla<Usuario>("SELECT iduser, username, password, email, rol FROM tbl_user", new List<Parametro>());
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.ConexionFinalizar();
            }

            return resultado;
        }

        public void eliminar(int idUsuario)
        {
            try
            {
                con.ConexionIniciar();
                con.TransaccionIniciar();
                var parametros = new List<Parametro>();
                parametros.Add(new Parametro("iduser", idUsuario));

                con.EjecutarSinResultado("DELETE FROM tbl_user WHERE iduser = @iduser", parametros);

                con.TransaccionAceptar();
            }
            catch (Exception)
            {
                con.TransaccionCancelar();
            }
            finally
            {
                con.ConexionFinalizar();
            }
        }

        public Usuario Login(Usuario unUsuario)
        {
            List<Usuario> resultado = new List<Usuario>();
            Usuario elUsuario = new Usuario();

            List<Patente> TraerTodasPatentes = new List<Patente>();
            List<Familia> TraerTodasFamilias = new List<Familia>();
            List<FamiliaPatente> TraerTodasFamiliaPatente = new List<FamiliaPatente>();
            List<FamiliaFamilia> TraerTodasFamiliaFamilia = new List<FamiliaFamilia>();

            List<UsuarioPatente> resultadoUsuarioPatente = new List<UsuarioPatente>();
            List<UsuarioFamilia> resultadoUsuarioFamilia = new List<UsuarioFamilia>();

            Familia PatentesAFamilias = new Familia();

            List<Parametro> listaParametros = new List<Parametro>();


            try
            {
                con.ConexionIniciar();

                listaParametros.Add(new Parametro("@IdUsuario", unUsuario.iduser));
                listaParametros.Add(new Parametro("@Contraseña", unUsuario.password));

                resultado = con.EjecutarTupla<Usuario>
                    //
                    ("SELECT * FROM tbl_user WHERE iduser = (@IdUsuario) AND password = (@Contraseña)", listaParametros);

                // Tomo el que debería ser el único usuario
                //elUsuario = resultado.First;
                elUsuario = resultado.First();

                // Traigo todas las patentes
                TraerTodasPatentes = con.EjecutarTupla<Patente>
                    ("SELECT * FROM Patente", new List<Parametro>());

                // Traigo las relaciones con Patente que tiene el Usuario 
                resultadoUsuarioPatente = con.EjecutarTupla<UsuarioPatente>
                    ("SELECT * FROM UsuarioPatente WHERE IdUsuario = (@IdUsuario)", listaParametros);

                foreach (var item in resultadoUsuarioPatente)
                {
                    // Guardo las Patentes que el Usuario tiene
                    var oo = TraerTodasPatentes.Find(y => y.Id == item.IdPatente);
                    //(!IsNothing(oo))
                    if (oo != null)
                        // Agrego la Patente a la Lista que será el Perfil del Usuario
                        PatentesAFamilias.Agregar(oo);
                }
                
                TraerTodasFamilias = con.EjecutarTupla<Familia>
                    ("SELECT * FROM Familia", listaParametros);

                resultadoUsuarioFamilia = con.EjecutarTupla<UsuarioFamilia>
                    ("SELECT * FROM UsuarioFamilia WHERE IdUsuario = (@IdUsuario)", listaParametros);

                TraerTodasFamiliaPatente = con.EjecutarTupla<FamiliaPatente>
                   ("SELECT * FROM FamiliaPatente", new List<Parametro>());

                TraerTodasFamiliaFamilia = con.EjecutarTupla<FamiliaFamilia>(("SELECT * FROM FamiliaFamilia"), new List<Parametro>());

                foreach (var item in TraerTodasFamiliaPatente)
                {
                    // Guardo las relaciones de las Familias con las Patentes
                    var mm = TraerTodasPatentes.Find(x => x.Id == item.IdPatente);
                    // Agrego la Patente a la Familia
                    TraerTodasFamilias.Find(o => o.Id == item.IdFamilia).Agregar(mm);
                }

                foreach (var item in TraerTodasFamiliaFamilia)
                {
                    // Guardo las relaciones de las Familias con las Familias Hijas
                    var mm = TraerTodasFamilias.Find(x => x.Id == item.IdFamiliaHijo);
                    // Agrego la Familia hija a la Familia
                    TraerTodasFamilias.Find(o => o.Id == item.IdFamilia).Agregar(mm);
                }

                foreach (var item in resultadoUsuarioFamilia)
                {
                    // Guardo las relaciones de los Usuarios con las Familias
                    var xx = TraerTodasFamilias.Find(x => x.Id == item.IdFamilia);

                    if (xx != null)
                        // Agrego la Familia a la lista que será el Perfil del Usuario
                        PatentesAFamilias.Agregar(xx);
                }

                // Le pego el perfil al usuario
                elUsuario.Perfil = PatentesAFamilias;
            }
            catch (Exception ex)
            {
                return null;
            }

            finally
            {
            }
            return elUsuario;
        }

        public void insertarUsuario(Usuario usuario)
        {
            try
            {
                con.ConexionIniciar();
                con.TransaccionIniciar();

                var parametros = new List<Parametro>();
                parametros.Add(new Parametro("username", usuario.username));
                parametros.Add(new Parametro("password", usuario.password));
                parametros.Add(new Parametro("email", usuario.email));
                parametros.Add(new Parametro("rol", usuario.rol));

                con.EjecutarSinResultado("INSERT INTO tbl_user (username, password, email, rol) VALUES (@username, @password, @email, @rol)", parametros);

                con.TransaccionAceptar();
            }
            catch (Exception)
            {
                con.TransaccionCancelar();
            }
            finally
            {
                con.ConexionFinalizar();
            }
        }

        public void GuardarPermisos(Usuario unUsuario)
        {
            try
            {
                con.ConexionIniciar();

                con.TransaccionIniciar();

                List<Parametro> listaParametros = new List<Parametro>();


                listaParametros.Add(new Parametro("@IdUsuario", unUsuario.iduser));

                // Borro todos los Perfiles
                con.EjecutarSinResultado("DELETE FROM UsuarioFamilia WHERE IdUsuario = (@IdUsuario); DELETE FROM UsuarioPatente WHERE IdUsuario = (@IdUsuario)", listaParametros);

                // Asigno las Familias

                foreach (var Item in unUsuario.Perfil.Lista)
                {
                    List<Parametro> listaParametros2 = new List<Parametro>();

                    if (Item.GetType() == typeof(Familia))
                    {
                        listaParametros2.Add(new Parametro("@IdUsuario", unUsuario.iduser));
                        listaParametros2.Add(new Parametro("@IdFamilia", Item.Id));
                        con.EjecutarSinResultado("INSERT INTO UsuarioFamilia (IdUsuario, IdFamilia) VALUES (@IdUsuario, @IdFamilia)", listaParametros2);
                    }
                    else if (Item.GetType() == typeof(Patente))
                    {
                        listaParametros2.Add(new Parametro("@IdUsuario", unUsuario.iduser));
                        listaParametros2.Add(new Parametro("@IdPatente", Item.Id));
                        con.EjecutarSinResultado("INSERT INTO UsuarioPatente (IdUsuario, IdPatente) VALUES (@IdUsuario, @IdPatente)", listaParametros2);
                    }
                }

                con.TransaccionAceptar();
            }
            catch (Exception ex)
            {
                con.TransaccionCancelar();
                throw;
            }
            finally
            {
                con.ConexionFinalizar();
            }
        }

    }
}
