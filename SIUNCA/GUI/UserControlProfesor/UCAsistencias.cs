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

           // this.dgvListadoAlumnos.Columns
        }

        /// <summary>
        /// carga el listado de alumnos para registrar las faltas
        /// </summary>
        //void cargarListaAlumnos()
        //{
        //    var gestoralumno = new GestorAlumno();

        //    var alumnos = gestoralumno.traerAlumnos();

        //    this.dgvRegistrarAsist = null; 
        //    this.dgvRegistrarAsist.DataSource = alumnos;
        //}

    }
}
