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
        public UCPlanDeEstudio()
        {
            InitializeComponent();
           
            CargarCarreras();
            CargarMateriasCC();


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
           // CargarMaterias();
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
           // CargarCarreras();
        }

     
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  CargarCarreras();

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

       
    }
}
