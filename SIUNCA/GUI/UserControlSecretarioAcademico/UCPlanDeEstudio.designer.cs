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
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgPEMaterias = new System.Windows.Forms.DataGridView();
            this.btnConsultarCorrelativas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboObligatoriedad = new System.Windows.Forms.ComboBox();
            this.dgCorrelativas = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.ComboMaterias1 = new System.Windows.Forms.ComboBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtNumeroMateria = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPEMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorrelativas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.dgPEMaterias);
            this.tabPage1.Controls.Add(this.btnConsultarCorrelativas);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.ComboObligatoriedad);
            this.tabPage1.Controls.Add(this.dgCorrelativas);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ComboBox3);
            this.tabPage1.Controls.Add(this.ComboMaterias1);
            this.tabPage1.Controls.Add(this.txtAño);
            this.tabPage1.Controls.Add(this.txtNumeroMateria);
            this.tabPage1.Controls.Add(this.txtCargaHoraria);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Plan de estudio";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(619, 517);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 67);
            this.button6.TabIndex = 28;
            this.button6.Text = "Guardar plan de estudio";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(619, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 42);
            this.button4.TabIndex = 27;
            this.button4.Text = "Agregar materia";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(619, 369);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 42);
            this.button5.TabIndex = 26;
            this.button5.Text = "Quitar materia";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // dgPEMaterias
            // 
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
            this.btnConsultarCorrelativas.Location = new System.Drawing.Point(526, 241);
            this.btnConsultarCorrelativas.Name = "btnConsultarCorrelativas";
            this.btnConsultarCorrelativas.Size = new System.Drawing.Size(296, 41);
            this.btnConsultarCorrelativas.TabIndex = 22;
            this.btnConsultarCorrelativas.Text = "Consultar correlativas";
            this.btnConsultarCorrelativas.UseVisualStyleBackColor = false;
            this.btnConsultarCorrelativas.Click += new System.EventHandler(this.btnConsultarCorrelativas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(526, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Asignar correlativas a una materia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // ComboObligatoriedad
            // 
            this.ComboObligatoriedad.FormattingEnabled = true;
            this.ComboObligatoriedad.Items.AddRange(new object[] {
            "Obligatoria",
            "Opcional"});
            this.ComboObligatoriedad.Location = new System.Drawing.Point(213, 191);
            this.ComboObligatoriedad.Name = "ComboObligatoriedad";
            this.ComboObligatoriedad.Size = new System.Drawing.Size(121, 28);
            this.ComboObligatoriedad.TabIndex = 20;
            // 
            // dgCorrelativas
            // 
            this.dgCorrelativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCorrelativas.Location = new System.Drawing.Point(526, 94);
            this.dgCorrelativas.Name = "dgCorrelativas";
            this.dgCorrelativas.Size = new System.Drawing.Size(272, 91);
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
            this.label7.Location = new System.Drawing.Point(46, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "CargaHoraria";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Obligatoriedad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Numero De Materia";
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
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del plan";
            // 
            // ComboBox3
            // 
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Location = new System.Drawing.Point(213, 94);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(121, 28);
            this.ComboBox3.TabIndex = 11;
            this.ComboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // ComboMaterias1
            // 
            this.ComboMaterias1.FormattingEnabled = true;
            this.ComboMaterias1.Location = new System.Drawing.Point(645, 60);
            this.ComboMaterias1.Name = "ComboMaterias1";
            this.ComboMaterias1.Size = new System.Drawing.Size(121, 28);
            this.ComboMaterias1.TabIndex = 8;
            this.ComboMaterias1.SelectedIndexChanged += new System.EventHandler(this.ComboMaterias1_SelectedIndexChanged);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(213, 225);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 26);
            this.txtAño.TabIndex = 5;
            // 
            // txtNumeroMateria
            // 
            this.txtNumeroMateria.Location = new System.Drawing.Point(213, 289);
            this.txtNumeroMateria.Name = "txtNumeroMateria";
            this.txtNumeroMateria.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroMateria.TabIndex = 4;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(213, 257);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(100, 26);
            this.txtCargaHoraria.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plan de estudio";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asignar Correlativas";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgCorrelativas)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgPEMaterias;
        private System.Windows.Forms.Button btnConsultarCorrelativas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboObligatoriedad;
        private System.Windows.Forms.DataGridView dgCorrelativas;
    }
}
