﻿namespace GUI.UserControlSecretarioAcademico
{
    partial class UCCursos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExisteCorrEnAprobadas = new System.Windows.Forms.Button();
            this.ComboMaterias1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboPEcorr = new System.Windows.Forms.ComboBox();
            this.dgAprobadas = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgCursoMat = new System.Windows.Forms.DataGridView();
            this.btnConsultarCorrelativas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ComboCuposMax = new System.Windows.Forms.ComboBox();
            this.ComboCarrera = new System.Windows.Forms.ComboBox();
            this.ComboCupos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAprobadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursoMat)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 638);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asignar Cursos a materia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.dgAprobadas);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dgCursoMat);
            this.groupBox1.Controls.Add(this.btnConsultarCorrelativas);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(15, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 593);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignacion de cursos a materias";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnExisteCorrEnAprobadas);
            this.panel4.Controls.Add(this.ComboMaterias1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.ComboPEcorr);
            this.panel4.Location = new System.Drawing.Point(19, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 133);
            this.panel4.TabIndex = 45;
            // 
            // btnExisteCorrEnAprobadas
            // 
            this.btnExisteCorrEnAprobadas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExisteCorrEnAprobadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExisteCorrEnAprobadas.Location = new System.Drawing.Point(230, 93);
            this.btnExisteCorrEnAprobadas.Name = "btnExisteCorrEnAprobadas";
            this.btnExisteCorrEnAprobadas.Size = new System.Drawing.Size(86, 33);
            this.btnExisteCorrEnAprobadas.TabIndex = 37;
            this.btnExisteCorrEnAprobadas.Text = "Buscar";
            this.btnExisteCorrEnAprobadas.UseVisualStyleBackColor = false;
            // 
            // ComboMaterias1
            // 
            this.ComboMaterias1.FormattingEnabled = true;
            this.ComboMaterias1.Location = new System.Drawing.Point(22, 90);
            this.ComboMaterias1.Name = "ComboMaterias1";
            this.ComboMaterias1.Size = new System.Drawing.Size(121, 28);
            this.ComboMaterias1.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Seleccione Plan de Estudio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Seleccione Materia";
            // 
            // ComboPEcorr
            // 
            this.ComboPEcorr.FormattingEnabled = true;
            this.ComboPEcorr.Location = new System.Drawing.Point(22, 35);
            this.ComboPEcorr.Name = "ComboPEcorr";
            this.ComboPEcorr.Size = new System.Drawing.Size(121, 28);
            this.ComboPEcorr.TabIndex = 53;
            this.ComboPEcorr.DropDownClosed += new System.EventHandler(this.ComboPEcorr_DropDownClosed);
            // 
            // dgAprobadas
            // 
            this.dgAprobadas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAprobadas.Location = new System.Drawing.Point(453, 266);
            this.dgAprobadas.Name = "dgAprobadas";
            this.dgAprobadas.RowHeadersWidth = 57;
            this.dgAprobadas.Size = new System.Drawing.Size(224, 141);
            this.dgAprobadas.TabIndex = 33;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(498, 451);
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
            this.button4.Location = new System.Drawing.Point(19, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 70);
            this.button4.TabIndex = 27;
            this.button4.Text = "Asignar curso";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(237, 451);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 70);
            this.button5.TabIndex = 26;
            this.button5.Text = "Quitar curso";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dgCursoMat
            // 
            this.dgCursoMat.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgCursoMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursoMat.Location = new System.Drawing.Point(19, 266);
            this.dgCursoMat.Name = "dgCursoMat";
            this.dgCursoMat.RowHeadersWidth = 57;
            this.dgCursoMat.Size = new System.Drawing.Size(409, 179);
            this.dgCursoMat.TabIndex = 23;
            // 
            // btnConsultarCorrelativas
            // 
            this.btnConsultarCorrelativas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultarCorrelativas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarCorrelativas.Location = new System.Drawing.Point(683, 266);
            this.btnConsultarCorrelativas.Name = "btnConsultarCorrelativas";
            this.btnConsultarCorrelativas.Size = new System.Drawing.Size(111, 141);
            this.btnConsultarCorrelativas.TabIndex = 22;
            this.btnConsultarCorrelativas.Text = "Consultar aprobadas";
            this.btnConsultarCorrelativas.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.ComboCuposMax);
            this.panel2.Controls.Add(this.ComboCarrera);
            this.panel2.Controls.Add(this.ComboCupos);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtAño);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(409, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 222);
            this.panel2.TabIndex = 45;
            // 
            // ComboCuposMax
            // 
            this.ComboCuposMax.Enabled = false;
            this.ComboCuposMax.FormattingEnabled = true;
            this.ComboCuposMax.Location = new System.Drawing.Point(310, 114);
            this.ComboCuposMax.Name = "ComboCuposMax";
            this.ComboCuposMax.Size = new System.Drawing.Size(57, 28);
            this.ComboCuposMax.TabIndex = 41;
            // 
            // ComboCarrera
            // 
            this.ComboCarrera.FormattingEnabled = true;
            this.ComboCarrera.Location = new System.Drawing.Point(239, 13);
            this.ComboCarrera.Name = "ComboCarrera";
            this.ComboCarrera.Size = new System.Drawing.Size(128, 28);
            this.ComboCarrera.TabIndex = 11;
            // 
            // ComboCupos
            // 
            this.ComboCupos.Enabled = false;
            this.ComboCupos.FormattingEnabled = true;
            this.ComboCupos.Location = new System.Drawing.Point(247, 114);
            this.ComboCupos.Name = "ComboCupos";
            this.ComboCupos.Size = new System.Drawing.Size(57, 28);
            this.ComboCupos.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Carrera";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cupos Valor Nuevo-Actuales";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(260, 150);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(107, 26);
            this.txtAño.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Turno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha inicio cursada";
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
            this.dgCorrelatividades.RowHeadersWidth = 57;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 27);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(239, 80);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(128, 27);
            this.dateTimePicker2.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Fecha fin cursada";
            // 
            // UCCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UCCursos";
            this.Size = new System.Drawing.Size(854, 638);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAprobadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursoMat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorrelatividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExisteCorrEnAprobadas;
        private System.Windows.Forms.ComboBox ComboMaterias1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboPEcorr;
        private System.Windows.Forms.DataGridView dgAprobadas;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgCursoMat;
        private System.Windows.Forms.Button btnConsultarCorrelativas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ComboCuposMax;
        private System.Windows.Forms.ComboBox ComboCarrera;
        private System.Windows.Forms.ComboBox ComboCupos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
    }
}
