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

namespace GUI.UserControlSecretarioAcademico
{
    public partial class UCAlumnos : UserControl
    {
        public UCAlumnos()
        {
            InitializeComponent();
        }

        private void UCAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                CargarNombreAlumno();
                //CargarApellidoAlumno();

                // ejemplo de alumno
                //ComboNombre.Text = "Juan";
                //ComboApellido.Text = "Perez";
                //ComboPlan.Text = "Sistemas16a";
                //CargarCarreraDelAlumno();
            }
        }

        private void CargarNombreAlumno()
        {
            GestorAlumno unGAlumno = new GestorAlumno();
            Alumno UnAlumno = new Alumno();
            UnAlumno.LegajoAlumno = int.Parse(txtLegajo.Text);

            //txtNombre.Text = ((Alumno)unGAlumno.TraerAlumno(UnAlumno)).NombreAlumno;           

            ComboNombre.DataSource = null;
            ComboNombre.DataSource = unGAlumno.TraerAlumno(UnAlumno);
            ComboNombre.DisplayMember = "Nombre";
        }
        //private void CargarApellidoAlumno()
        //{
        //    GestorAlumno unGAlumno = new GestorAlumno();
        //    Alumno UnAlumno = new Alumno();
        //    UnAlumno.LegajoAlumno = txtLegajo.Text;

        //    ComboApellido.DataSource = null;
        //    ComboApellido.DataSource = unGAlumno.TraerAlumno(UnAlumno);
        //    ComboApellido.DisplayMember = "Apellido";
        //}



    }
}
