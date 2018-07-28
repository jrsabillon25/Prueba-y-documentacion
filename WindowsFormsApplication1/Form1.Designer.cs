namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxEmergencia = new System.Windows.Forms.TextBox();
            this.textBoxtelefono = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPuesto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonModificarEmpleado = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonAtrasRegistro = new System.Windows.Forms.Button();
            this.ErrorEB = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Gold;
            this.buttonGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardar.Location = new System.Drawing.Point(382, 477);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(106, 54);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(33, 202);
            this.textBoxId.MaxLength = 15;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ShortcutsEnabled = false;
            this.textBoxId.Size = new System.Drawing.Size(153, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCorreo.Location = new System.Drawing.Point(323, 202);
            this.textBoxCorreo.MaxLength = 50;
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.ShortcutsEnabled = false;
            this.textBoxCorreo.Size = new System.Drawing.Size(165, 20);
            this.textBoxCorreo.TabIndex = 3;
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(602, 202);
            this.textBoxDireccion.MaxLength = 50;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.ShortcutsEnabled = false;
            this.textBoxDireccion.Size = new System.Drawing.Size(153, 20);
            this.textBoxDireccion.TabIndex = 5;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBoxDireccion_TextChanged);
            this.textBoxDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDireccion_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(33, 258);
            this.textBoxNombre.MaxLength = 50;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ShortcutsEnabled = false;
            this.textBoxNombre.Size = new System.Drawing.Size(153, 20);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombretextBoxNombre_KeyPress);
            // 
            // textBoxEmergencia
            // 
            this.textBoxEmergencia.Location = new System.Drawing.Point(602, 258);
            this.textBoxEmergencia.MaxLength = 15;
            this.textBoxEmergencia.Name = "textBoxEmergencia";
            this.textBoxEmergencia.ShortcutsEnabled = false;
            this.textBoxEmergencia.Size = new System.Drawing.Size(153, 20);
            this.textBoxEmergencia.TabIndex = 6;
            this.textBoxEmergencia.TextChanged += new System.EventHandler(this.textBoxEmergencia_TextChanged);
            this.textBoxEmergencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmergencia_KeyPress);
            // 
            // textBoxtelefono
            // 
            this.textBoxtelefono.Location = new System.Drawing.Point(323, 258);
            this.textBoxtelefono.MaxLength = 15;
            this.textBoxtelefono.Name = "textBoxtelefono";
            this.textBoxtelefono.ShortcutsEnabled = false;
            this.textBoxtelefono.Size = new System.Drawing.Size(165, 20);
            this.textBoxtelefono.TabIndex = 4;
            this.textBoxtelefono.TextChanged += new System.EventHandler(this.textBoxtelefono_TextChanged);
            this.textBoxtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxtelefonotextBoxtelefono_KeyPress);
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Enabled = false;
            this.textBoxContrasena.Location = new System.Drawing.Point(602, 363);
            this.textBoxContrasena.MaxLength = 20;
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.ShortcutsEnabled = false;
            this.textBoxContrasena.Size = new System.Drawing.Size(153, 20);
            this.textBoxContrasena.TabIndex = 8;
            this.textBoxContrasena.TextChanged += new System.EventHandler(this.textBoxContrasena_TextChanged);
            this.textBoxContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContrasena_KeyPress);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Enabled = false;
            this.textBoxUsuario.Location = new System.Drawing.Point(602, 314);
            this.textBoxUsuario.MaxLength = 15;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ShortcutsEnabled = false;
            this.textBoxUsuario.Size = new System.Drawing.Size(153, 20);
            this.textBoxUsuario.TabIndex = 7;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            this.textBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(34, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(34, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(326, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(326, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefono";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(610, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefono Emergencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(608, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(610, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(608, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Contraseña";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(46, 23);
            this.radioButtonSi.TabIndex = 0;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "Si ";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            this.radioButtonSi.CheckedChanged += new System.EventHandler(this.radioButtonSi_CheckedChanged);
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Location = new System.Drawing.Point(7, 51);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(53, 23);
            this.radioButtonNO.TabIndex = 1;
            this.radioButtonNO.TabStop = true;
            this.radioButtonNO.Text = "No ";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            this.radioButtonNO.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Profesor",
            "Secretaria",
            "Administrador",
            "Chofer",
            "Personal de Limpieza"});
            this.comboBox1.Location = new System.Drawing.Point(33, 313);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(34, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Puesto";
            // 
            // textBoxPuesto
            // 
            this.textBoxPuesto.Enabled = false;
            this.textBoxPuesto.Location = new System.Drawing.Point(33, 348);
            this.textBoxPuesto.Name = "textBoxPuesto";
            this.textBoxPuesto.Size = new System.Drawing.Size(153, 20);
            this.textBoxPuesto.TabIndex = 21;
            this.textBoxPuesto.Visible = false;
            this.textBoxPuesto.TextChanged += new System.EventHandler(this.textBoxPuesto_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonNO);
            this.groupBox1.Controls.Add(this.radioButtonSi);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(323, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 81);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Tendra Usuario?";
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            // 
            // buttonModificarEmpleado
            // 
            this.buttonModificarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonModificarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonModificarEmpleado.Location = new System.Drawing.Point(24, 383);
            this.buttonModificarEmpleado.Name = "buttonModificarEmpleado";
            this.buttonModificarEmpleado.Size = new System.Drawing.Size(153, 56);
            this.buttonModificarEmpleado.TabIndex = 25;
            this.buttonModificarEmpleado.Text = "Modificar Empleado o Usuario ";
            this.buttonModificarEmpleado.UseVisualStyleBackColor = false;
            this.buttonModificarEmpleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(10, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(520, 39);
            this.label12.TabIndex = 31;
            this.label12.Text = "Ingresar un Empleado o Usuario";
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalir.Location = new System.Drawing.Point(736, 477);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(92, 54);
            this.buttonSalir.TabIndex = 32;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonAtrasRegistro
            // 
            this.buttonAtrasRegistro.BackColor = System.Drawing.Color.DarkRed;
            this.buttonAtrasRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrasRegistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAtrasRegistro.Location = new System.Drawing.Point(16, 477);
            this.buttonAtrasRegistro.Name = "buttonAtrasRegistro";
            this.buttonAtrasRegistro.Size = new System.Drawing.Size(97, 54);
            this.buttonAtrasRegistro.TabIndex = 36;
            this.buttonAtrasRegistro.Text = "Atras";
            this.buttonAtrasRegistro.UseVisualStyleBackColor = false;
            this.buttonAtrasRegistro.Click += new System.EventHandler(this.buttonAtrasRegistro_Click);
            // 
            // ErrorEB
            // 
            this.ErrorEB.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 542);
            this.Controls.Add(this.buttonAtrasRegistro);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonModificarEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxPuesto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxtelefono);
            this.Controls.Add(this.textBoxEmergencia);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonGuardar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxEmergencia;
        private System.Windows.Forms.TextBox textBoxtelefono;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonSi;
        private System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPuesto;
        private System.Windows.Forms.GroupBox groupBox1;
      
        private System.Windows.Forms.BindingSource empleadoBindingSource;
      
        private System.Windows.Forms.Button buttonModificarEmpleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonAtrasRegistro;
        private System.Windows.Forms.ErrorProvider ErrorEB;
    }
}

