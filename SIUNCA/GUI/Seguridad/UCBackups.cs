using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.D_2015.Seguridad;
using System.Data.SqlClient;

namespace GUI.Seguridad
{
    public partial class UCBackups : UserControl
    {
        public UCBackups()
        {
            InitializeComponent();
            
        }
        BackupSQL backup = new BackupSQL();
        private string cadenaConexion = null;
        private SqlConnection conexion;

        //public const string vbNewLine = vbCrLf;

        //public const string vbCrLf = vbCrLf;


        private void Button4_Click(object sender, EventArgs e)
        {
            backup.servidor = txtServidor.Text;

            // Debe haber un servidor seleccionado
            if (backup.servidor == "")
            {
                MessageBox.Show("Seleccione un servidor", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Autenticacion Windows
            if (rbWindows.Checked == true)
            {
                try
                {
                    // Prueba la conexion
                    cadenaConexion = "Server=" + backup.servidor + "; Integrated Security=SSPI";
                    conexion = new SqlConnection(cadenaConexion);
                    conexion.Open();
                    //txtStatus.AppendText("La prueba de conexion fue exitosa" + Constants.vbCrLf);
                    txtStatus.AppendText(" // La prueba de conexion fue exitosa // ");
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    //txtStatus.AppendText("Pueba de Conexion fallida" + Constants.vbCrLf);
                    txtStatus.AppendText(" // Prueba de Conexion fallida // ");
                    conexion.Close();
                    return;
                }
            }
            else if (rbWindows.Checked == false && rbSQL.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una autenticacion");
            }

            // Autenticacion SQL SERVER
            if (rbSQL.Checked == true)
            {
                if (txtUser.Text == "")
                {
                    // Request user to enter a password
                    MessageBox.Show("Ingrese el nombre de usuario", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Contraseña
                if (txtContrasenia.Text == "")
                {
                    MessageBox.Show("Ingrese la contraseña del usuario ", "Backup/Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Prueba la conexion
                    cadenaConexion = "Server=" + backup.servidor + "; Integrated Security=False;" + "User ID=" + txtUser.Text + "; " + "Password=" + txtContrasenia.Text;
                    conexion = new SqlConnection(cadenaConexion);
                    conexion.Open();
                }
                catch (SqlException ex)
                {
                   // txtStatus.AppendText("Prueba de Conexion fallida" + Constants.vbCrLf);
                    txtStatus.AppendText(" // Prueba de Conexion fallida // ");
                    conexion.Close();
                    return;
                }
            }


            
        }

    }
}
