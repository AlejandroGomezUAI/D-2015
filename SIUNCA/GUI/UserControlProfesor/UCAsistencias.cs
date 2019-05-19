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

namespace GUI.UserControlProfesor
{
    public partial class UCAsistencias : UserControl
    {
        public UCAsistencias()
        {
            InitializeComponent();
            cargarCboMaterias();
        }

        private void btnGuardarAsist_Click(object sender, EventArgs e)
        {
            
        }

        void cargarListaAlumnos()
        {
            var gestoralumno = new GestorAlumno();

            var alumnos = gestoralumno.traerAlumnos();

            this.dgvRegistrarAsist = null; 
            this.dgvRegistrarAsist.DataSource = alumnos;

        }

        void cargarCboMaterias()
        {
            var gestorMateria = new GestorMateria();
            var materias = gestorMateria.TraerListaMaterias();

            this.cboMateriaRegAsist.DataSource = null;
            this.cboMateriaRegAsist.DataSource = materias;
            this.cboMateriaRegAsist.DisplayMember = "Nombre";

        }
    }
}
