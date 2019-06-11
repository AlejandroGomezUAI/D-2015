using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BIZ;

namespace BLL
{
    public class GestorUsuario
    {
        public int traerUsuario(Usuario usuario)
        {
            var listaUsuario = new List<Usuario>();
            var res = 1;
            var unUsuarioDAO = new UsuarioDAO();
            listaUsuario = unUsuarioDAO.trarTodo(usuario);

            //Obtiene por medio de LINQ lo que viene de la BD para poder compararlos
            //con los datos ingresados en los txtbox
            var email = listaUsuario.Select(x => x.email).FirstOrDefault();
            var password = listaUsuario.Select(x => x.password).FirstOrDefault();
            var rol = listaUsuario.Select(x => x.rol).FirstOrDefault();

            if (email == usuario.email && password == usuario.password && rol == usuario.rol)
            {
                return res;
            }
            else
            {
                return 0;
            }
        }
    }
}
