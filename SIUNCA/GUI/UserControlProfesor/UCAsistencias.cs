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
using BIZ.DTOs;
using BLL;
using System.Threading;
using System.Globalization;
using GUI.Idiomas.Profesor.Asistencia;
using Framework.D_2015.Idiomas;
using Framework.D_2015.Cache;


namespace GUI.UserControlProfesor
{
    public partial class UCAsistencias : UserControl
    {
        public UCAsistencias()
        {
            InitializeComponent();
            cargarCboMaterias();
            lblFechaActual.Text = DateTime.Now.ToShortDateString();

            Idioma.cambiarIdioma(Idioma.cacheIdioma, IdiomaPorDefecto);

            validarBtnGuardarAsistencia();
        }

        private void btnSelMateriaAsistencia_Click(object sender, EventArgs e)
        {
            cargarActaDeasistencias();
        }

        private void btnSelMateriaAsist_Click(object sender, EventArgs e)
        {
            cargarListaAlumnos();

            validarBtnGuardarAsistencia();
        }

        private void btnGuardarAsist_Click(object sender, EventArgs e)
        {
            guardarRegistroAsistencia();
        }

        /// <summary>
        /// Carga el ComboBox con las materias registradas en la BD correspondientes a cada profesor
        /// usando el iduser del login
        /// </summary>
        void cargarCboMaterias()
        {
            var gestorMateriacc = new GestorMateriaCC();
            var materiascc = gestorMateriacc.TraerListaMateriasCC(CacheUsuario.iduser);

            cboMateriaAsist.DataSource = null;
            cboMateriaAsist.DataSource = materiascc;
            cboMateriaAsist.ValueMember = "IdMateriaCC";
            cboMateriaAsist.DisplayMember = "Nombre";

            cboMateriaRegAsist.DataSource = null;
            cboMateriaRegAsist.DataSource = materiascc;
            cboMateriaRegAsist.ValueMember = "IdMateriaCC";
            cboMateriaRegAsist.DisplayMember = "Nombre";

            cboSelModAsistencia.DataSource = null;
            cboSelModAsistencia.DataSource = materiascc;
            cboSelModAsistencia.ValueMember = "IdMateriaCC";
            cboSelModAsistencia.DisplayMember = "Nombre";
        }

        /// <summary>
        /// Carga el listado de alumnos del acta de asistencias
        /// en base al combobox de las Materias seleccionado
        /// </summary>
        void cargarActaDeasistencias()
        {
            var gestorAlumno = new GestorAlumno();
            var alumnos = gestorAlumno.traerAlumnos((int)cboMateriaAsist.SelectedValue);

            dgvListadoAlumnos.DataSource = null;
            dgvListadoAlumnos.DataSource = alumnos;

            //oculta columna IdMateriaCC
            dgvListadoAlumnos.Columns[6].Visible = false;
            //Modifica el nombre de las columnas
            dgvListadoAlumnos.Columns[0].HeaderText = "Legajo";
            dgvListadoAlumnos.Columns[3].HeaderText = "Ausentes";
            dgvListadoAlumnos.Columns[4].HeaderText = "Presentes";

            colorFilaActaDeAsistencia();
        }

        /// <summary>
        /// carga el listado de alumnos para registrar las faltas
        /// </summary>
        void cargarListaAlumnos()
        {
            var gestoralumno = new GestorAlumno();
            var alumnos = gestoralumno.traerAlumnos((int)cboMateriaRegAsist.SelectedValue);

            dgvRegistrarAsist.DataSource = null;
            dgvRegistrarAsist.DataSource = alumnos;

            //Modifica el nombre de la columna LegajoAlumno
            dgvRegistrarAsist.Columns[1].HeaderText = "Legajo";

            //Modificacion del orden de las columnas
            dgvRegistrarAsist.Columns["Asistencia"].DisplayIndex = 3;

            //oculta columna Ausentes, Presentes,  Estado, IdMAteriaCC 
            dgvRegistrarAsist.Columns[4].Visible = false;
            dgvRegistrarAsist.Columns[5].Visible = false;
            dgvRegistrarAsist.Columns[6].Visible = false;
            dgvRegistrarAsist.Columns[7].Visible = false;

            colorFilaRegistrarAsistencia();
        }

