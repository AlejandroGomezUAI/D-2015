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
        List<DetallesCorrelativa> CorrelativasDetalles = new List<DetallesCorrelativa>();
        MateriaConCorrelativas UnaMateriaCC = new MateriaConCorrelativas();
        Carrera UnaCarrera = new Carrera();
        PlanDeEstudio unPlanDeEstudio = new PlanDeEstudio();


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
            try
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


                    //VALIDO REPETIDOS
                    ExisteEnLista(txtNumeroMateria.Text, dgPEMaterias);
                    ExisteEnListaNombre(ComboMaterias1.Text, dgPEMaterias);

                    //
                    if (ComboObligatoriedad.Text != "Obligatoria" & ComboObligatoriedad.Text != "Opcional")
                    {
                        MessageBox.Show("Debe seleccionar bien la obligatoriedad.");
                        throw new Exception("error campo obligatoridad");
                    }




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

                    //dgPEMaterias.Columns["NombreMateriaCC"].HeaderText = "Nombre materia";
                    dgPEMaterias.Columns["NombreMateria"].HeaderText = "Nombre materia";
                    dgPEMaterias.Columns["CargaHoraria"].HeaderText = "Carga Horaria";
                    dgPEMaterias.Columns["NumeroMateria"].HeaderText = "Numero de materia";

                    dgPEMaterias.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                    dgPEMaterias.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

                    label10.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faltan campos");
                //throw ex;
            }
            

        }

        //FUNCION Q VALIDA REPETIDOS
        public Boolean ExisteEnLista(String Rol, DataGridView Dg)
        {
            Boolean existe = false;
            foreach (DataGridViewRow row in Dg.Rows)
            {
                String verificar = Convert.ToString(row.Cells["NumeroMateria"].Value);
                if (Rol == verificar)
                {
                    labelMensaje.Text = "Ya existe";
                    existe = true;
                    MessageBox.Show("Numero de materia repetido");
                    throw new Exception("Numero de materia repetido");
                    break;
                }
                else
                {
                    existe = false;
                    labelMensaje.Text = "Agregado";
                }
            }
            return existe;
        }

        public Boolean ExisteEnListaNombre(String Rol, DataGridView Dg)
        {
            Boolean existe = false;
            foreach (DataGridViewRow row in Dg.Rows)
            {
                String verificar = Convert.ToString(row.Cells["NombreMateria"].Value);
                if (Rol == verificar)
                {
                    labelMensaje.Text = "Ya existe";
                    existe = true;
                    MessageBox.Show("Nombre de materia repetido");                    
                    throw new Exception("Nombre de materia repetido");
                    break;
                }
                else
                {
                    existe = false;
                    labelMensaje.Text = "Agregado";
                }
            }
            return existe;
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
            {
                DetallesCorrelativa unDetalleCorrelativa = new DetallesCorrelativa();
                Materias unaMateria;
                // Dim UnaMateriaCC As MateriaConCorrelativas

                unaMateria = (Materias)ComboCorrelativas.SelectedItem;
                unaMateria.Nombre = ComboCorrelativas.Text;

                unDetalleCorrelativa.IdMateria = unaMateria.IdMateria;
                unDetalleCorrelativa.NombreMateria = unaMateria.Nombre;
                unDetalleCorrelativa.NombreMateriaCC = ComboMateriasCC.Text;


                CorrelativasDetalles.Add(unDetalleCorrelativa);


                dgCorrelatividades.DataSource = null;
                dgCorrelatividades.DataSource = CorrelativasDetalles;

                dgCorrelatividades.Columns.Remove("IdMateria");
                dgCorrelatividades.Columns.Remove("IdMateriaCC");
                dgCorrelatividades.Columns.Remove("IdDetallesCorrelativa");
                dgCorrelatividades.Columns.Remove("CreatedOn");
                dgCorrelatividades.Columns.Remove("CreatedBy");
                dgCorrelatividades.Columns.Remove("ChangedBy");
                dgCorrelatividades.Columns.Remove("ChangedOn");
                

                dgCorrelatividades.Columns["NombreMateriaCC"].HeaderText = "Materia seleccionada";
                dgCorrelatividades.Columns["NombreMateria"].HeaderText = "Correlativa asignada";

                
            }
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

        private void Button2_Click_1(object sender, EventArgs e)
        {


            UnaMateriaCC.Nombre = ((Materias)ComboMateriasCC.SelectedItem).Nombre;
            

            try
            {
                GestorMateriaCC GestorMateriaCC = new GestorMateriaCC();
                GestorMateriaCC.CrearMateriaConCorrelativa(UnaMateriaCC, CorrelativasDetalles);
                //MessageBox.Show("materia con correlativa guardada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar Materia con correlativa.");
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // unPlanDeEstudio.HorasTotales = Total


            UnaCarrera = (Carrera)ComboBox3.SelectedItem;
            unPlanDeEstudio.IdCarrera = UnaCarrera.IdCarrera;
            unPlanDeEstudio.NombreCarrera = ((Carrera)ComboBox3.SelectedItem).Nombre;
            unPlanDeEstudio.Nombre = textBox1.Text;

            try
            {
                if (unPlanDeEstudio.Nombre=="")
                {
                    MessageBox.Show("Falta nombre del plan.");
                    throw new Exception("Nombre del plan en blanco");
                }
                GestorPlanDeEstudio GestorPE = new GestorPlanDeEstudio();
                GestorPE.CrearPlanDeEstudio(unPlanDeEstudio, PEDetalles);
                MessageBox.Show("Se registró el Plan de estudio.");
                //Interaction.MsgBox("Plan de estudio guardado.");
            }
            catch (Exception ex)
            {
                //Interaction.MsgBox("Error al guardar el Plan de estudio.");
                MessageBox.Show("Error al guardar el Plan de estudio.");
            }
        }

        private void ComboMaterias1_Click(object sender, EventArgs e)
        {
            
                CargarMateriasCC();
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            CorrelativasDetalles.Remove((DetallesCorrelativa)dgCorrelatividades.CurrentRow.DataBoundItem);
            dgCorrelatividades.DataSource = null;
            dgCorrelatividades.DataSource = CorrelativasDetalles;
            //dgCorrelatividades.Columns.Remove("IdPlanDeEstudio");
            //dgCorrelatividades.Columns.Remove("IdPlanDetalles");
            dgCorrelatividades.Columns.Remove("IdMateriaCC");
            dgCorrelatividades.Columns.Remove("IdDetallesCorrelativa");
            dgCorrelatividades.Columns.Remove("IdMateria");
            
            dgCorrelatividades.Columns.Remove("ChangedBy");
            dgCorrelatividades.Columns.Remove("ChangedOn");
            dgCorrelatividades.Columns.Remove("CreatedOn");
            dgCorrelatividades.Columns.Remove("CreatedBy");

            dgCorrelatividades.Columns["NombreMateriaCC"].HeaderText = "Materia seleccionada";
            dgCorrelatividades.Columns["NombreMateria"].HeaderText = "Correlativa asignada";

            //dgPEMaterias.Columns("IdPlanDeEstudio").Visible = false;
            //dgPEMaterias.Columns("IdPlanDetalles").Visible = false;
            //dgPEMaterias.Columns("IdMateriaCC").Visible = false;
        }
    }
}
