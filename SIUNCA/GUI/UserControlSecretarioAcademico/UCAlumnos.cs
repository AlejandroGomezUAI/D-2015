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
        int resta = 0;
        int suma = 0;


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
            unDetAlumnoMatCC.Nombre = ((MateriaConCorrelativas)ComboMaterias1.SelectedItem).Nombre;
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

            //dgAlumMat.Columns.Remove("IdDetallesMateriaCC");
            dgAlumMat.Columns.Remove("IdMateriaCC");
            dgAlumMat.Columns.Remove("IdAlumno_Materia");
            dgAlumMat.Columns.Remove("CreatedOn");
            dgAlumMat.Columns.Remove("CreatedBy");
            dgAlumMat.Columns.Remove("ChangedBy");
            dgAlumMat.Columns.Remove("ChangedOn");

            dgAlumMat.Columns["LegajoAlumno"].HeaderText = "Legajo";
            dgAlumMat.Columns["NombreAlumno"].HeaderText = "Nombre Alumno";
            dgAlumMat.Columns["ApellidoAlumno"].HeaderText = "Apellido Alumno";
            dgAlumMat.Columns["NombreCarrera"].HeaderText = "Carrera";
            dgAlumMat.Columns["Nombre"].HeaderText = "Materia asignada";



            dgAlumMat.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dgAlumMat.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);


            //resto 1
            //int resultado;
            resta = int.Parse(ComboCupos.Text) - 1;
            ComboCupos.Text = resta.ToString();
            
           
            
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            CargarCorrelativas();
        }
        private void CargarCorrelativas()
        {
            MateriaConCorrelativas unaMateriaCC;
            GestorDetallesCorrelativa unGDC = new GestorDetallesCorrelativa();
            unaMateriaCC = (MateriaConCorrelativas)ComboMaterias1.SelectedItem;
            dgCorrelativas.DataSource = null;
            dgCorrelativas.DataSource = unGDC.TraerListaCorrelativas(unaMateriaCC);
            // dgCorrelativas.Columns("IdDetallesCorrelativa").Visible = false;            
            // dgCorrelativas.Columns("IdMateria").Visible = false;
            // dgCorrelativas.Columns("IdMateriaCC").Visible = false;
            // dgCorrelativas.Columns("NombreMateriaCC").HeaderText = "Materia consultada";
            // dgCorrelativas.Columns("NombreMateria").HeaderText = "Correlativa";
            dgCorrelativas.Columns.Remove("IdMateriaCC");
            dgCorrelativas.Columns.Remove("IdMateria");
            dgCorrelativas.Columns.Remove("IdDetallesCorrelativa");
            dgCorrelativas.Columns.Remove("ChangedBy");
            dgCorrelativas.Columns.Remove("ChangedOn");
            dgCorrelativas.Columns.Remove("CreatedOn");
            dgCorrelativas.Columns.Remove("CreatedBy");

            dgCorrelativas.Columns[0].HeaderText = "Correlativas";
            dgCorrelativas.Columns[1].HeaderText = "Materia consultada";

            dgCorrelativas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dgCorrelativas.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

        }

        private void BtnConsultarCorrelativas_Click(object sender, EventArgs e)
        {
            ConsultarAprobadas();
        }
        private void ConsultarAprobadas()
        {
            Alumno unAlumno = new Alumno();
            GestorDetallesAlumnoMateria unGDC = new GestorDetallesAlumnoMateria();
            unAlumno.LegajoAlumno = int.Parse(txtLegajo.Text);
            dgAprobadas.DataSource = null;
            dgAprobadas.DataSource = unGDC.TraerMateriasAprobadas(unAlumno);

            dgAprobadas.Columns.Remove("IdMateriaCC");
            dgAprobadas.Columns.Remove("LegajoAlumno");
            dgAprobadas.Columns.Remove("IdAlumno_Materia");
            dgAprobadas.Columns.Remove("NombreAlumno");
            dgAprobadas.Columns.Remove("ApellidoAlumno");
            dgAprobadas.Columns.Remove("NombreCarrera");
            dgAprobadas.Columns.Remove("ChangedBy");
            dgAprobadas.Columns.Remove("ChangedOn");
            dgAprobadas.Columns.Remove("CreatedOn");
            dgAprobadas.Columns.Remove("CreatedBy");

        }

        private void ComboFechasInicioCurso_Click(object sender, EventArgs e)
        {
            TraerFechasInicioCursos();
            TraerCuposMaxCurso();
          
        }

        private void TraerFechasInicioCursos()
        {
            GestorCurso UnGCurso = new GestorCurso();
            MateriaConCorrelativas unaMateria = new MateriaConCorrelativas();


            unaMateria.IdMateriaCC = ((MateriaConCorrelativas)ComboMaterias1.SelectedItem).IdMateriaCC;

            ComboFechasInicioCurso.DataSource = null;
            ComboFechasInicioCurso.DataSource = UnGCurso.TraerFechasInicioCursos(unaMateria);
            ComboFechasInicioCurso.DisplayMember = "FechaInicio";
            
            //ComboFechasInicioCurso.DisplayMember = "FechaInicio";
            //dateTimePicker1.Show = UnCurso.TraerFechasInicioCursos(unaMateria);
        }

        private void TraerCuposMaxCurso()
        {
            GestorCurso UnGCurso = new GestorCurso();
            Curso uncurso = new Curso();

            try
            {
                uncurso.IdCurso = ((Curso)ComboFechasInicioCurso.SelectedItem).IdCurso;

                ComboCuposMax.DataSource = null;
                ComboCuposMax.DataSource = UnGCurso.TraerCuposMaxCurso(uncurso);
                ComboCuposMax.DisplayMember = "CuposMax";
                ComboCupos.DataSource = null;
                ComboCupos.DataSource = UnGCurso.TraerCuposMaxCurso(uncurso);
                ComboCupos.DisplayMember = "CuposMax";
               
                //resta = ((Curso)ComboCuposMax.SelectedValue).CuposMax - 1;

            }
            catch (Exception ex)
            {

                MessageBox.Show("No hay cursos", ex.ToString());
                
            }
            

        }

        private void ComboCupos_Click(object sender, EventArgs e)
        {
            //Restar 1 a cuposmax

        }

        private void ComboMateriasCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }



        //private void ComboMaterias1_Click(object sender, EventArgs e)
        //{
        //    CargarMateriasDeCarrera();
        //    MessageBox.Show("hola");
        //}
    }
}