        void guardarRegistroAsistencia()
        {
            var listadoAsistencia = new List<Asistencia>();

            foreach (DataGridViewRow row in this.dgvRegistrarAsist.Rows)
            {
                var asistencia = new Asistencia();

                asistencia.LegajoAlumno = (int)row.Cells["LegajoAlumno"].Value;
                asistencia.IdMateriaCC = (int)row.Cells["IdMAteriaCC"].Value;

                if (row.Cells["Asistencia"].Value?.ToString() == null)
                {
                    asistencia.Presente = "0";
                    asistencia.Ausente = "0";
                }
                else if (row.Cells["Asistencia"].Value.ToString() == "Presente")
                {
                    asistencia.Presente = "1";
                    asistencia.Ausente = "0";
                }
                else if (row.Cells["Asistencia"].Value.ToString() == "Ausente")
                {
                    asistencia.Presente = "0";
                    asistencia.Ausente = "1";
                }
                

                asistencia.Fecha = DateTime.Today;

                listadoAsistencia.Add(asistencia);
            }

            var gestorAsistencia = new GestorAsistencia();

            gestorAsistencia.guardarAsistencia(listadoAsistencia);

            MessageBox.Show("El registro de asistencias ha sido completado satisfactoriamente");
        }

        /// <summary>
        /// Cambia el color de una fila si las celdas de la columna "Ausente" son mayor igual a 4
        /// </summary>
        void colorFilaActaDeAsistencia()
        {
            for (int i = 0; i < dgvListadoAlumnos.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvListadoAlumnos.Rows[i].Cells["Ausente"].Value.ToString()) >= 4)
                {
                    dgvListadoAlumnos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// Cambia el color de una fila si las celdas de la columna "Ausente" son mayor igual a 4,
        /// tambien desactiva la celda para que no se puedan agregar asistencias
        /// </summary>
        void colorFilaRegistrarAsistencia()
        {
            for (int i = 0; i < dgvRegistrarAsist.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvRegistrarAsist.Rows[i].Cells["Ausente"].Value.ToString()) >= 4)
                {
                    dgvRegistrarAsist.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgvRegistrarAsist.Rows[i].ReadOnly = true;
                }
            }
        }

        void IdiomaPorDefecto()
        {
            btnSelMateriaAsist.Text = Res.btnSelMateriaAsistencia;
            lblFecha.Text = Res.lblFecha;
            gbListaDeAlumnos.Text = Res.gbListaDeAlumnos;
            gbSeleccionDeMateria.Text = Res.gbSeleccionDeMateria;
            btnGuardarAsist.Text = Res.btnGuardarAsist;
            //btnCancelarAsist.Text = Res.btnCancelarAsist;
            //btnModificarAsist.Text = Res.btnModificarAsist;
            gbListadoDeAlu.Text = Res.gbListadoDeAlu;
            gbSelDeMat.Text = Res.gbSelDeMat;
            btnSelMateriaAsistencia.Text = Res.btnSelMateriaAsistencia;
        }

        void validarBtnGuardarAsistencia()
        {
            if (dgvRegistrarAsist.DataSource == null)
            {
                btnGuardarAsist.Enabled = false;
            }
            else
            {
                //Activa o desactiva btnguardarasist
                var gestorAsistencia = new GestorAsistencia();
                btnGuardarAsist.Enabled = gestorAsistencia.validarFecha((int)cboMateriaRegAsist.SelectedValue);
            }  
        }

        private void btnSelModAsistencia_Click(object sender, EventArgs e)
        {
            cargarActaDeasistenciasModificar();
        }

        void cargarActaDeasistenciasModificar()
        {
            var gestorAlumno = new GestorAlumno();
            var alumnos = gestorAlumno.traerAlumnos((int)cboSelModAsistencia.SelectedValue);

            dgvListadoAlumnosModificar.DataSource = null;
            dgvListadoAlumnosModificar.DataSource = alumnos;

            //Modifica el nombre de la columna LegajoAlumno
            dgvListadoAlumnosModificar.Columns[0].HeaderText = "Legajo";

            //oculta las columnas
            dgvListadoAlumnosModificar.Columns[3].Visible = false;
            dgvListadoAlumnosModificar.Columns[4].Visible = false;
            dgvListadoAlumnosModificar.Columns[5].Visible = false;
            dgvListadoAlumnosModificar.Columns[6].Visible = false;

        }

