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

namespace GUI.UserControlProfesor
{
    public partial class UCAsistencias : UserControl
    {
        public UCAsistencias()
        {
            InitializeComponent();
            
            cargarCboMaterias();
        }

        private void btnSelMateriaAsistencia_Click(object sender, EventArgs e)
        {
            cargarActaDeasistencias();
        }

        private void btnSelMateriaAsist_Click(object sender, EventArgs e)
        {
            cargarListaAlumnos();
        }

        private void btnGuardarAsist_Click(object sender, EventArgs e)
        {
            
        }      
        
        /// <summary>
        /// Carga el ComboBox con las materias registradas en la BD
        /// </summary>
        void cargarCboMaterias()
        {
            var gestorMateriacc = new GestorMateriaCC();
            var materiascc = gestorMateriacc.TraerListaMateriasCC();

            this.cboMateriaAsist.DataSource = null;
            this.cboMateriaAsist.DataSource = materiascc;
            this.cboMateriaAsist.DisplayMember = "Nombre";

            this.cboMateriaRegAsist.DataSource = null;
            this.cboMateriaRegAsist.DataSource = materiascc;
            this.cboMateriaRegAsist.DisplayMember = "Nombre";
        }

        /// <summary>
        /// Carga el listado de alumnos del acta de asistencias
        /// en base al combobox de las Materias seleccionado
        /// </summary>
        void cargarActaDeasistencias()
        {
            var gestorAlumno = new GestorAlumno();
            var alumnos = gestorAlumno.traerAlumnos(this.cboMateriaAsist.Text);

            this.dgvListadoAlumnos.DataSource = null;
            this.dgvListadoAlumnos.DataSource = alumnos;

            //oculta columna IdMateriaCC
            this.dgvListadoAlumnos.Columns[6].Visible = false;
            //Modifica el nombre de las columnas
            this.dgvListadoAlumnos.Columns[0].HeaderText = "Legajo";
            this.dgvListadoAlumnos.Columns[3].HeaderText = "Ausentes";
            this.dgvListadoAlumnos.Columns[4].HeaderText = "Presentes";
        }

        /// <summary>
        /// carga el listado de alumnos para registrar las faltas
        /// </summary>
        void cargarListaAlumnos()
        {
            var gestoralumno = new GestorAlumno();
            var alumnos = gestoralumno.traerAlumnos(this.cboMateriaRegAsist.Text);
            
            this.dgvRegistrarAsist.DataSource = null;
            this.dgvRegistrarAsist.DataSource = alumnos;

            //oculta columna IdMateriaCC, Estado, Ausentes y Presentes
            this.dgvRegistrarAsist.Columns[3].Visible = false;
            this.dgvRegistrarAsist.Columns[4].Visible = false;
            this.dgvRegistrarAsist.Columns[5].Visible = false;
            this.dgvRegistrarAsist.Columns[6].Visible = false;
                        
            //Modifica el nombre de la columna LegajoAlumno
            this.dgvRegistrarAsist.Columns[0].HeaderText = "Legajo";
            
        }

        
    }
}
