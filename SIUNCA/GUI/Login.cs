using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
using Framework.D_2015;
using BLL;
//Using necesarios para el idioma
using System.Threading;
using System.Globalization;
using GUI.Idiomas;

namespace GUI
{
    public partial class Login : Form
    {
        //variables para la funcion arrastrarForm(e, x , y)
        int x = 0, y = 0;

        public Login()
        {
            InitializeComponent();
            lblError.Visible = false;
            cboIdioma.SelectedIndex = 0;
            cboRol.SelectedIndex = 2;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            usuario.email = txtUsuario.Text;
            usuario.password = txtContraseña.Text;
            usuario.rol = cboRol.Text;

            var gestorUsuario = new GestorUsuario();
            var resultadoUser = gestorUsuario.traerUsuario(usuario);

            if (resultadoUser == 1)
            {
                //###########################################################
                //Este form es para el secretario academico
                //frmSecretarioAcademico frmsa = new frmSecretarioAcademico();
                //frmsa.Show();
                //###########################################################
                //Este es el del profesor
                frmProfesor frmp = new frmProfesor(gestorUsuario.username);
                frmp.Show();
                this.Hide();
            }
            else
            {
                if (resultadoUser == 2)
                {
                    frmSecretarioAcademico frmsa = new frmSecretarioAcademico();
                    frmsa.Show();
                }
                else
                {
                    lblError.Visible = true;
                    //lblError.Text = "Usuario o contraseña incorrecto";
                }
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            arrastrarForm(e, ref x, ref y);
        }

        private void panelFooter_MouseMove(object sender, MouseEventArgs e)
        {
            arrastrarForm(e, ref x, ref y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            arrastrarForm(e, ref x, ref y);
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambiarIdioma(cboIdioma.SelectedItem.ToString());
        }

        /// <summary>
        /// El idioma por defecto es español, el archivo por defecto es Res.resx
        /// </summary>
        void IdiomaPorDefecto()
        {
            lblIdioma.Text = Res.lblIdioma;
            lblInicioDeSesion.Text = Res.lblInicioDeSesion;
            lblUsuario.Text = Res.lblUsuario;
            lblContraseña.Text = Res.lblContraseña;
            lblRol.Text = Res.lblRol;
            lblError.Text = Res.lblError;
            btnLogin.Text = Res.btnLogin;
            btnCancelar.Text = Res.btnCancelar;
        }

        void cambiarIdioma(string idioma)
        {
            if (idioma == "Ingles")
            {
                //Selecciona el archivo Res.en-US.resx
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                IdiomaPorDefecto();
            }
            if (idioma == "Español")
            {
                //Selecciona el archivo Res.resx
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                IdiomaPorDefecto();
            }
        }

        /// <summary>
        /// Metodo para arrastrar el form desde cualquier parte del loguin
        /// </summary>
        /// <param name="e">evento MouseEventArgs</param>
        /// <param name="x">valor por referencia del eje horizontal</param>
        /// <param name="y">valor por referencia del eje vertical</param>
        public void arrastrarForm(MouseEventArgs e, ref int x, ref int y)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                Left = Left + (e.X - x);
                Top = Top + (e.Y - y);
            }
        }
    }
}
