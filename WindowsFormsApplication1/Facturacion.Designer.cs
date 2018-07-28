namespace WindowsFormsApplication1
{
    partial class Facturacion
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxBus = new System.Windows.Forms.CheckBox();
            this.checkBoxMensualidad = new System.Windows.Forms.CheckBox();
            this.checkBoxMatricula = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lable9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxNombreClienteFact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIdClienteFact = new System.Windows.Forms.TextBox();
            this.textBoxNombreAlumnoFact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIdAlumnoFact = new System.Windows.Forms.TextBox();
            this.textBoxNombreEncargadoFact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdEmpleadoFact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewAlumnoFactura = new System.Windows.Forms.DataGridView();
            this.textBoxIdAlumnoCob = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorEB = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnoFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEB)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 213);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 45;
            this.dateTimePicker1.Value = new System.DateTime(2018, 4, 14, 2, 4, 3, 0);
            // 
            // checkBoxBus
            // 
            this.checkBoxBus.AutoSize = true;
            this.checkBoxBus.Location = new System.Drawing.Point(45, 498);
            this.checkBoxBus.Name = "checkBoxBus";
            this.checkBoxBus.Size = new System.Drawing.Size(44, 17);
            this.checkBoxBus.TabIndex = 44;
            this.checkBoxBus.Text = "Bus";
            this.checkBoxBus.UseVisualStyleBackColor = true;
            // 
            // checkBoxMensualidad
            // 
            this.checkBoxMensualidad.AutoSize = true;
            this.checkBoxMensualidad.Location = new System.Drawing.Point(45, 475);
            this.checkBoxMensualidad.Name = "checkBoxMensualidad";
            this.checkBoxMensualidad.Size = new System.Drawing.Size(86, 17);
            this.checkBoxMensualidad.TabIndex = 43;
            this.checkBoxMensualidad.Text = "Mensualidad";
            this.checkBoxMensualidad.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatricula
            // 
            this.checkBoxMatricula.AutoSize = true;
            this.checkBoxMatricula.Location = new System.Drawing.Point(45, 447);
            this.checkBoxMatricula.Name = "checkBoxMatricula";
            this.checkBoxMatricula.Size = new System.Drawing.Size(69, 17);
            this.checkBoxMatricula.TabIndex = 42;
            this.checkBoxMatricula.Text = "Matricula";
            this.checkBoxMatricula.UseVisualStyleBackColor = true;
            this.checkBoxMatricula.CheckedChanged += new System.EventHandler(this.checkBoxMatricula_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(747, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lable9
            // 
            this.lable9.AutoSize = true;
            this.lable9.Location = new System.Drawing.Point(43, 414);
            this.lable9.Name = "lable9";
            this.lable9.Size = new System.Drawing.Size(88, 13);
            this.lable9.TabIndex = 39;
            this.lable9.Text = "Servicio a Pagar:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Credito"});
            this.comboBox1.Location = new System.Drawing.Point(33, 303);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // textBoxNombreClienteFact
            // 
            this.textBoxNombreClienteFact.Location = new System.Drawing.Point(693, 510);
            this.textBoxNombreClienteFact.Name = "textBoxNombreClienteFact";
            this.textBoxNombreClienteFact.ShortcutsEnabled = false;
            this.textBoxNombreClienteFact.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreClienteFact.TabIndex = 37;
            this.textBoxNombreClienteFact.TextChanged += new System.EventHandler(this.textBoxNombreClienteFact_TextChanged);
            this.textBoxNombreClienteFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreClienteFact_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(690, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Nombre Cliente";
            // 
            // textBoxIdClienteFact
            // 
            this.textBoxIdClienteFact.Location = new System.Drawing.Point(692, 448);
            this.textBoxIdClienteFact.Name = "textBoxIdClienteFact";
            this.textBoxIdClienteFact.ShortcutsEnabled = false;
            this.textBoxIdClienteFact.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdClienteFact.TabIndex = 35;
            this.textBoxIdClienteFact.TextChanged += new System.EventHandler(this.textBoxIdClienteFact_TextChanged);
            this.textBoxIdClienteFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdClienteFactkeyPress);
            // 
            // textBoxNombreAlumnoFact
            // 
            this.textBoxNombreAlumnoFact.Enabled = false;
            this.textBoxNombreAlumnoFact.Location = new System.Drawing.Point(499, 507);
            this.textBoxNombreAlumnoFact.Name = "textBoxNombreAlumnoFact";
            this.textBoxNombreAlumnoFact.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreAlumnoFact.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nombre Alumno";
            // 
            // textBoxIdAlumnoFact
            // 
            this.textBoxIdAlumnoFact.Enabled = false;
            this.textBoxIdAlumnoFact.Location = new System.Drawing.Point(499, 447);
            this.textBoxIdAlumnoFact.Name = "textBoxIdAlumnoFact";
            this.textBoxIdAlumnoFact.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdAlumnoFact.TabIndex = 32;
            // 
            // textBoxNombreEncargadoFact
            // 
            this.textBoxNombreEncargadoFact.Enabled = false;
            this.textBoxNombreEncargadoFact.Location = new System.Drawing.Point(33, 150);
            this.textBoxNombreEncargadoFact.Name = "textBoxNombreEncargadoFact";
            this.textBoxNombreEncargadoFact.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombreEncargadoFact.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre Empleado";
            // 
            // textBoxIdEmpleadoFact
            // 
            this.textBoxIdEmpleadoFact.Enabled = false;
            this.textBoxIdEmpleadoFact.Location = new System.Drawing.Point(33, 94);
            this.textBoxIdEmpleadoFact.Name = "textBoxIdEmpleadoFact";
            this.textBoxIdEmpleadoFact.Size = new System.Drawing.Size(122, 20);
            this.textBoxIdEmpleadoFact.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Forma de Pago";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "Atras";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(690, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "ID Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "ID Alumno";
            // 
            // dataGridViewAlumnoFactura
            // 
            this.dataGridViewAlumnoFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnoFactura.Location = new System.Drawing.Point(219, 129);
            this.dataGridViewAlumnoFactura.Name = "dataGridViewAlumnoFactura";
            this.dataGridViewAlumnoFactura.Size = new System.Drawing.Size(573, 260);
            this.dataGridViewAlumnoFactura.TabIndex = 51;
            this.dataGridViewAlumnoFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlumnoFactura_CellClick);
            this.dataGridViewAlumnoFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlumnoFactura_CellContentClick);
            // 
            // textBoxIdAlumnoCob
            // 
            this.textBoxIdAlumnoCob.Location = new System.Drawing.Point(276, 103);
            this.textBoxIdAlumnoCob.Name = "textBoxIdAlumnoCob";
            this.textBoxIdAlumnoCob.Size = new System.Drawing.Size(102, 20);
            this.textBoxIdAlumnoCob.TabIndex = 50;
            this.textBoxIdAlumnoCob.TextChanged += new System.EventHandler(this.textBoxIdAlumnoCob_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Id Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Fecha Factura";
            // 
            // ErrorEB
            // 
            this.ErrorEB.ContainerControl = this;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAlumnoFactura);
            this.Controls.Add(this.textBoxIdAlumnoCob);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxBus);
            this.Controls.Add(this.checkBoxMensualidad);
            this.Controls.Add(this.checkBoxMatricula);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lable9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxNombreClienteFact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxIdClienteFact);
            this.Controls.Add(this.textBoxNombreAlumnoFact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxIdAlumnoFact);
            this.Controls.Add(this.textBoxNombreEncargadoFact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdEmpleadoFact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnoFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxBus;
        private System.Windows.Forms.CheckBox checkBoxMensualidad;
        private System.Windows.Forms.CheckBox checkBoxMatricula;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lable9;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox textBoxNombreClienteFact;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxIdClienteFact;
        public System.Windows.Forms.TextBox textBoxNombreAlumnoFact;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxIdAlumnoFact;
        public System.Windows.Forms.TextBox textBoxNombreEncargadoFact;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxIdEmpleadoFact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridViewAlumnoFactura;
        private System.Windows.Forms.TextBox textBoxIdAlumnoCob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorEB;
    }
}