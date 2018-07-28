namespace WindowsFormsApplication1
{
    partial class Reingresocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reingresocs));
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxProcedenciaReingreso = new System.Windows.Forms.TextBox();
            this.textBoxTPAreingreso = new System.Windows.Forms.TextBox();
            this.textBoxRetrasadaReingreso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonTPAsi = new System.Windows.Forms.RadioButton();
            this.radioButtonTPAno = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonMateriaSi = new System.Windows.Forms.RadioButton();
            this.radioButtonMateriaNo = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxFoto = new System.Windows.Forms.CheckBox();
            this.checkBoxConducta = new System.Windows.Forms.CheckBox();
            this.checkBoxNotas = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGrado2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIdAlumnoReingreso = new System.Windows.Forms.TextBox();
            this.textBoxNombreAlumnoReingreso = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonMatriculaReingreso = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAtrasRegistro = new System.Windows.Forms.Button();
            this.radioButtonReingresoContinuo = new System.Windows.Forms.RadioButton();
            this.radioButtonTraslado = new System.Windows.Forms.RadioButton();
            this.textBoxGrado2 = new System.Windows.Forms.TextBox();
            this.comboBoxSeccion2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSeccion2 = new System.Windows.Forms.TextBox();
            this.dateTimePickerReingreso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrorEB = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxAula2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEB)).BeginInit();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Rockwell", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label26.Location = new System.Drawing.Point(283, 39);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(243, 28);
            this.label26.TabIndex = 40;
            this.label26.Text = "Matricula Reingreso";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxProcedenciaReingreso);
            this.groupBox2.Controls.Add(this.textBoxTPAreingreso);
            this.groupBox2.Controls.Add(this.textBoxRetrasadaReingreso);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(439, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 247);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro Academico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(95, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Intituto de procedencia:";
            // 
            // textBoxProcedenciaReingreso
            // 
            this.textBoxProcedenciaReingreso.Enabled = false;
            this.textBoxProcedenciaReingreso.Location = new System.Drawing.Point(98, 184);
            this.textBoxProcedenciaReingreso.MaxLength = 30;
            this.textBoxProcedenciaReingreso.Name = "textBoxProcedenciaReingreso";
            this.textBoxProcedenciaReingreso.ShortcutsEnabled = false;
            this.textBoxProcedenciaReingreso.Size = new System.Drawing.Size(127, 20);
            this.textBoxProcedenciaReingreso.TabIndex = 17;
            this.textBoxProcedenciaReingreso.TextChanged += new System.EventHandler(this.textBoxProcedenciaReingreso_TextChanged);
            this.textBoxProcedenciaReingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProcedenciaReingreso_KeyPress);
            // 
            // textBoxTPAreingreso
            // 
            this.textBoxTPAreingreso.Enabled = false;
            this.textBoxTPAreingreso.Location = new System.Drawing.Point(185, 126);
            this.textBoxTPAreingreso.MaxLength = 30;
            this.textBoxTPAreingreso.Name = "textBoxTPAreingreso";
            this.textBoxTPAreingreso.ShortcutsEnabled = false;
            this.textBoxTPAreingreso.Size = new System.Drawing.Size(127, 20);
            this.textBoxTPAreingreso.TabIndex = 14;
            this.textBoxTPAreingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTPAreingreso_KeyPress);
            // 
            // textBoxRetrasadaReingreso
            // 
            this.textBoxRetrasadaReingreso.Enabled = false;
            this.textBoxRetrasadaReingreso.Location = new System.Drawing.Point(12, 126);
            this.textBoxRetrasadaReingreso.MaxLength = 30;
            this.textBoxRetrasadaReingreso.Name = "textBoxRetrasadaReingreso";
            this.textBoxRetrasadaReingreso.ShortcutsEnabled = false;
            this.textBoxRetrasadaReingreso.Size = new System.Drawing.Size(121, 20);
            this.textBoxRetrasadaReingreso.TabIndex = 13;
            this.textBoxRetrasadaReingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRetrasadaReingreso_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Materia TPA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Maetria Retrasada:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonTPAsi);
            this.groupBox4.Controls.Add(this.radioButtonTPAno);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(185, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 67);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "¿Materia TPA?:";
            // 
            // radioButtonTPAsi
            // 
            this.radioButtonTPAsi.AutoSize = true;
            this.radioButtonTPAsi.Location = new System.Drawing.Point(6, 32);
            this.radioButtonTPAsi.Name = "radioButtonTPAsi";
            this.radioButtonTPAsi.Size = new System.Drawing.Size(34, 17);
            this.radioButtonTPAsi.TabIndex = 0;
            this.radioButtonTPAsi.TabStop = true;
            this.radioButtonTPAsi.Text = "Si";
            this.radioButtonTPAsi.UseVisualStyleBackColor = true;
            this.radioButtonTPAsi.CheckedChanged += new System.EventHandler(this.radioButtonTPAsi_CheckedChanged);
            // 
            // radioButtonTPAno
            // 
            this.radioButtonTPAno.AutoSize = true;
            this.radioButtonTPAno.Location = new System.Drawing.Point(64, 32);
            this.radioButtonTPAno.Name = "radioButtonTPAno";
            this.radioButtonTPAno.Size = new System.Drawing.Size(39, 17);
            this.radioButtonTPAno.TabIndex = 1;
            this.radioButtonTPAno.TabStop = true;
            this.radioButtonTPAno.Text = "No";
            this.radioButtonTPAno.UseVisualStyleBackColor = true;
            this.radioButtonTPAno.CheckedChanged += new System.EventHandler(this.radioButtonTPAno_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonMateriaSi);
            this.groupBox3.Controls.Add(this.radioButtonMateriaNo);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(6, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 67);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "¿Materia Retrasada?:";
            // 
            // radioButtonMateriaSi
            // 
            this.radioButtonMateriaSi.AutoSize = true;
            this.radioButtonMateriaSi.Location = new System.Drawing.Point(6, 32);
            this.radioButtonMateriaSi.Name = "radioButtonMateriaSi";
            this.radioButtonMateriaSi.Size = new System.Drawing.Size(34, 17);
            this.radioButtonMateriaSi.TabIndex = 0;
            this.radioButtonMateriaSi.TabStop = true;
            this.radioButtonMateriaSi.Text = "Si";
            this.radioButtonMateriaSi.UseVisualStyleBackColor = true;
            this.radioButtonMateriaSi.CheckedChanged += new System.EventHandler(this.radioButtonMateriaSi_CheckedChanged);
            // 
            // radioButtonMateriaNo
            // 
            this.radioButtonMateriaNo.AutoSize = true;
            this.radioButtonMateriaNo.Location = new System.Drawing.Point(64, 32);
            this.radioButtonMateriaNo.Name = "radioButtonMateriaNo";
            this.radioButtonMateriaNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonMateriaNo.TabIndex = 1;
            this.radioButtonMateriaNo.TabStop = true;
            this.radioButtonMateriaNo.Text = "No";
            this.radioButtonMateriaNo.UseVisualStyleBackColor = true;
            this.radioButtonMateriaNo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.checkBoxFoto);
            this.groupBox5.Controls.Add(this.checkBoxConducta);
            this.groupBox5.Controls.Add(this.checkBoxNotas);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(241, 159);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(192, 146);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Documentos a Entregar:";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // checkBoxFoto
            // 
            this.checkBoxFoto.AutoSize = true;
            this.checkBoxFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxFoto.Location = new System.Drawing.Point(16, 105);
            this.checkBoxFoto.Name = "checkBoxFoto";
            this.checkBoxFoto.Size = new System.Drawing.Size(78, 17);
            this.checkBoxFoto.TabIndex = 3;
            this.checkBoxFoto.Text = "Fotografias";
            this.checkBoxFoto.UseVisualStyleBackColor = true;
            // 
            // checkBoxConducta
            // 
            this.checkBoxConducta.AutoSize = true;
            this.checkBoxConducta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxConducta.Location = new System.Drawing.Point(16, 72);
            this.checkBoxConducta.Name = "checkBoxConducta";
            this.checkBoxConducta.Size = new System.Drawing.Size(143, 17);
            this.checkBoxConducta.TabIndex = 2;
            this.checkBoxConducta.Text = "Constancia de Conducta";
            this.checkBoxConducta.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotas
            // 
            this.checkBoxNotas.AutoSize = true;
            this.checkBoxNotas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxNotas.Location = new System.Drawing.Point(16, 39);
            this.checkBoxNotas.Name = "checkBoxNotas";
            this.checkBoxNotas.Size = new System.Drawing.Size(122, 17);
            this.checkBoxNotas.TabIndex = 0;
            this.checkBoxNotas.Text = "Certificado de Notas";
            this.checkBoxNotas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(48, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Grado a Matricular:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxGrado2
            // 
            this.comboBoxGrado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrado2.FormattingEnabled = true;
            this.comboBoxGrado2.Items.AddRange(new object[] {
            "1er grado",
            "2do grado",
            "3er grado",
            "4to grado",
            "5to grado",
            "6to grado",
            "7mo grado",
            "8vo grado",
            "9no grado",
            "10mo grado",
            "11vo grado"});
            this.comboBoxGrado2.Location = new System.Drawing.Point(51, 385);
            this.comboBoxGrado2.Name = "comboBoxGrado2";
            this.comboBoxGrado2.Size = new System.Drawing.Size(165, 21);
            this.comboBoxGrado2.TabIndex = 43;
            this.comboBoxGrado2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(48, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Id Alumno:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(48, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nombre Alumno:";
            this.label3.Visible = false;
            // 
            // textBoxIdAlumnoReingreso
            // 
            this.textBoxIdAlumnoReingreso.Location = new System.Drawing.Point(51, 226);
            this.textBoxIdAlumnoReingreso.Name = "textBoxIdAlumnoReingreso";
            this.textBoxIdAlumnoReingreso.ShortcutsEnabled = false;
            this.textBoxIdAlumnoReingreso.Size = new System.Drawing.Size(165, 20);
            this.textBoxIdAlumnoReingreso.TabIndex = 46;
            this.textBoxIdAlumnoReingreso.TextChanged += new System.EventHandler(this.textBoxIdAlumnoReingreso_TextChanged);
            this.textBoxIdAlumnoReingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdAlumnoReingreso_KeyPress);
            // 
            // textBoxNombreAlumnoReingreso
            // 
            this.textBoxNombreAlumnoReingreso.Enabled = false;
            this.textBoxNombreAlumnoReingreso.Location = new System.Drawing.Point(51, 301);
            this.textBoxNombreAlumnoReingreso.MaxLength = 50;
            this.textBoxNombreAlumnoReingreso.Name = "textBoxNombreAlumnoReingreso";
            this.textBoxNombreAlumnoReingreso.ShortcutsEnabled = false;
            this.textBoxNombreAlumnoReingreso.Size = new System.Drawing.Size(165, 20);
            this.textBoxNombreAlumnoReingreso.TabIndex = 47;
            this.textBoxNombreAlumnoReingreso.Visible = false;
            this.textBoxNombreAlumnoReingreso.TextChanged += new System.EventHandler(this.textBoxNombreAlumnoReingreso_TextChanged);
            this.textBoxNombreAlumnoReingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreAlumnoReingreso_KeyPress);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalir.Location = new System.Drawing.Point(671, 39);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(87, 30);
            this.buttonSalir.TabIndex = 48;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonMatriculaReingreso
            // 
            this.buttonMatriculaReingreso.BackColor = System.Drawing.Color.DarkRed;
            this.buttonMatriculaReingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMatriculaReingreso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMatriculaReingreso.Location = new System.Drawing.Point(660, 460);
            this.buttonMatriculaReingreso.Name = "buttonMatriculaReingreso";
            this.buttonMatriculaReingreso.Size = new System.Drawing.Size(88, 33);
            this.buttonMatriculaReingreso.TabIndex = 49;
            this.buttonMatriculaReingreso.Text = "Matricular";
            this.buttonMatriculaReingreso.UseVisualStyleBackColor = false;
            this.buttonMatriculaReingreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(51, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 47);
            this.button2.TabIndex = 50;
            this.button2.Text = "Modificar Datos Existentes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAtrasRegistro
            // 
            this.buttonAtrasRegistro.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonAtrasRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrasRegistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAtrasRegistro.Location = new System.Drawing.Point(36, 35);
            this.buttonAtrasRegistro.Name = "buttonAtrasRegistro";
            this.buttonAtrasRegistro.Size = new System.Drawing.Size(87, 30);
            this.buttonAtrasRegistro.TabIndex = 51;
            this.buttonAtrasRegistro.Text = "Atras";
            this.buttonAtrasRegistro.UseVisualStyleBackColor = false;
            this.buttonAtrasRegistro.Click += new System.EventHandler(this.buttonAtrasRegistro_Click);
            // 
            // radioButtonReingresoContinuo
            // 
            this.radioButtonReingresoContinuo.AutoSize = true;
            this.radioButtonReingresoContinuo.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonReingresoContinuo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonReingresoContinuo.Location = new System.Drawing.Point(51, 92);
            this.radioButtonReingresoContinuo.Name = "radioButtonReingresoContinuo";
            this.radioButtonReingresoContinuo.Size = new System.Drawing.Size(118, 17);
            this.radioButtonReingresoContinuo.TabIndex = 52;
            this.radioButtonReingresoContinuo.TabStop = true;
            this.radioButtonReingresoContinuo.Text = "Reingreso Continuo";
            this.radioButtonReingresoContinuo.UseVisualStyleBackColor = false;
            this.radioButtonReingresoContinuo.CheckedChanged += new System.EventHandler(this.radioButtonReingresoContinuo_CheckedChanged);
            // 
            // radioButtonTraslado
            // 
            this.radioButtonTraslado.AutoSize = true;
            this.radioButtonTraslado.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTraslado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonTraslado.Location = new System.Drawing.Point(210, 92);
            this.radioButtonTraslado.Name = "radioButtonTraslado";
            this.radioButtonTraslado.Size = new System.Drawing.Size(66, 17);
            this.radioButtonTraslado.TabIndex = 53;
            this.radioButtonTraslado.TabStop = true;
            this.radioButtonTraslado.Text = "Traslado";
            this.radioButtonTraslado.UseVisualStyleBackColor = false;
            this.radioButtonTraslado.CheckedChanged += new System.EventHandler(this.radioButtonTraslado_CheckedChanged);
            // 
            // textBoxGrado2
            // 
            this.textBoxGrado2.Location = new System.Drawing.Point(241, 424);
            this.textBoxGrado2.Name = "textBoxGrado2";
            this.textBoxGrado2.Size = new System.Drawing.Size(48, 20);
            this.textBoxGrado2.TabIndex = 54;
            this.textBoxGrado2.Visible = false;
            this.textBoxGrado2.TextChanged += new System.EventHandler(this.textBoxGrado2_TextChanged);
            // 
            // comboBoxSeccion2
            // 
            this.comboBoxSeccion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeccion2.FormattingEnabled = true;
            this.comboBoxSeccion2.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBoxSeccion2.Location = new System.Drawing.Point(241, 385);
            this.comboBoxSeccion2.Name = "comboBoxSeccion2";
            this.comboBoxSeccion2.Size = new System.Drawing.Size(165, 21);
            this.comboBoxSeccion2.TabIndex = 55;
            this.comboBoxSeccion2.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeccion2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(240, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Seccion:";
            // 
            // textBoxSeccion2
            // 
            this.textBoxSeccion2.Location = new System.Drawing.Point(328, 424);
            this.textBoxSeccion2.Name = "textBoxSeccion2";
            this.textBoxSeccion2.Size = new System.Drawing.Size(48, 20);
            this.textBoxSeccion2.TabIndex = 57;
            this.textBoxSeccion2.Visible = false;
            // 
            // dateTimePickerReingreso
            // 
            this.dateTimePickerReingreso.CustomFormat = "yyyy";
            this.dateTimePickerReingreso.Enabled = false;
            this.dateTimePickerReingreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReingreso.Location = new System.Drawing.Point(51, 159);
            this.dateTimePickerReingreso.Name = "dateTimePickerReingreso";
            this.dateTimePickerReingreso.Size = new System.Drawing.Size(165, 20);
            this.dateTimePickerReingreso.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(48, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Año del Periodo:";
            // 
            // ErrorEB
            // 
            this.ErrorEB.ContainerControl = this;
            // 
            // textBoxAula2
            // 
            this.textBoxAula2.Location = new System.Drawing.Point(402, 424);
            this.textBoxAula2.Name = "textBoxAula2";
            this.textBoxAula2.Size = new System.Drawing.Size(53, 20);
            this.textBoxAula2.TabIndex = 60;
            this.textBoxAula2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Reingresocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(806, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAula2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerReingreso);
            this.Controls.Add(this.textBoxSeccion2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSeccion2);
            this.Controls.Add(this.textBoxGrado2);
            this.Controls.Add(this.radioButtonTraslado);
            this.Controls.Add(this.radioButtonReingresoContinuo);
            this.Controls.Add(this.buttonAtrasRegistro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonMatriculaReingreso);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.textBoxNombreAlumnoReingreso);
            this.Controls.Add(this.textBoxIdAlumnoReingreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxGrado2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label26);
            this.Name = "Reingresocs";
            this.Text = "Reingresocs";
            this.Load += new System.EventHandler(this.Reingresocs_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxProcedenciaReingreso;
        private System.Windows.Forms.TextBox textBoxTPAreingreso;
        private System.Windows.Forms.TextBox textBoxRetrasadaReingreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonTPAsi;
        private System.Windows.Forms.RadioButton radioButtonTPAno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonMateriaSi;
        private System.Windows.Forms.RadioButton radioButtonMateriaNo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxFoto;
        private System.Windows.Forms.CheckBox checkBoxConducta;
        private System.Windows.Forms.CheckBox checkBoxNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGrado2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIdAlumnoReingreso;
        private System.Windows.Forms.TextBox textBoxNombreAlumnoReingreso;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonMatriculaReingreso;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAtrasRegistro;
        private System.Windows.Forms.RadioButton radioButtonReingresoContinuo;
        private System.Windows.Forms.RadioButton radioButtonTraslado;
        private System.Windows.Forms.TextBox textBoxGrado2;
        private System.Windows.Forms.ComboBox comboBoxSeccion2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSeccion2;
        private System.Windows.Forms.DateTimePicker dateTimePickerReingreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider ErrorEB;
        private System.Windows.Forms.TextBox textBoxAula2;
        private System.Windows.Forms.Button button1;
    }
}