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
        
    List<Alumno_MateriaCC> ListAlumnoMateriaCC = new List<Alumno_MateriaCC>();
    

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
                CargarMateriasDeCarrera();

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

        private void CargarMateriasDeCarrera()
        {

            GestorMateriaCC UnGMCC = new GestorMateriaCC();
            Carrera UnaCarrera = new Carrera();


            UnaCarrera.Nombre = ((Carrera)ComboCarrera.SelectedItem).Nombre;

            ComboMaterias1.DataSource = null;
            ComboMaterias1.DataSource = UnGMCC.TraerListaMateriasCC(UnaCarrera);
            ComboMaterias1.DisplayMember = "Nombre";

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            Alumno_MateriaCC unDetAlumnoMatCC = new Alumno_MateriaCC();
            MateriaConCorrelativas UnaMateria;
            Carrera UnaCarrera;

            UnaMateria = (MateriaConCorrelativas)ComboMaterias1.SelectedItem;
            UnaCarrera = (Carrera)ComboCarrera.SelectedItem;


            unDetAlumnoMatCC.IdMateriaCC = UnaMateria.IdMateriaCC;
            unDetAlumnoMatCC.NombreMateria = ComboMaterias1.SelectedItem.ToString();
            unDetAlumnoMatCC.NombreCarrera = ComboCarrera.Text;
            unDetAlumnoMatCC.ApellidoAlumno = ComboApellido.Text;
            unDetAlumnoMatCC.NombreAlumno = ComboNombre.Text;
            unDetAlumnoMatCC.Estado = "Desaprobado";
            unDetAlumnoMatCC.LegajoAlumno = int.Parse(txtLegajo.Text);
            //unDetAlumnoMatCC.Turno = ComboTurno.Text;

            ListAlumnoMateriaCC.Add(unDetAlumnoMatCC);


            Alumno UnAlumno = new Alumno();
            GestorCarrera unGC = new GestorCarrera();

            UnAlumno.LegajoAlumno = int.Parse(txtLegajo.Text);

            ComboCarrera.DataSource = null;
            ComboCarrera.DataSource = unGC.TraerCarrera(UnAlumno);
            ComboCarrera.DisplayMember = "Nombre";

            dgAlumMat.DataSource = null;
            dgAlumMat.DataSource = ListAlumnoMateriaCC;


            // dgCorrelatividades.Columns.Remove("IdMateriaCC");
            //dgCorrelatividades.Columns.Remove("IdAlumno_Materia");
            //dgCorrelatividades.Columns.Remove("CreatedOn");
            //dgCorrelatividades.Columns.Remove("CreatedBy");
            //dgCorrelatividades.Columns.Remove("ChangedBy");
            //dgCorrelatividades.Columns.Remove("ChangedOn");


            //dgCorrelatividades.Columns["LegajoAlumno"].HeaderText = "Legajo Alumno";
            //dgCorrelatividades.Columns["NombreAlumno"].HeaderText = "Nombre Alumno";
            //dgCorrelatividades.Columns["ApellidoAlumno"].HeaderText = "Apellido Alumno";
            //dgCorrelatividades.Columns["NombreCarrera"].HeaderText = "Carrera seleccionada";
            //dgCorrelatividades.Columns["NombreMateria"].HeaderText = "Materia asignada";

        }

        //private void ComboMaterias1_Click(object sender, EventArgs e)
        //{
        //    CargarMateriasDeCarrera();
        //    MessageBox.Show("hola");
        //}
    }
}
