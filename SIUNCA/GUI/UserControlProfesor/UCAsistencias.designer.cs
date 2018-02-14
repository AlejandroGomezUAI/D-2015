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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListadoAlumnos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelMateriaAsistencia = new System.Windows.Forms.Button();
            this.cboMateriaAsist = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuardarAsist = new System.Windows.Forms.Button();
            this.btnCancelarAsist = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvRegistrarAsist = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelMateriaAsist = new System.Windows.Forms.Button();
            this.cboMateriaRegAsist = new System.Windows.Forms.ComboBox();
            this.btnModificarAsist = new System.Windows.Forms.Button();
            this.TCAsistencias.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarAsist)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCAsistencias
            // 
            this.TCAsistencias.Controls.Add(this.tabPage1);
            this.TCAsistencias.Controls.Add(this.tabPage2);
            this.TCAsistencias.Location = new System.Drawing.Point(3, 3);
            this.TCAsistencias.Name = "TCAsistencias";
            this.TCAsistencias.SelectedIndex = 0;
            this.TCAsistencias.Size = new System.Drawing.Size(853, 483);
            this.TCAsistencias.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Acta de asistencias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListadoAlumnos);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(267, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 368);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de alumnos";
            // 
            // dgvListadoAlumnos
            // 
            this.dgvListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAlumnos.Location = new System.Drawing.Point(22, 30);
            this.dgvListadoAlumnos.Name = "dgvListadoAlumnos";
            this.dgvListadoAlumnos.Size = new System.Drawing.Size(518, 319);
            this.dgvListadoAlumnos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelMateriaAsistencia);
            this.groupBox1.Controls.Add(this.cboMateriaAsist);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(20, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 231);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de materia";
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
            this.tabPage2.Controls.Add(this.btnModificarAsist);
            this.tabPage2.Controls.Add(this.btnGuardarAsist);
            this.tabPage2.Controls.Add(this.btnCancelarAsist);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar asistencias";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // 
            // btnCancelarAsist
            // 
            this.btnCancelarAsist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAsist.Location = new System.Drawing.Point(633, 409);
            this.btnCancelarAsist.Name = "btnCancelarAsist";
            this.btnCancelarAsist.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAsist.TabIndex = 10;
            this.btnCancelarAsist.Text = "Cancelar";
            this.btnCancelarAsist.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvRegistrarAsist);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(268, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 368);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de alumnos";
            // 
            // dgvRegistrarAsist
            // 
            this.dgvRegistrarAsist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarAsist.Location = new System.Drawing.Point(22, 30);
            this.dgvRegistrarAsist.Name = "dgvRegistrarAsist";
            this.dgvRegistrarAsist.Size = new System.Drawing.Size(518, 319);
            this.dgvRegistrarAsist.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSelMateriaAsist);
            this.groupBox4.Controls.Add(this.cboMateriaRegAsist);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(21, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 231);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccion de materia";
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
            // btnModificarAsist
            // 
            this.btnModificarAsist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAsist.Location = new System.Drawing.Point(530, 409);
            this.btnModificarAsist.Name = "btnModificarAsist";
            this.btnModificarAsist.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAsist.TabIndex = 12;
            this.btnModificarAsist.Text = "Modificar";
            this.btnModificarAsist.UseVisualStyleBackColor = true;
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarAsist)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCAsistencias;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListadoAlumnos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelMateriaAsistencia;
        private System.Windows.Forms.ComboBox cboMateriaAsist;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGuardarAsist;
        private System.Windows.Forms.Button btnCancelarAsist;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvRegistrarAsist;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSelMateriaAsist;
        private System.Windows.Forms.ComboBox cboMateriaRegAsist;
        private System.Windows.Forms.Button btnModificarAsist;
    }
}
