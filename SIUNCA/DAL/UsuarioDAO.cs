using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.D_2015.Persistencia;
using BIZ;

namespace DAL
{
    public class UsuarioDAO
    {
        public List<Usuario> trarTodo(Usuario usuario)
        {
            var resultado = new List<Usuario>();

            var con = new Conexion("Config.xml");
            con.ConexionIniciar();

            List<Parametro> listaParametrosCD = new List<Parametro>();
            listaParametrosCD.Add(new Parametro("email", usuario.email));
            listaParametrosCD.Add(new Parametro("password", usuario.password));
            listaParametrosCD.Add(new Parametro("rol", usuario.rol));

            try
            {
                resultado = con.EjecutarTupla<Usuario>(@"SELECT username, password, email, rol FROM tbl_user
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
    }
}
