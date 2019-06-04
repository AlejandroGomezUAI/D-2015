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
    public partial class UCPlanDeEstudio : UserControl
    {

        List<DetallesPlanDeEstudio> PEDetalles = new List<DetallesPlanDeEstudio>();
        List<DetallesCorrelativa> CorrelativasDetalles = new List<DetallesCorrelativa>();
        //List<DetallesDetMatPlanCorrPlan> DetallesDMPCP = new List<DetallesDetMatPlanCorrPlan>();
        //DetallesDetMatPlanCorrPlan UnDetalleCorrPlanMatPlan = new DetallesDetMatPlanCorrPlan();
        List<DTODetallesCorrPlan> DTODetallesCorrPlan = new List<DTODetallesCorrPlan>();
        DTODetallesCorrPlan unDTODMPCP = new DTODetallesCorrPlan();
        MateriaConCorrelativas UnaMateriaCC = new MateriaConCorrelativas();
        Carrera UnaCarrera = new Carrera();
        PlanDeEstudio unPlanDeEstudio = new PlanDeEstudio();


        public UCPlanDeEstudio()
        {
            InitializeComponent();

           //ucPlanDeEstudio
            CargarCarreras();
            CargarMateriasCC();
            
            //ucAsignarCorr
            CargarPlanes();
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

        private void CargarPlanes()
        {
            GestorPlanDeEstudio unGPE = new GestorPlanDeEstudio();
            ComboPEcorr.DataSource = null;
            ComboPEcorr.DataSource = unGPE.TraerListaPlanes();
            ComboPEcorr.DisplayMember = "Nombre";

            ComboConsultaPlan.DataSource = null;
            ComboConsultaPlan.DataSource = unGPE.TraerListaPlanes();
            ComboConsultaPlan.DisplayMember = "Nombre";
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
            DTODetallesCorrPlan unDTOMPCP;
            GestorDetMatPlanCorrPlan unGDTOMPCP = new GestorDetMatPlanCorrPlan();
            unDTOMPCP = (DTODetallesCorrPlan)ComboMaterias1.SelectedItem;            

            //select nombre from materias ij dpe ij ddmpcp where m.idmateria = @dto.idmateria  (TRAIGO DTO)
            unDTOMPCP.IdPlanDetalles2 = ((DTODetallesCorrPlan)ComboMaterias1.SelectedItem).IdPlanDetalles;
            unDTOMPCP.NombreMateria2 = ((DTODetallesCorrPlan)ComboMaterias1.SelectedItem).Nombre;
            //unDTOMPCP.IdPlanDeEstudio = ((DTODetallesCorrPlan)ComboConsultaPlan.SelectedItem).Nombre;
            dgConsultaCorrelativas.DataSource = null;
            dgConsultaCorrelativas.DataSource = unGDTOMPCP.TraerListaCorrelativas(unDTOMPCP);

            dgConsultaCorrelativas.Columns.Remove("IdDetallesDetMatPlanCorrPlan");
            dgConsultaCorrelativas.Columns.Remove("IdPlanDetalles");
            dgConsultaCorrelativas.Columns.Remove("IdPlanDetalles2");
            dgConsultaCorrelativas.Columns.Remove("NumeroMateria");
            dgConsultaCorrelativas.Columns.Remove("NumeroMateria2");
            dgConsultaCorrelativas.Columns.Remove("Año");
            dgConsultaCorrelativas.Columns.Remove("Obligatoriedad");
            dgConsultaCorrelativas.Columns.Remove("CargaHoraria");
            dgConsultaCorrelativas.Columns.Remove("IdMateriaCC");

            dgConsultaCorrelativas.Columns.Remove("ChangedBy");
            dgConsultaCorrelativas.Columns.Remove("ChangedOn");
            dgConsultaCorrelativas.Columns.Remove("CreatedOn");
            dgConsultaCorrelativas.Columns.Remove("CreatedBy");

            dgConsultaCorrelativas.Columns[0].HeaderText = "Correlativas";
            dgConsultaCorrelativas.Columns[1].HeaderText = "Materia Seleccionada";

            dgConsultaCorrelativas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dgConsultaCorrelativas.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

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
                    DTODetallesCorrPlan UnaMateria;

                    UnaMateria = (DTODetallesCorrPlan)ComboMaterias1.SelectedItem;

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
                    if (int.Parse(txtCargaHoraria.Text) > 20)
                    {
                        MessageBox.Show("Carga Horaria mayor a 20hs");
                        throw new Exception("Error en la carga horaria");
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
            try
            {
                {
                    DTODetallesCorrPlan unDMPCP = new DTODetallesCorrPlan();

                    DTODetallesCorrPlan unDTO;
                    DTODetallesCorrPlan unDTO2;

                    unDTO = (DTODetallesCorrPlan)ComboCorrelativas.SelectedItem;
                    unDTO.Nombre = ComboCorrelativas.Text;

                    unDTO2 = (DTODetallesCorrPlan)ComboMateriasCC.SelectedItem;
                    unDTO2.Nombre = ComboMateriasCC.Text;

                    unDMPCP.IdPlanDetalles = unDTO.IdPlanDetalles;
                    unDMPCP.IdPlanDetalles2 = unDTO2.IdPlanDetalles;
                    unDMPCP.Nombre = unDTO.Nombre;
                    unDMPCP.Nombre = ComboMateriasCC.Text;
                    unDMPCP.NombreMateria2 = unDTO2.NombreMateria2;                    
                    unDMPCP.NombreMateria2 = ComboCorrelativas.Text;
                    //unDMPCP.NombreMateriaCC = ComboMateriasCC.Text;

                    //ValidoExistente2(ComboCorrelativas.Text, dgCorrelatividades);

                    DTODetallesCorrPlan.Add(unDMPCP);


                    dgCorrelatividades.DataSource = null;
                    dgCorrelatividades.DataSource = DTODetallesCorrPlan;                    
                    


                    dgCorrelatividades.Columns.Remove("IdDetallesDetMatPlanCorrPlan");
                    dgCorrelatividades.Columns.Remove("NumeroMateria");
                    dgCorrelatividades.Columns.Remove("NumeroMateria2");
                    dgCorrelatividades.Columns.Remove("Obligatoriedad");
                    dgCorrelatividades.Columns.Remove("CargaHoraria");



                    dgCorrelatividades.Columns["Nombre"].HeaderText = "Materia seleccionada";
                    dgCorrelatividades.Columns["NombreMateria2"].HeaderText = "Correlativa asignada";


                }
            }
            catch (Exception)
            {

                MessageBox.Show("error al agregar al listado");
                throw;
            }
           
        }
        public Boolean ValidoExistente2(String Rol, DataGridView Dg)
        {
            Boolean existe = false;
            foreach (DataGridViewRow row in Dg.Rows)
            {
                String verificar = Convert.ToString(row.Cells["NombreMateria"].Value);
                if (Rol == verificar)
                {
                    //labelMensaje.Text = "Ya existe";
                    existe = true;
                    MessageBox.Show("Nombre de correlativa repetido");
                    throw new Exception("Nombre de correlativa repetido");
                    break;
                }
                else
                {
                    existe = false;
                    //labelMensaje.Text = "Agregado";
                }
            }
            return existe;
        }
        private void CargarMaterias()
        {

            DTODetallesCorrPlan unPE;
            GestorPEDetalle unGDetPE = new GestorPEDetalle();
            unPE = (DTODetallesCorrPlan)ComboPEcorr.SelectedItem;
            ComboCorrelativas.DataSource = null;
            ComboCorrelativas.DataSource = unGDetPE.TraerListaPEDetalles(unPE);

            ComboCorrelativas.DisplayMember = "Nombre";

            //
            ComboMateriasCC.DataSource = null;
            ComboMateriasCC.DataSource = unGDetPE.TraerListaPEDetalles(unPE);

            ComboMateriasCC.DisplayMember = "Nombre";

            ///// TAB CPNSULTAR CORRELATIVAS
            DTODetallesCorrPlan unPE2;
           
            unPE2 = (DTODetallesCorrPlan)ComboConsultaPlan.SelectedItem;
            ComboConsultaMateria.DataSource = null;
            //ComboConsultaMateria.DataSource = unGDetPE.TraerListaPEDetalles(unPE2);

            ComboConsultaMateria.DisplayMember = "Nombre";

        }

        private void CargarMaterias2()
        {
            DTODetallesCorrPlan unPE2;
            GestorPEDetalle unGDetPE = new GestorPEDetalle();
            unPE2 = (DTODetallesCorrPlan)ComboConsultaPlan.SelectedItem;
            ComboConsultaMateria.DataSource = null;
            ComboConsultaMateria.DataSource = unGDetPE.TraerListaPEDetalles(unPE2);

            ComboConsultaMateria.DisplayMember = "Nombre";
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            //UnaMateriaCC.Nombre = ((Materias)ComboMateriasCC.SelectedItem).Nombre;

            //try
            //{
            //    GestorMateriaCC GestorMateriaCC = new GestorMateriaCC();
            //    GestorMateriaCC.CrearMateriaConCorrelativa(UnaMateriaCC, CorrelativasDetalles);
            //    MessageBox.Show("materia con correlativa guardada.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al guardar Materia con correlativa.");
            //}

            unDTODMPCP.IdPlanDetalles = ((DTODetallesCorrPlan)ComboCorrelativas.SelectedItem).IdPlanDetalles;
            unDTODMPCP.IdPlanDetalles2 = ((DTODetallesCorrPlan)ComboMateriasCC.SelectedItem).IdPlanDetalles;
            
            try
            {
                GestorDetMatPlanCorrPlan GestorDMPCP = new GestorDetMatPlanCorrPlan();
                GestorDetMatPlanCorrPlan.CrearDetMatPlanCorrPlan(unDTODMPCP, DTODetallesCorrPlan);
                MessageBox.Show("materia con correlativa guardada.");
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
            DTODetallesCorrPlan.Remove((DTODetallesCorrPlan)dgCorrelatividades.CurrentRow.DataBoundItem);
            dgCorrelatividades.DataSource = null;
            dgCorrelatividades.DataSource = DTODetallesCorrPlan;

            dgCorrelatividades.Columns.Remove("IdDetallesDetMatPlanCorrPlan");
            dgCorrelatividades.Columns.Remove("NumeroMateria");
            dgCorrelatividades.Columns.Remove("NumeroMateria2");
            dgCorrelatividades.Columns.Remove("Obligatoriedad");
            dgCorrelatividades.Columns.Remove("CargaHoraria");

            dgCorrelatividades.Columns["Nombre"].HeaderText = "Materia seleccionada";
            dgCorrelatividades.Columns["NombreMateria2"].HeaderText = "Correlativa asignada";

        }

        private void ComboMateriasCC_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        

        private void ComboPEcorr_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            CargarCorrelativas();
        }

        private void ComboConsultaPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias2();
        }
    }
}
