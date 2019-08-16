using GUI.UserControlSecretarioAcademico;
namespace GUI.UserControlSecretarioAcademico
{
    partial class UCPlanDeEstudio
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
            this.dgPEMaterias = new System.Windows.Forms.DataGridView();
            this.btnConsultarCorrelativas = new System.Windows.Forms.Button();
            this.btnAsignarCorrelativas = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboMaterias1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.btnGuardarPE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroMateria = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.ComboObligatoriedad = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgCorrelatividades = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboMateriasCC = new System.Windows.Forms.ComboBox();
            this.ComboPEcorr = new System.Windows.Forms.ComboBox();
            this.ComboCorrelativas = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgConsultaCorrelativas = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ComboConsultaMateria = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ComboConsultaPlan = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPEMaterias)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorrelatividades)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaCorrelativas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 638);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.dgPEMaterias);
            this.tabPage1.Controls.Add(this.btnConsultarCorrelativas);
            this.tabPage1.Controls.Add(this.btnAsignarCorrelativas);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ComboMaterias1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Plan de estudio";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgPEMaterias
            // 
            this.dgPEMaterias.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgPEMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPEMaterias.Location = new System.Drawing.Point(49, 321);
            this.dgPEMaterias.Name = "dgPEMaterias";
            this.dgPEMaterias.Size = new System.Drawing.Size(536, 263);
            this.dgPEMaterias.TabIndex = 23;
            // 
            // btnConsultarCorrelativas
            // 
            this.btnConsultarCorrelativas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultarCorrelativas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarCorrelativas.Location = new System.Drawing.Point(470, 184);
            this.btnConsultarCorrelativas.Name = "btnConsultarCorrelativas";
            this.btnConsultarCorrelativas.Size = new System.Drawing.Size(296, 84);
            this.btnConsultarCorrelativas.TabIndex = 22;
            this.btnConsultarCorrelativas.Text = "Consultar correlativas";
            this.btnConsultarCorrelativas.UseVisualStyleBackColor = false;
            this.btnConsultarCorrelativas.Click += new System.EventHandler(this.btnConsultarCorrelativas_Click);
            // 
            // btnAsignarCorrelativas
            // 
            this.btnAsignarCorrelativas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAsignarCorrelativas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignarCorrelativas.Location = new System.Drawing.Point(470, 94);
            this.btnAsignarCorrelativas.Name = "btnAsignarCorrelativas";
            this.btnAsignarCorrelativas.Size = new System.Drawing.Size(296, 84);
            this.btnAsignarCorrelativas.TabIndex = 21;
            this.btnAsignarCorrelativas.Text = "Asignar correlativas a una materia";
            this.btnAsignarCorrelativas.UseVisualStyleBackColor = false;
            this.btnAsignarCorrelativas.Click += new System.EventHandler(this.btnAsignarCorrelativas_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Carga Horaria";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Obligatoriedad";
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
            // ComboMaterias1
            // 
            this.ComboMaterias1.FormattingEnabled = true;
            this.ComboMaterias1.Location = new System.Drawing.Point(645, 60);
            this.ComboMaterias1.Name = "ComboMaterias1";
            this.ComboMaterias1.Size = new System.Drawing.Size(121, 28);
            this.ComboMaterias1.TabIndex = 8;
            this.ComboMaterias1.Click += new System.EventHandler(this.ComboMaterias1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(402, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 284);
            this.panel3.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(33, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(356, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "**Asegurese de agregar las correlativas correspondientes";
            this.label10.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMensaje);
            this.groupBox1.Controls.Add(this.btnGuardarPE);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 593);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plan de Estudio";
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(575, 428);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(160, 20);
            this.labelMensaje.TabIndex = 33;
            this.labelMensaje.Text = "Mensaje validacion";
            this.labelMensaje.Visible = false;
            // 
            // btnGuardarPE
            // 
            this.btnGuardarPE.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarPE.Location = new System.Drawing.Point(575, 480);
            this.btnGuardarPE.Name = "btnGuardarPE";
            this.btnGuardarPE.Size = new System.Drawing.Size(207, 98);
            this.btnGuardarPE.TabIndex = 28;
            this.btnGuardarPE.Text = "Guardar plan de estudio";
            this.btnGuardarPE.UseVisualStyleBackColor = false;
            this.btnGuardarPE.Click += new System.EventHandler(this.Button6_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ComboBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(34, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 135);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del plan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Carrera";
            // 
            // ComboBox3
            // 
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Location = new System.Drawing.Point(184, 63);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(121, 28);
            this.ComboBox3.TabIndex = 11;
            this.ComboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNumeroMateria);
            this.panel2.Controls.Add(this.txtCargaHoraria);
            this.panel2.Controls.Add(this.txtAño);
            this.panel2.Controls.Add(this.ComboObligatoriedad);
            this.panel2.Location = new System.Drawing.Point(34, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 148);
            this.panel2.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Numero De Materia";
            // 
            // txtNumeroMateria
            // 
            this.txtNumeroMateria.Location = new System.Drawing.Point(184, 104);
            this.txtNumeroMateria.Name = "txtNumeroMateria";
            this.txtNumeroMateria.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroMateria.TabIndex = 4;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(184, 73);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(100, 26);
            this.txtCargaHoraria.TabIndex = 3;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(184, 43);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 26);
            this.txtAño.TabIndex = 5;
            // 
            // ComboObligatoriedad
            // 
            this.ComboObligatoriedad.FormattingEnabled = true;
            this.ComboObligatoriedad.Items.AddRange(new object[] {
            "Obligatoria",
            "Opcional"});
            this.ComboObligatoriedad.Location = new System.Drawing.Point(184, 9);
            this.ComboObligatoriedad.Name = "ComboObligatoriedad";
            this.ComboObligatoriedad.Size = new System.Drawing.Size(121, 28);
            this.ComboObligatoriedad.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(575, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 42);
            this.button5.TabIndex = 26;
            this.button5.Text = "Quitar materia";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(575, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 62);
            this.button4.TabIndex = 27;
            this.button4.Text = "Agregar materia";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dgCorrelatividades);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.groupBox2);
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
            this.button2.Location = new System.Drawing.Point(176, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(404, 91);
            this.button2.TabIndex = 50;
            this.button2.Text = "Guardar correlatividades";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(600, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 106);
            this.button3.TabIndex = 49;
            this.button3.Text = "Agregar correlativa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dgCorrelatividades
            // 
            this.dgCorrelatividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgCorrelatividades.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgCorrelatividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCorrelatividades.Location = new System.Drawing.Point(176, 210);
            this.dgCorrelatividades.Name = "dgCorrelatividades";
            this.dgCorrelatividades.Size = new System.Drawing.Size(404, 237);
            this.dgCorrelatividades.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Seleccione materia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(18, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 553);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignación de correlativas";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.ComboMateriasCC);
            this.panel4.Controls.Add(this.ComboPEcorr);
            this.panel4.Controls.Add(this.ComboCorrelativas);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(158, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(404, 139);
            this.panel4.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Seleccione Plan de Estudio";
            // 
            // ComboMateriasCC
            // 
            this.ComboMateriasCC.FormattingEnabled = true;
            this.ComboMateriasCC.Location = new System.Drawing.Point(13, 94);
            this.ComboMateriasCC.Name = "ComboMateriasCC";
            this.ComboMateriasCC.Size = new System.Drawing.Size(121, 28);
            this.ComboMateriasCC.TabIndex = 35;
            // 
            // ComboPEcorr
            // 
            this.ComboPEcorr.FormattingEnabled = true;
            this.ComboPEcorr.Location = new System.Drawing.Point(13, 34);
            this.ComboPEcorr.Name = "ComboPEcorr";
            this.ComboPEcorr.Size = new System.Drawing.Size(121, 28);
            this.ComboPEcorr.TabIndex = 51;
            this.ComboPEcorr.SelectedIndexChanged += new System.EventHandler(this.ComboPEcorr_SelectedIndexChanged);
            // 
            // ComboCorrelativas
            // 
            this.ComboCorrelativas.FormattingEnabled = true;
            this.ComboCorrelativas.Location = new System.Drawing.Point(199, 94);
            this.ComboCorrelativas.Name = "ComboCorrelativas";
            this.ComboCorrelativas.Size = new System.Drawing.Size(121, 28);
            this.ComboCorrelativas.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(192, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Seleccione su correlativa";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(582, 295);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(179, 42);
            this.button7.TabIndex = 48;
            this.button7.Text = "Quitar correlativa";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(846, 605);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultar Correlativas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgConsultaCorrelativas);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.ComboConsultaMateria);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.ComboConsultaPlan);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Location = new System.Drawing.Point(26, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(797, 567);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta de correlatividades";
            // 
            // dgConsultaCorrelativas
            // 
            this.dgConsultaCorrelativas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgConsultaCorrelativas.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgConsultaCorrelativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultaCorrelativas.Location = new System.Drawing.Point(154, 186);
            this.dgConsultaCorrelativas.Name = "dgConsultaCorrelativas";
            this.dgConsultaCorrelativas.Size = new System.Drawing.Size(431, 335);
            this.dgConsultaCorrelativas.TabIndex = 43;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DodgerBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(591, 186);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 98);
            this.button9.TabIndex = 49;
            this.button9.Text = "Consultar Correlativas";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 20);
            this.label12.TabIndex = 52;
            this.label12.Text = "Seleccione Plan de Estudio";
            // 
            // ComboConsultaMateria
            // 
            this.ComboConsultaMateria.FormattingEnabled = true;
            this.ComboConsultaMateria.Location = new System.Drawing.Point(177, 135);
            this.ComboConsultaMateria.Name = "ComboConsultaMateria";
            this.ComboConsultaMateria.Size = new System.Drawing.Size(144, 28);
            this.ComboConsultaMateria.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Seleccione materia";
            // 
            // ComboConsultaPlan
            // 
            this.ComboConsultaPlan.FormattingEnabled = true;
            this.ComboConsultaPlan.Location = new System.Drawing.Point(177, 76);
            this.ComboConsultaPlan.Name = "ComboConsultaPlan";
            this.ComboConsultaPlan.Size = new System.Drawing.Size(144, 28);
            this.ComboConsultaPlan.TabIndex = 51;
            this.ComboConsultaPlan.SelectedIndexChanged += new System.EventHandler(this.ComboConsultaPlan_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(154, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(431, 126);
            this.panel5.TabIndex = 53;
            // 
            // UCPlanDeEstudio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl1);
            this.Name = "UCPlanDeEstudio";
            this.Size = new System.Drawing.Size(854, 638);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPEMaterias)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorrelatividades)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaCorrelativas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox3;
        private System.Windows.Forms.ComboBox ComboMaterias1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtNumeroMateria;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuardarPE;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgPEMaterias;
        private System.Windows.Forms.Button btnConsultarCorrelativas;
        private System.Windows.Forms.Button btnAsignarCorrelativas;
        private System.Windows.Forms.ComboBox ComboObligatoriedad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dgCorrelatividades;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ComboMateriasCC;
        private System.Windows.Forms.ComboBox ComboCorrelativas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ComboPEcorr;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ComboConsultaPlan;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dgConsultaCorrelativas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ComboConsultaMateria;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel5;
    }
}
