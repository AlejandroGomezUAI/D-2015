namespace GUI.UserControlSecretarioAcademico
{
    partial class UCAlumnos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ComboApellido = new System.Windows.Forms.ComboBox();
            this.ComboNombre = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgAlumMat = new System.Windows.Forms.DataGridView();
            this.btnConsultarCorrelativas = new System.Windows.Forms.Button();
            this.dgCorrelativas = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboCarrera = new System.Windows.Forms.ComboBox();
            this.ComboMaterias1 = new System.Windows.Forms.ComboBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dgCorrelatividades = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ComboMateriasCC = new System.Windows.Forms.ComboBox();
            this.ComboCorrelativas = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorrelativas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorrelatividades)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 638);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.ComboApellido);
            this.tabPage1.Controls.Add(this.ComboNombre);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.dgAlumMat);
            this.tabPage1.Controls.Add(this.btnConsultarCorrelativas);
            this.tabPage1.Controls.Add(this.dgCorrelativas);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ComboCarrera);
            this.tabPage1.Controls.Add(this.ComboMaterias1);
            this.tabPage1.Controls.Add(this.txtAño);
            this.tabPage1.Controls.Add(this.txtLegajo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asignar alumno a materia";
            // 
            // ComboApellido
            // 
            this.ComboApellido.FormattingEnabled = true;
            this.ComboApellido.Location = new System.Drawing.Point(177, 287);
            this.ComboApellido.Name = "ComboApellido";
            this.ComboApellido.Size = new System.Drawing.Size(128, 28);
            this.ComboApellido.TabIndex = 38;
            // 
            // ComboNombre
            // 
            this.ComboNombre.FormattingEnabled = true;
            this.ComboNombre.Location = new System.Drawing.Point(177, 248);
            this.ComboNombre.Name = "ComboNombre";
            this.ComboNombre.Size = new System.Drawing.Size(128, 28);
            this.ComboNombre.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(311, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 36;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(526, 442);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(296, 41);
            this.button8.TabIndex = 35;
            this.button8.Text = "Consultar correlativas";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(526, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(272, 141);
            this.dataGridView1.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Nombre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Obligatoria",
            "Opcional"});
            this.comboBox1.Location = new System.Drawing.Point(198, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 28);
            this.comboBox1.TabIndex = 29;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(526, 517);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(296, 67);
            this.button6.TabIndex = 28;
            this.button6.Text = "Guardar asignaciones";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(339, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 42);
            this.button4.TabIndex = 27;
            this.button4.Text = "Asignar materia";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(339, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 42);
            this.button5.TabIndex = 26;
            this.button5.Text = "Quitar materia";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dgAlumMat
            // 
            this.dgAlumMat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgAlumMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlumMat.Location = new System.Drawing.Point(49, 321);
            this.dgAlumMat.Name = "dgAlumMat";
            this.dgAlumMat.Size = new System.Drawing.Size(376, 263);
            this.dgAlumMat.TabIndex = 23;
            // 
            // btnConsultarCorrelativas
            // 
            this.btnConsultarCorrelativas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultarCorrelativas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarCorrelativas.Location = new System.Drawing.Point(526, 241);
            this.btnConsultarCorrelativas.Name = "btnConsultarCorrelativas";
            this.btnConsultarCorrelativas.Size = new System.Drawing.Size(296, 41);
            this.btnConsultarCorrelativas.TabIndex = 22;
            this.btnConsultarCorrelativas.Text = "Consultar aprobadas";
            this.btnConsultarCorrelativas.UseVisualStyleBackColor = false;
            // 
            // dgCorrelativas
            // 
            this.dgCorrelativas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgCorrelativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCorrelativas.Location = new System.Drawing.Point(526, 94);
            this.dgCorrelativas.Name = "dgCorrelativas";
            this.dgCorrelativas.Size = new System.Drawing.Size(272, 139);
            this.dgCorrelativas.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Carrera";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Plan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Turno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha inicio cursada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Materia (con correlatividad)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Legajo Alumno";
            // 
            // ComboCarrera
            // 
            this.ComboCarrera.FormattingEnabled = true;
            this.ComboCarrera.Location = new System.Drawing.Point(198, 94);
            this.ComboCarrera.Name = "ComboCarrera";
            this.ComboCarrera.Size = new System.Drawing.Size(128, 28);
            this.ComboCarrera.TabIndex = 11;
            // 
            // ComboMaterias1
            // 
            this.ComboMaterias1.FormattingEnabled = true;
            this.ComboMaterias1.Location = new System.Drawing.Point(645, 60);
            this.ComboMaterias1.Name = "ComboMaterias1";
            this.ComboMaterias1.Size = new System.Drawing.Size(121, 28);
            this.ComboMaterias1.TabIndex = 8;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(198, 175);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(107, 26);
            this.txtAño.TabIndex = 5;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(198, 62);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(107, 26);
            this.txtLegajo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignacion de alumno a materias";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.dgCorrelatividades);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.ComboMateriasCC);
            this.tabPage2.Controls.Add(this.ComboCorrelativas);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asignar Correlativas";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(165, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(404, 77);
            this.button2.TabIndex = 50;
            this.button2.Text = "Guardar correlatividades";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(589, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 42);
            this.button3.TabIndex = 49;
            this.button3.Text = "Agregar correlativa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(589, 218);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(179, 42);
            this.button7.TabIndex = 48;
            this.button7.Text = "Quitar correlativa";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // dgCorrelatividades
            // 
            this.dgCorrelatividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgCorrelatividades.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgCorrelatividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCorrelatividades.Location = new System.Drawing.Point(165, 160);
            this.dgCorrelatividades.Name = "dgCorrelatividades";
            this.dgCorrelatividades.Size = new System.Drawing.Size(404, 237);
            this.dgCorrelatividades.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Seleccione materia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(360, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Seleccione su correlativa";
            // 
            // ComboMateriasCC
            // 
            this.ComboMateriasCC.FormattingEnabled = true;
            this.ComboMateriasCC.Location = new System.Drawing.Point(202, 109);
            this.ComboMateriasCC.Name = "ComboMateriasCC";
            this.ComboMateriasCC.Size = new System.Drawing.Size(121, 28);
            this.ComboMateriasCC.TabIndex = 35;
            // 
            // ComboCorrelativas
            // 
            this.ComboCorrelativas.FormattingEnabled = true;
            this.ComboCorrelativas.Location = new System.Drawing.Point(448, 112);
            this.ComboCorrelativas.Name = "ComboCorrelativas";
            this.ComboCorrelativas.Size = new System.Drawing.Size(121, 28);
            this.ComboCorrelativas.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(219, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Asignación de correlativas";
            // 
            // UCAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UCAlumnos";
            this.Size = new System.Drawing.Size(854, 638);
            this.Load += new System.EventHandler(this.UCAlumnos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorrelativas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorrelatividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgAlumMat;
        private System.Windows.Forms.Button btnConsultarCorrelativas;
        private System.Windows.Forms.DataGridView dgCorrelativas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboCarrera;
        private System.Windows.Forms.ComboBox ComboMaterias1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dgCorrelatividades;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ComboMateriasCC;
        private System.Windows.Forms.ComboBox ComboCorrelativas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboNombre;
        private System.Windows.Forms.ComboBox ComboApellido;
    }
}
