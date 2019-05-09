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
    public partial class UCPlanDeEstudio : UserControl
    {

        List<DetallesPlanDeEstudio> PEDetalles = new List<DetallesPlanDeEstudio>();

        public UCPlanDeEstudio()
        {
            InitializeComponent();
           
            CargarCarreras();
            CargarMateriasCC();
            CargarMaterias();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ComboMaterias1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CargarMateriasCC()
        {
            
            GestorMateriaCC unGM = new GestorMateriaCC();
            ComboMaterias1.DataSource = null;
            ComboMaterias1.DataSource = unGM.TraerListaMateriasCC();
            ComboMaterias1.DisplayMember = "Nombre";

        }

        private void btnConsultarCorrelativas_Click(object sender, EventArgs e)
        {
            CargarCorrelativas();
        }

     
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarCarreras()
        {
            GestorCarrera unGC = new GestorCarrera();
            ComboBox3.DataSource = null;
            ComboBox3.DataSource = unGC.TraerListaCarreras();
            ComboBox3.DisplayMember = "Nombre";
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

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            {
                DetallesPlanDeEstudio unDetallePE = new DetallesPlanDeEstudio();
                MateriaConCorrelativas UnaMateria;

                UnaMateria = (MateriaConCorrelativas)ComboMaterias1.SelectedItem;

               // unDetallePE.IdMateriaCC = UnaMateria.IdMateriaCC.ToString();
                unDetallePE.IdMateriaCC = UnaMateria.IdMateriaCC;
                //unDetallePE.NumeroMateria = txtNumeroMateria.Text;
                unDetallePE.NumeroMateria = int.Parse(txtNumeroMateria.Text);               
                //unDetallePE.Obligatoriedad = ComboObligatoriedad.SelectedItem.ToString;
                //unDetallePE.Obligatoriedad = ComboObligatoriedad.SelectedItem;
                unDetallePE.Obligatoriedad = ComboObligatoriedad.SelectedItem.ToString();
                unDetallePE.NombreMateria = ComboMaterias1.Text;
                unDetallePE.Año = int.Parse(txtAño.Text);
                unDetallePE.CargaHoraria = int.Parse(txtCargaHoraria.Text);

                PEDetalles.Add(unDetallePE);

                dgPEMaterias.DataSource = null;
                dgPEMaterias.DataSource = PEDetalles;
                //dgPEMaterias.Columns("IdPlanDeEstudio").Visible = false;
                //dgPEMaterias.Columns("IdPlanDetalles").Visible = false;
                //dgPEMaterias.Columns("IdMateriaCC").Visible = false;
                dgPEMaterias.Columns.Remove("IdPlanDeEstudio");
                dgPEMaterias.Columns.Remove("IdPlanDetalles");
                dgPEMaterias.Columns.Remove("IdMateriaCC");
                dgPEMaterias.Columns.Remove("ChangedBy");
                dgPEMaterias.Columns.Remove("ChangedOn");
                dgPEMaterias.Columns.Remove("CreatedOn");
                dgPEMaterias.Columns.Remove("CreatedBy");

                dgPEMaterias.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dgPEMaterias.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            PEDetalles.Remove((DetallesPlanDeEstudio)dgPEMaterias.CurrentRow.DataBoundItem);
            dgPEMaterias.DataSource = null;
            dgPEMaterias.DataSource = PEDetalles;
            dgPEMaterias.Columns.Remove("IdPlanDeEstudio");
            dgPEMaterias.Columns.Remove("IdPlanDetalles");
            dgPEMaterias.Columns.Remove("IdMateriaCC");
            dgPEMaterias.Columns.Remove("ChangedBy");
            dgPEMaterias.Columns.Remove("ChangedOn");
            dgPEMaterias.Columns.Remove("CreatedOn");
            dgPEMaterias.Columns.Remove("CreatedBy");

            dgPEMaterias.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dgPEMaterias.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            //dgPEMaterias.Columns("IdPlanDeEstudio").Visible = false;
            //dgPEMaterias.Columns("IdPlanDetalles").Visible = false;
            //dgPEMaterias.Columns("IdMateriaCC").Visible = false;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //frmCorrelativas.Show();
            //tabPage2.Show();
            //tabPage2.Focus();
            //tabPage2.Select();
            tabControl1.SelectedIndex = 1;


        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void CargarMaterias()
        {
            GestorMateria unGM = new GestorMateria();
            ComboMateriasCC.DataSource = null;
            ComboMateriasCC.DataSource = unGM.TraerListaMaterias();
            ComboMateriasCC.DisplayMember = "Nombre";

            ComboCorrelativas.DataSource = null;
            ComboCorrelativas.DataSource = unGM.TraerListaMaterias();
            ComboCorrelativas.DisplayMember = "Nombre";
        }
    }
}