        private void dgvListadoAlumnosModificar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CacheAsistencia.LegajoAlumno = (int)dgvListadoAlumnosModificar.Rows[e.RowIndex].Cells["LegajoAlumno"].Value;
            CacheAsistencia.IdMateriaCC = (int)dgvListadoAlumnosModificar.Rows[e.RowIndex].Cells["IdMateriaCC"].Value;
            
            cargarListadoAsistenciaDeAlumno(CacheAsistencia.LegajoAlumno, CacheAsistencia.IdMateriaCC);
            agregarStringDeAsistencia();
        }

        /// <summary>
        /// le agrega al campo Asistencia1 del dgv "Presente" o "Ausente"
        /// </summary>
        void agregarStringDeAsistencia()
        {
            for (int i = 0; i < dgvListadoAsistenciaModificar.Rows.Count; i++)
            {
                var presente = Convert.ToInt32(dgvListadoAsistenciaModificar.Rows[i].Cells["Presente"].Value.ToString());
                var ausente = Convert.ToInt32(dgvListadoAsistenciaModificar.Rows[i].Cells["Ausente"].Value.ToString());

                if (presente == 1 && ausente == 0)
                {
                    dgvListadoAsistenciaModificar.Rows[i].Cells["Asistencia1"].Value = "Presente";
                }
                else
                {
                    dgvListadoAsistenciaModificar.Rows[i].Cells["Asistencia1"].Value = "Ausente";
                }
            }
        }

        void cargarListadoAsistenciaDeAlumno(int LegajoAlumno, int IdMateriaCC)
        {
            var gestorAsistencia = new GestorAsistencia();
            var asistencias = gestorAsistencia.traerAsistencias(LegajoAlumno, IdMateriaCC);

            dgvListadoAsistenciaModificar.DataSource = null;
            dgvListadoAsistenciaModificar.DataSource = asistencias;

            //Modificacion del orden de las columnas
            dgvListadoAsistenciaModificar.Columns["Asistencia1"].DisplayIndex = 2;

            //oculta las columnas
            dgvListadoAsistenciaModificar.Columns[1].Visible = false;
            dgvListadoAsistenciaModificar.Columns[3].Visible = false;
            dgvListadoAsistenciaModificar.Columns[4].Visible = false;
            dgvListadoAsistenciaModificar.Columns[5].Visible = false;
            dgvListadoAsistenciaModificar.Columns[6].Visible = false;
            dgvListadoAsistenciaModificar.Columns[7].Visible = false;
            dgvListadoAsistenciaModificar.Columns[8].Visible = false;
            dgvListadoAsistenciaModificar.Columns[9].Visible = false;
            dgvListadoAsistenciaModificar.Columns[10].Visible = false;
        }

        private void dgvListadoAsistenciaModificar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CacheAsistencia.IdAsistencia = Convert.ToInt32(dgvListadoAsistenciaModificar.Rows[e.RowIndex].Cells["IdAsistencia"].Value);

            var ausente = Convert.ToInt32(dgvListadoAsistenciaModificar.Rows[e.RowIndex].Cells["Ausente"].Value);
            var presente = Convert.ToInt32(dgvListadoAsistenciaModificar.Rows[e.RowIndex].Cells["Presente"].Value);

            if (ausente == 0 && presente == 1)
            {
                cboModificarAsistencia.SelectedIndex = 1;
            }
            else
            {
                cboModificarAsistencia.SelectedIndex = 0;
            }
        }

        private void btnModificarAsistencia_Click(object sender, EventArgs e)
        {
            var asistencia = cboModificarAsistencia.SelectedIndex;

            var gestorAsistencia = new GestorAsistencia();
            gestorAsistencia.modificarAsistencia(asistencia, CacheAsistencia.IdAsistencia);

            DialogResult res = MessageBox.Show($"La asistencia del alumno sera modificada a {cboModificarAsistencia.SelectedItem.ToString()}", "Modificacion", MessageBoxButtons.OKCancel);

            if (res == DialogResult.OK)
            {
                //refresca el dgvListadoAsistenciaModificar para que se vea la modificacion realizada por el usuario
                cargarListadoAsistenciaDeAlumno(CacheAsistencia.LegajoAlumno, CacheAsistencia.IdMateriaCC);
                agregarStringDeAsistencia();
            }
            else
            {
                MessageBox.Show("La modificacion ha sido cancelada");
            }
        }

    }
}
