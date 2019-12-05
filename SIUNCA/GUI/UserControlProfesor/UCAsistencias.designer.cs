namespace GUI.UserControlProfesor
{
    partial class UCAsistencias
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TCAsistencias = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbListaDeAlumnos = new System.Windows.Forms.GroupBox();
            this.dgvListadoAlumnos = new System.Windows.Forms.DataGridView();
            this.gbSeleccionDeMateria = new System.Windows.Forms.GroupBox();
            this.btnSelMateriaAsistencia = new System.Windows.Forms.Button();
            this.cboMateriaAsist = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnGuardarAsist = new System.Windows.Forms.Button();
            this.gbListadoDeAlu = new System.Windows.Forms.GroupBox();
            this.dgvRegistrarAsist = new System.Windows.Forms.DataGridView();
            this.Asistencia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gbSelDeMat = new System.Windows.Forms.GroupBox();
            this.btnSelMateriaAsist = new System.Windows.Forms.Button();
            this.cboMateriaRegAsist = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModificarAsistencia = new System.Windows.Forms.Button();
            this.cboModificarAsistencia = new System.Windows.Forms.ComboBox();
            this.dgvListadoAsistenciaModificar = new System.Windows.Forms.DataGridView();
            this.Asistencia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListadoAlumnosModificar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelModAsistencia = new System.Windows.Forms.Button();
            this.cboSelModAsistencia = new System.Windows.Forms.ComboBox();
            this.TCAsistencias.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbListaDeAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).BeginInit();
            this.gbSeleccionDeMateria.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbListadoDeAlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarAsist)).BeginInit();
            this.gbSelDeMat.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAsistenciaModificar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnosModificar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCAsistencias
            // 
            this.TCAsistencias.Controls.Add(this.tabPage1);
            this.TCAsistencias.Controls.Add(this.tabPage2);
            this.TCAsistencias.Controls.Add(this.tabPage3);
            this.TCAsistencias.Location = new System.Drawing.Point(3, 3);
            this.TCAsistencias.Name = "TCAsistencias";
            this.TCAsistencias.SelectedIndex = 0;
            this.TCAsistencias.Size = new System.Drawing.Size(853, 483);
            this.TCAsistencias.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbListaDeAlumnos);
            this.tabPage1.Controls.Add(this.gbSeleccionDeMateria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Acta de asistencias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbListaDeAlumnos
            // 
            this.gbListaDeAlumnos.Controls.Add(this.dgvListadoAlumnos);
            this.gbListaDeAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbListaDeAlumnos.Location = new System.Drawing.Point(267, 26);
            this.gbListaDeAlumnos.Name = "gbListaDeAlumnos";
            this.gbListaDeAlumnos.Size = new System.Drawing.Size(559, 368);
            this.gbListaDeAlumnos.TabIndex = 5;
            this.gbListaDeAlumnos.TabStop = false;
            this.gbListaDeAlumnos.Text = "Listado de alumnos";
            // 
            // dgvListadoAlumnos
            // 
            this.dgvListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAlumnos.Location = new System.Drawing.Point(22, 30);
            this.dgvListadoAlumnos.Name = "dgvListadoAlumnos";
            this.dgvListadoAlumnos.Size = new System.Drawing.Size(518, 319);
            this.dgvListadoAlumnos.TabIndex = 0;
            // 
            // gbSeleccionDeMateria
            // 
            this.gbSeleccionDeMateria.Controls.Add(this.btnSelMateriaAsistencia);
            this.gbSeleccionDeMateria.Controls.Add(this.cboMateriaAsist);
            this.gbSeleccionDeMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSeleccionDeMateria.Location = new System.Drawing.Point(20, 26);
            this.gbSeleccionDeMateria.Name = "gbSeleccionDeMateria";
            this.gbSeleccionDeMateria.Size = new System.Drawing.Size(218, 231);
            this.gbSeleccionDeMateria.TabIndex = 4;
            this.gbSeleccionDeMateria.TabStop = false;
            this.gbSeleccionDeMateria.Text = "Seleccion de materia";
            // 
            // btnSelMateriaAsistencia
            // 
            this.btnSelMateriaAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelMateriaAsistencia.Location = new System.Drawing.Point(66, 149);
            this.btnSelMateriaAsistencia.Name = "btnSelMateriaAsistencia";
            this.btnSelMateriaAsistencia.Size = new System.Drawing.Size(75, 23);
            this.btnSelMateriaAsistencia.TabIndex = 1;
            this.btnSelMateriaAsistencia.Text = "Seleccionar";
            this.btnSelMateriaAsistencia.UseVisualStyleBackColor = true;
            this.btnSelMateriaAsistencia.Click += new System.EventHandler(this.btnSelMateriaAsistencia_Click);
            // 
            // cboMateriaAsist
            // 
            this.cboMateriaAsist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMateriaAsist.FormattingEnabled = true;
            this.cboMateriaAsist.Location = new System.Drawing.Point(36, 56);
            this.cboMateriaAsist.Name = "cboMateriaAsist";
            this.cboMateriaAsist.Size = new System.Drawing.Size(148, 21);
            this.cboMateriaAsist.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblFechaActual);
            this.tabPage2.Controls.Add(this.lblFecha);
            this.tabPage2.Controls.Add(this.btnGuardarAsist);
            this.tabPage2.Controls.Add(this.gbListadoDeAlu);
            this.tabPage2.Controls.Add(this.gbSelDeMat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar asistencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(719, 10);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(35, 13);
            this.lblFechaActual.TabIndex = 14;
            this.lblFechaActual.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(676, 10);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            // 
            // btnGuardarAsist
            // 
            this.btnGuardarAsist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAsist.Location = new System.Drawing.Point(733, 409);
            this.btnGuardarAsist.Name = "btnGuardarAsist";
            this.btnGuardarAsist.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAsist.TabIndex = 11;
            this.btnGuardarAsist.Text = "Guardar";
            this.btnGuardarAsist.UseVisualStyleBackColor = true;
            this.btnGuardarAsist.Click += new System.EventHandler(this.btnGuardarAsist_Click);
            // 
            // gbListadoDeAlu
            // 
            this.gbListadoDeAlu.Controls.Add(this.dgvRegistrarAsist);
            this.gbListadoDeAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbListadoDeAlu.Location = new System.Drawing.Point(268, 26);
            this.gbListadoDeAlu.Name = "gbListadoDeAlu";
            this.gbListadoDeAlu.Size = new System.Drawing.Size(559, 368);
            this.gbListadoDeAlu.TabIndex = 9;
            this.gbListadoDeAlu.TabStop = false;
            this.gbListadoDeAlu.Text = "Listado de alumnos";
            // 
            // dgvRegistrarAsist
            // 
            this.dgvRegistrarAsist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarAsist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asistencia});
            this.dgvRegistrarAsist.Location = new System.Drawing.Point(22, 30);
            this.dgvRegistrarAsist.Name = "dgvRegistrarAsist";
            this.dgvRegistrarAsist.Size = new System.Drawing.Size(518, 319);
            this.dgvRegistrarAsist.TabIndex = 0;
            // 
            // Asistencia
            // 
            this.Asistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.Items.AddRange(new object[] {
            "Presente",
            "Ausente"});
            this.Asistencia.Name = "Asistencia";
            // 
            // gbSelDeMat
            // 
            this.gbSelDeMat.Controls.Add(this.btnSelMateriaAsist);
            this.gbSelDeMat.Controls.Add(this.cboMateriaRegAsist);
            this.gbSelDeMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSelDeMat.Location = new System.Drawing.Point(21, 26);
            this.gbSelDeMat.Name = "gbSelDeMat";
            this.gbSelDeMat.Size = new System.Drawing.Size(218, 231);
            this.gbSelDeMat.TabIndex = 8;
            this.gbSelDeMat.TabStop = false;
            this.gbSelDeMat.Text = "Seleccion de materia";
            // 
            // btnSelMateriaAsist
            // 
            this.btnSelMateriaAsist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelMateriaAsist.Location = new System.Drawing.Point(66, 149);
            this.btnSelMateriaAsist.Name = "btnSelMateriaAsist";
            this.btnSelMateriaAsist.Size = new System.Drawing.Size(75, 23);
            this.btnSelMateriaAsist.TabIndex = 1;
            this.btnSelMateriaAsist.Text = "Seleccionar";
            this.btnSelMateriaAsist.UseVisualStyleBackColor = true;
            this.btnSelMateriaAsist.Click += new System.EventHandler(this.btnSelMateriaAsist_Click);
            // 
            // cboMateriaRegAsist
            // 
            this.cboMateriaRegAsist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMateriaRegAsist.FormattingEnabled = true;
            this.cboMateriaRegAsist.Location = new System.Drawing.Point(36, 56);
            this.cboMateriaRegAsist.Name = "cboMateriaRegAsist";
            this.cboMateriaRegAsist.Size = new System.Drawing.Size(148, 21);
            this.cboMateriaRegAsist.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(845, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar asistencia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnModificarAsistencia);
            this.groupBox3.Controls.Add(this.cboModificarAsistencia);
            this.groupBox3.Controls.Add(this.dgvListadoAsistenciaModificar);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(241, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 198);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asistencias del alumno  seleccionado";
            // 
            // btnModificarAsistencia
            // 
            this.btnModificarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAsistencia.Location = new System.Drawing.Point(435, 123);
            this.btnModificarAsistencia.Name = "btnModificarAsistencia";
            this.btnModificarAsistencia.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAsistencia.TabIndex = 12;
            this.btnModificarAsistencia.Text = "Modificar";
            this.btnModificarAsistencia.UseVisualStyleBackColor = true;
            this.btnModificarAsistencia.Click += new System.EventHandler(this.btnModificarAsistencia_Click);
            // 
            // cboModificarAsistencia
            // 
            this.cboModificarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboModificarAsistencia.FormattingEnabled = true;
            this.cboModificarAsistencia.Items.AddRange(new object[] {
            "Presente",
            "Ausente"});
            this.cboModificarAsistencia.Location = new System.Drawing.Point(400, 19);
            this.cboModificarAsistencia.Name = "cboModificarAsistencia";
            this.cboModificarAsistencia.Size = new System.Drawing.Size(148, 21);
            this.cboModificarAsistencia.TabIndex = 2;
            // 
            // dgvListadoAsistenciaModificar
            // 
            this.dgvListadoAsistenciaModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAsistenciaModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asistencia1});
            this.dgvListadoAsistenciaModificar.Location = new System.Drawing.Point(25, 19);
            this.dgvListadoAsistenciaModificar.Name = "dgvListadoAsistenciaModificar";
            this.dgvListadoAsistenciaModificar.Size = new System.Drawing.Size(360, 173);
            this.dgvListadoAsistenciaModificar.TabIndex = 0;
            this.dgvListadoAsistenciaModificar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoAsistenciaModificar_CellClick);
            // 
            // Asistencia1
            // 
            this.Asistencia1.HeaderText = "Asistencia";
            this.Asistencia1.Name = "Asistencia1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListadoAlumnosModificar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(244, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 225);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccion de alumno";
            // 
            // dgvListadoAlumnosModificar
            // 
            this.dgvListadoAlumnosModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAlumnosModificar.Location = new System.Drawing.Point(22, 19);
            this.dgvListadoAlumnosModificar.Name = "dgvListadoAlumnosModificar";
            this.dgvListadoAlumnosModificar.Size = new System.Drawing.Size(360, 200);
            this.dgvListadoAlumnosModificar.TabIndex = 0;
            this.dgvListadoAlumnosModificar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoAlumnosModificar_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelModAsistencia);
            this.groupBox1.Controls.Add(this.cboSelModAsistencia);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(41, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 225);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de materia";
            // 
            // btnSelModAsistencia
            // 
            this.btnSelModAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelModAsistencia.Location = new System.Drawing.Point(58, 149);
            this.btnSelModAsistencia.Name = "btnSelModAsistencia";
            this.btnSelModAsistencia.Size = new System.Drawing.Size(75, 23);
            this.btnSelModAsistencia.TabIndex = 1;
            this.btnSelModAsistencia.Text = "Seleccionar";
            this.btnSelModAsistencia.UseVisualStyleBackColor = true;
            this.btnSelModAsistencia.Click += new System.EventHandler(this.btnSelModAsistencia_Click);
            // 
            // cboSelModAsistencia
            // 
            this.cboSelModAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSelModAsistencia.FormattingEnabled = true;
            this.cboSelModAsistencia.Location = new System.Drawing.Point(22, 19);
            this.cboSelModAsistencia.Name = "cboSelModAsistencia";
            this.cboSelModAsistencia.Size = new System.Drawing.Size(148, 21);
            this.cboSelModAsistencia.TabIndex = 1;
            // 
            // UCAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCAsistencias);
            this.Name = "UCAsistencias";
            this.Size = new System.Drawing.Size(856, 489);
            this.TCAsistencias.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbListaDeAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).EndInit();
            this.gbSeleccionDeMateria.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbListadoDeAlu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarAsist)).EndInit();
            this.gbSelDeMat.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAsistenciaModificar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnosModificar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCAsistencias;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbListaDeAlumnos;
        private System.Windows.Forms.DataGridView dgvListadoAlumnos;
        private System.Windows.Forms.GroupBox gbSeleccionDeMateria;
        private System.Windows.Forms.Button btnSelMateriaAsistencia;
        private System.Windows.Forms.ComboBox cboMateriaAsist;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGuardarAsist;
        private System.Windows.Forms.GroupBox gbListadoDeAlu;
        private System.Windows.Forms.DataGridView dgvRegistrarAsist;
        private System.Windows.Forms.GroupBox gbSelDeMat;
        private System.Windows.Forms.Button btnSelMateriaAsist;
        private System.Windows.Forms.ComboBox cboMateriaRegAsist;
        private System.Windows.Forms.DataGridViewComboBoxColumn Asistencia;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModificarAsistencia;
        private System.Windows.Forms.ComboBox cboModificarAsistencia;
        private System.Windows.Forms.DataGridView dgvListadoAsistenciaModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencia1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListadoAlumnosModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelModAsistencia;
        private System.Windows.Forms.ComboBox cboSelModAsistencia;
    }
}
