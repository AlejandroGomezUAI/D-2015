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
using BIZ.DTOs;

namespace GUI.UserControlSecretarioAcademico
{
    public partial class UCCursos : UserControl
    {
        public UCCursos()
        {
            InitializeComponent();
            CargarPlanes();
            CargarCarreras();
            CargarMaterias2();

        }
        List<Curso> ListCurso = new List<Curso>();
        private void CargarPlanes()
        {
            GestorPlanDeEstudio unGPE = new GestorPlanDeEstudio();
            ComboPEcorr.DataSource = null;
            ComboPEcorr.DataSource = unGPE.TraerListaPlanes();
            ComboPEcorr.DisplayMember = "Nombre";
            
        }
        private void CargarCarreras()
        {
            GestorCarrera unGC = new GestorCarrera();
            ComboCarrera.DataSource = null;
            ComboCarrera.DataSource = unGC.TraerListaCarreras();
            ComboCarrera.DisplayMember = "Nombre";
        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                //AGREGAR DTO CURSO
                Curso unDetCurso = new Curso();
                DTODetallesCorrPlan UnaMateria;
                Carrera UnaCarrera;

                UnaMateria = (DTODetallesCorrPlan)ComboMaterias1.SelectedItem;
                UnaCarrera = (Carrera)ComboCarrera.SelectedItem;


                unDetCurso.IdMateriaCC = UnaMateria.IdMateriaCC;
                unDetCurso.IdCarrera = UnaCarrera.IdCarrera;
                //unDetCurso.Nombre = ((DTODetallesCorrPlan)ComboMaterias1.SelectedItem).Nombre;
                //unDetCurso.CuposMax = int.Parse(ComboCuposMax.Text);
                unDetCurso.CuposMax = 50;
                unDetCurso.FechaInicio = dateTimePicker1.Value;
                unDetCurso.FechaFin = dateTimePicker2.Value;
                //unDetAlumnoMatCC.Turno = ComboTurno.Text;

                //ExisteEnLista(ComboMaterias1.Text, dgAlumMat);

                //traigo al dgAprobadas y verifico que la materia que quiero agregar no este "Aprobada"
                //ConsultarAprobadas();
                //ExisteEnListaAprobados(ComboMaterias1.Text, dgAprobadas);

                //Valido que esten las correlativas aprobadas                
                //ExisteEnDgAprobadas();


                ListCurso.Add(unDetCurso);
                dgCursoMat.DataSource = null;
                dgCursoMat.DataSource = ListCurso;
                //PODRIA AGREGAR UN DTO CURSO CON NOMBRE MATERIA NOMBRE CARRERA
                dgCursoMat.Columns.Remove("IdCurso");
                //dgCursoMat.Columns.Remove("IdMateriaCC");
                //dgCursoMat.Columns.Remove("IdAlumno_Materia");
                dgCursoMat.Columns.Remove("CreatedOn");
                dgCursoMat.Columns.Remove("CreatedBy");
                dgCursoMat.Columns.Remove("ChangedBy");
                dgCursoMat.Columns.Remove("ChangedOn");

                //dgAlumMat.Columns["LegajoAlumno"].HeaderText = "Legajo";
                //dgAlumMat.Columns["NombreAlumno"].HeaderText = "Nombre Alumno";
                //dgAlumMat.Columns["ApellidoAlumno"].HeaderText = "Apellido Alumno";
                //dgAlumMat.Columns["NombreCarrera"].HeaderText = "Carrera";
                //dgAlumMat.Columns["Nombre"].HeaderText = "Materia asignada";


                dgCursoMat.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dgCursoMat.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar");
            }
         
        }

        private void ComboPEcorr_DropDownClosed(object sender, EventArgs e)
        {
            CargarMaterias2();
        }

        private void CargarMaterias2()
        {
            DTODetallesCorrPlan unPE2;
            GestorPEDetalle unGDetPE = new GestorPEDetalle();
            unPE2 = (DTODetallesCorrPlan)ComboPEcorr.SelectedItem;
            ComboMaterias1.DataSource = null;
            ComboMaterias1.DataSource = unGDetPE.TraerListaPEDetalles(unPE2);

            ComboMaterias1.DisplayMember = "Nombre";
        }
    }
}
