namespace WindowsFormsApplication1
{
    partial class Transporte
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCodigoBus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonAtrasRegistro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxCodigoChofer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumeroBusE = new System.Windows.Forms.TextBox();
            this.textBoxPlacaBusE = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxDescripcioE = new System.Windows.Forms.TextBox();
            this.dataGridAgrarR = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewRutas = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridLARutas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodigoRbuscar = new System.Windows.Forms.TextBox();
            this.ErrorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorEB = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgrarR)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLARutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEB)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBoxCodigoBus);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonSalir);
            this.tabPage1.Controls.Add(this.buttonAtrasRegistro);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.TextBoxCodigoChofer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxNumeroBusE);
            this.tabPage1.Controls.Add(this.textBoxPlacaBusE);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBoxDescripcioE);
            this.tabPage1.Controls.Add(this.dataGridAgrarR);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Ruta";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Codigo Bus";
            // 
            // textBoxCodigoBus
            // 
            this.textBoxCodigoBus.Enabled = false;
            this.textBoxCodigoBus.Location = new System.Drawing.Point(20, 74);
            this.textBoxCodigoBus.Name = "textBoxCodigoBus";
            this.textBoxCodigoBus.ShortcutsEnabled = false;
            this.textBoxCodigoBus.Size = new System.Drawing.Size(75, 20);
            this.textBoxCodigoBus.TabIndex = 42;
            this.textBoxCodigoBus.TextChanged += new System.EventHandler(this.textBoxCodigoBus_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(406, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Buses:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Seleccionar Chofer:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(646, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(226, 126);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalir.Location = new System.Drawing.Point(837, 3);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(87, 30);
            this.buttonSalir.TabIndex = 38;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonAtrasRegistro
            // 
            this.buttonAtrasRegistro.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonAtrasRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrasRegistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAtrasRegistro.Location = new System.Drawing.Point(8, 6);
            this.buttonAtrasRegistro.Name = "buttonAtrasRegistro";
            this.buttonAtrasRegistro.Size = new System.Drawing.Size(87, 30);
            this.buttonAtrasRegistro.TabIndex = 37;
            this.buttonAtrasRegistro.Text = "Atras";
            this.buttonAtrasRegistro.UseVisualStyleBackColor = false;
            this.buttonAtrasRegistro.Click += new System.EventHandler(this.buttonAtrasRegistro_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(761, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxCodigoChofer
            // 
            this.TextBoxCodigoChofer.AutoSize = true;
            this.TextBoxCodigoChofer.Location = new System.Drawing.Point(115, 58);
            this.TextBoxCodigoChofer.Name = "TextBoxCodigoChofer";
            this.TextBoxCodigoChofer.Size = new System.Drawing.Size(74, 13);
            this.TextBoxCodigoChofer.TabIndex = 25;
            this.TextBoxCodigoChofer.Text = "Codigo Chofer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Placa de Bus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Numero de Bus";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Descripcion de la Ruta:";
            // 
            // textBoxNumeroBusE
            // 
            this.textBoxNumeroBusE.Location = new System.Drawing.Point(224, 278);
            this.textBoxNumeroBusE.MaxLength = 2;
            this.textBoxNumeroBusE.Name = "textBoxNumeroBusE";
            this.textBoxNumeroBusE.ShortcutsEnabled = false;
            this.textBoxNumeroBusE.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroBusE.TabIndex = 21;
            this.textBoxNumeroBusE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeroBusE_KeyPress);
            // 
            // textBoxPlacaBusE
            // 
            this.textBoxPlacaBusE.Location = new System.Drawing.Point(370, 278);
            this.textBoxPlacaBusE.MaxLength = 10;
            this.textBoxPlacaBusE.Name = "textBoxPlacaBusE";
            this.textBoxPlacaBusE.ShortcutsEnabled = false;
            this.textBoxPlacaBusE.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlacaBusE.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(111, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBoxDescripcioE
            // 
            this.textBoxDescripcioE.Location = new System.Drawing.Point(34, 278);
            this.textBoxDescripcioE.MaxLength = 50;
            this.textBoxDescripcioE.Name = "textBoxDescripcioE";
            this.textBoxDescripcioE.ShortcutsEnabled = false;
            this.textBoxDescripcioE.Size = new System.Drawing.Size(148, 20);
            this.textBoxDescripcioE.TabIndex = 18;
            // 
            // dataGridAgrarR
            // 
            this.dataGridAgrarR.AllowUserToAddRows = false;
            this.dataGridAgrarR.AllowUserToDeleteRows = false;
            this.dataGridAgrarR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAgrarR.Location = new System.Drawing.Point(20, 100);
            this.dataGridAgrarR.Name = "dataGridAgrarR";
            this.dataGridAgrarR.ReadOnly = true;
            this.dataGridAgrarR.Size = new System.Drawing.Size(599, 126);
            this.dataGridAgrarR.TabIndex = 17;
            this.dataGridAgrarR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAgrarR_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridViewRutas);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dataGridLARutas);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxCodigoRbuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(929, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de alumnos en Rutas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Alumnos en Rutas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(528, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Rutas:";
            // 
            // dataGridViewRutas
            // 
            this.dataGridViewRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRutas.Location = new System.Drawing.Point(531, 143);
            this.dataGridViewRutas.Name = "dataGridViewRutas";
            this.dataGridViewRutas.Size = new System.Drawing.Size(266, 132);
            this.dataGridViewRutas.TabIndex = 40;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SaddleBrown;
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(839, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 30);
            this.button6.TabIndex = 39;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SaddleBrown;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(0, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 30);
            this.button5.TabIndex = 38;
            this.button5.Text = "Atras";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridLARutas
            // 
            this.dataGridLARutas.AllowUserToAddRows = false;
            this.dataGridLARutas.AllowUserToDeleteRows = false;
            this.dataGridLARutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLARutas.Location = new System.Drawing.Point(40, 143);
            this.dataGridLARutas.Name = "dataGridLARutas";
            this.dataGridLARutas.ReadOnly = true;
            this.dataGridLARutas.Size = new System.Drawing.Size(414, 132);
            this.dataGridLARutas.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nombre Alumno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Id Alumno";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(655, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Agregrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(607, 84);
            this.textBox3.MaxLength = 50;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreA_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 84);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcodigoA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Codigo de Ruta";
            // 
            // textBoxCodigoRbuscar
            // 
            this.textBoxCodigoRbuscar.Location = new System.Drawing.Point(40, 84);
            this.textBoxCodigoRbuscar.MaxLength = 15;
            this.textBoxCodigoRbuscar.Name = "textBoxCodigoRbuscar";
            this.textBoxCodigoRbuscar.Size = new System.Drawing.Size(148, 20);
            this.textBoxCodigoRbuscar.TabIndex = 18;
            this.textBoxCodigoRbuscar.TextChanged += new System.EventHandler(this.textBoxCodigoRbuscar_TextChanged);
            this.textBoxCodigoRbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcodigoR_KeyPress);
            // 
            // ErrorID
            // 
            this.ErrorID.ContainerControl = this;
            // 
            // ErrorEB
            // 
            this.ErrorEB.ContainerControl = this;
            // 
            // Transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 372);
            this.Controls.Add(this.tabControl1);
            this.Name = "Transporte";
            this.Text = "Transporte";
            this.Load += new System.EventHandler(this.Transporte_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgrarR)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLARutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label TextBoxCodigoChofer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumeroBusE;
        private System.Windows.Forms.TextBox textBoxPlacaBusE;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxDescripcioE;
        private System.Windows.Forms.DataGridView dataGridAgrarR;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridLARutas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCodigoRbuscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAtrasRegistro;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCodigoBus;
        private System.Windows.Forms.DataGridView dataGridViewRutas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider ErrorID;
        private System.Windows.Forms.ErrorProvider ErrorEB;
    }
}