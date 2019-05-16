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

                CargarCarreraDelAlumno();
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

            ComboApellido.DataSource = null;
            ComboApellido.DataSource = unGAlumno.TraerAlumno(UnAlumno);
            ComboApellido.DisplayMember = "Apellido";
        }
        private void CargarCarreraDelAlumno()
        {
            Alumno UnAlumno = new Alumno();
            GestorCarrera unGC = new GestorCarrera();

            UnAlumno.LegajoAlumno = int.Parse(txtLegajo.Text);

            ComboCarrera.DataSource = null;
            ComboCarrera.DataSource = unGC.TraerCarrera(UnAlumno);
            ComboCarrera.DisplayMember = "Nombre";
        }



    }
}
