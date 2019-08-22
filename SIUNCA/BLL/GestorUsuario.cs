using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BIZ;
using Framework.D_2015.Cache;

namespace BLL
{
    public class GestorUsuario
    {
        UsuarioDAO unUsuarioDAO = new UsuarioDAO();
        public string username { get; set; }

        public int traerUsuario(Usuario usuario)
        {
            var listaUsuario = new List<Usuario>();
            var res = 1;
            var unUsuarioDAO = new UsuarioDAO();
            listaUsuario = unUsuarioDAO.trarTodo(usuario);

            //Obtiene por medio de LINQ lo que se cargo de la BD en la "listaUsuario" para poder compararlos
            //con los datos ingresados en los txtbox
            CacheUsuario.email = listaUsuario.Select(x => x.email).FirstOrDefault();
            var password = listaUsuario.Select(x => x.password).FirstOrDefault();
            CacheUsuario.rol = listaUsuario.Select(x => x.rol).FirstOrDefault();

            //Esta propiedad es estatica, carga el nombre del profesor que va a ser usada en frmProfesor ni bien se logea
            CacheUsuario.username = listaUsuario.Select(x => x.username).FirstOrDefault();

            //rol profesor
            //if (email == usuario.email && password == usuario.password && rol == usuario.rol)
            if (CacheUsuario.email == usuario.email && password == usuario.password && CacheUsuario.rol == "Profesor")
            {
                return res;
            }
            else
            {
                if (CacheUsuario.email == usuario.email && password == usuario.password && CacheUsuario.rol == "Administrativo")
                {
                    res = 2;
                    return res;
                }
                else
                {
                    return 0;
                }
            }
        }

        public List<Usuario> TraerTodo()
        {
            return unUsuarioDAO.TraerTodo();
        }

        public Usuario Login(Usuario unUsuario)
        {
            return unUsuarioDAO.Login(unUsuario);
        }


    }
}
