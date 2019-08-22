using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
using BLL;
using Framework.D_2015;


namespace GUI.Seguridad
{
    public partial class UCUsuarios : UserControl
    {
        public UCUsuarios()
        {
            InitializeComponent();
            cboRol.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            usuario.username = txtUsername.Text;
            usuario.password = txtPasword.Text;
            usuario.email = txtMail.Text;
            usuario.rol = cboRol.Text;

            var gestorusuario = new GestorUsuario();
            gestorusuario.guardarUsuario(usuario);
        }
    }
}
