namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAtrasRegistro = new System.Windows.Forms.Button();
            this.dataGridViewEmpleado = new System.Windows.Forms.DataGridView();
            this.textBoxIdEmpleadoMod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombreEmpleadoMod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDireccionEmpleadoMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTelefonoEmpleadoMod = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoEmergenciaEmpleadoMod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCorreoEmpleadoMod = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEliminarEmpleado = new System.Windows.Forms.Button();
            this.textBoxUsuarioEmpleadoMod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPuestoEmpleadoMod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ErrorEB = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxPuestoEmpleadoMod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEB)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(22, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(681, 50);
            this.label10.TabIndex = 25;
            this.label10.Text = "Modificar un Empleado o Usuario";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(920, 580);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 63);
            this.button1.TabIndex = 33;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataMember = "Empleado";
            // 
            // buttonAtrasRegistro
            // 
            this.buttonAtrasRegistro.BackColor = System.Drawing.Color.DarkRed;
            this.buttonAtrasRegistro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrasRegistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAtrasRegistro.Location = new System.Drawing.Point(26, 580);
            this.buttonAtrasRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAtrasRegistro.Name = "buttonAtrasRegistro";
            this.buttonAtrasRegistro.Size = new System.Drawing.Size(122, 63);
            this.buttonAtrasRegistro.TabIndex = 35;
            this.buttonAtrasRegistro.Text = "Atras";
            this.buttonAtrasRegistro.UseVisualStyleBackColor = false;
            this.buttonAtrasRegistro.Click += new System.EventHandler(this.buttonAtrasRegistro_Click);
            // 
            // dataGridViewEmpleado
            // 
            this.dataGridViewEmpleado.AllowUserToAddRows = false;
            this.dataGridViewEmpleado.AllowUserToDeleteRows = false;
            this.dataGridViewEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleado.Location = new System.Drawing.Point(46, 231);
            this.dataGridViewEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEmpleado.Name = "dataGridViewEmpleado";
            this.dataGridViewEmpleado.ReadOnly = true;
            this.dataGridViewEmpleado.Size = new System.Drawing.Size(978, 151);
            this.dataGridViewEmpleado.TabIndex = 36;
            this.dataGridViewEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleado_CellContentClick);
            // 
            // textBoxIdEmpleadoMod
            // 
            this.textBoxIdEmpleadoMod.Location = new System.Drawing.Point(46, 201);
            this.textBoxIdEmpleadoMod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdEmpleadoMod.MaxLength = 15;
            this.textBoxIdEmpleadoMod.Name = "textBoxIdEmpleadoMod";
            this.textBoxIdEmpleadoMod.Size = new System.Drawing.Size(177, 22);
            this.textBoxIdEmpleadoMod.TabIndex = 37;
            this.textBoxIdEmpleadoMod.TextChanged += new System.EventHandler(this.textBoxIdEmpleadoMod_TextChanged);
            this.textBoxIdEmpleadoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdEmpleadoMod_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(42, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "ID Empleado";
            // 
            // textBoxNombreEmpleadoMod
            // 
            this.textBoxNombreEmpleadoMod.Location = new System.Drawing.Point(64, 421);
            this.textBoxNombreEmpleadoMod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreEmpleadoMod.MaxLength = 50;
            this.textBoxNombreEmpleadoMod.Name = "textBoxNombreEmpleadoMod";
            this.textBoxNombreEmpleadoMod.ShortcutsEnabled = false;
            this.textBoxNombreEmpleadoMod.Size = new System.Drawing.Size(185, 22);
            this.textBoxNombreEmpleadoMod.TabIndex = 47;
            this.textBoxNombreEmpleadoMod.TextChanged += new System.EventHandler(this.textBoxNombreEmpleadoMod_TextChanged);
            this.textBoxNombreEmpleadoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreEmpleadoMod_KeyPress);
            this.textBoxNombreEmpleadoMod.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxNombreEmpleadoMod_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(60, 399);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nombre Empleado";
            // 
            // textBoxDireccionEmpleadoMod
            // 
            this.textBoxDireccionEmpleadoMod.Location = new System.Drawing.Point(64, 530);
            this.textBoxDireccionEmpleadoMod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDireccionEmpleadoMod.MaxLength = 50;
            this.textBoxDireccionEmpleadoMod.Name = "textBoxDireccionEmpleadoMod";
            this.textBoxDireccionEmpleadoMod.ShortcutsEnabled = false;
            this.textBoxDireccionEmpleadoMod.Size = new System.Drawing.Size(185, 22);
            this.textBoxDireccionEmpleadoMod.TabIndex = 50;
            this.textBoxDireccionEmpleadoMod.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(60, 506);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(60, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "Telefono ";
            // 
            // textBoxTelefonoEmpleadoMod
            // 
            this.textBoxTelefonoEmpleadoMod.Location = new System.Drawing.Point(64, 472);
            this.textBoxTelefonoEmpleadoMod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelefonoEmpleadoMod.MaxLength = 15;
            this.textBoxTelefonoEmpleadoMod.Name = "textBoxTelefonoEmpleadoMod";
            this.textBoxTelefonoEmpleadoMod.ShortcutsEnabled = false;
            this.textBoxTelefonoEmpleadoMod.Size = new System.Drawing.Size(177, 22);
            this.textBoxTelefonoEmpleadoMod.TabIndex = 53;
            this.textBoxTelefonoEmpleadoMod.TextChanged += new System.EventHandler(this.textBoxTelefonoEmpleadoMod_TextChanged);
            this.textBoxTelefonoEmpleadoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdEmpleadoMod_KeyPress);
            // 
            // textBoxTelefonoEmergenciaEmpleadoMod
            // 
            this.textBoxTelefonoEmergenciaEmpleadoMod.Location = new System.Drawing.Point(460, 421);
            this.textBoxTelefonoEmergenciaEmpleadoMod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelefonoEmergenciaEmpleadoMod.MaxLength = 15;
            this.textBoxTelefonoEmergenciaEmpleadoMod.Name = "textBoxTelefonoEmergenciaEmpleadoMod";
            this.textBoxTelefonoEmergenciaEmpleadoMod.ShortcutsEnabled = false;
            this.textBoxTelefonoEmergenciaEmpleadoMod.Size = new System.Drawing.Size(185, 22);
            this.textBoxTelefonoEmergenciaEmpleadoMod.TabIndex = 54;
            this.textBoxTelefonoEmergenciaEmpleadoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdEmpleadoMod_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(448, 399);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 24);
            this.label7.TabIndex = 55;
            this.label7.Text = "Telefono Emergencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(456, 447);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "Correo";
            // 
            // textBoxCorreoEmpleadoMod
            // 
            this.textBoxCorreoEmpleadoMod.Location = new System.Drawing.Point(460, 469);
            this.textBoxCorreoEmpleadoMod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCorreoEmpleadoMod.MaxLength = 30;
            this.textBoxCorreoEmpleadoMod.Name = "textBoxCorreoEmpleadoMod";
            this.textBoxCorreoEmpleadoMod.ShortcutsEnabled = false;
            this.textBoxCorreoEmpleadoMod.Size = new System.Drawing.Size(185, 22);
            this.textBoxCorreoEmpleadoMod.TabIndex = 57;
            this.textBoxCorreoEmpleadoMod.TextChanged += new System.EventHandler(this.textBoxCorreoEmpleadoMod_TextChanged);
            this.textBoxCorreoEmpleadoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCorreoEmpleadoMod_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(452, 580);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 63);
            this.button2.TabIndex = 58;
            this.button2.Text = "Guardar Cambios";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEliminarEmpleado
            // 
            this.buttonEliminarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminarEmpleado.Location = new System.Drawing.Point(834, 477);
            this.buttonEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminarEmpleado.Name = "buttonEliminarEmpleado";
            this.buttonEliminarEmpleado.Size = new System.Drawing.Size(146, 75);
            this.buttonEliminarEmpleado.TabIndex = 59;
            this.buttonEliminarEmpleado.Text = "Eliminar Empleado";
            this.buttonEliminarEmpleado.UseVisualStyleBackColor = false;
            this.buttonEliminarEmpleado.Click += new System.EventHandler(this.buttonEliminarEmpleado_Click);
            // 
            // textBoxUsuarioEmpleadoMod
            // 
            this.textBoxUsuarioEmpleadoMod.Location = new System.Drawing.Point(834, 421);
            this.textBoxUsuarioEmpleadoMod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuarioEmpleadoMod.MaxLength = 15;
            this.textBoxUsuarioEmpleadoMod.Name = "textBoxUsuarioEmpleadoMod";
            this.textBoxUsuarioEmpleadoMod.ShortcutsEnabled = false;
            this.textBoxUsuarioEmpleadoMod.Size = new System.Drawing.Size(185, 22);
            this.textBoxUsuarioEmpleadoMod.TabIndex = 60;
            this.textBoxUsuarioEmpleadoMod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(830, 399);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 61;
            this.label8.Text = "Usuario";
            // 
            // comboBoxPuestoEmpleadoMod
            // 
            this.comboBoxPuestoEmpleadoMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPuestoEmpleadoMod.FormattingEnabled = true;
            this.comboBoxPuestoEmpleadoMod.Items.AddRange(new object[] {
            "Profesor",
            "Secretaria",
            "Administrador",
            "Chofer",
            "Personal de Limpieza"});
            this.comboBoxPuestoEmpleadoMod.Location = new System.Drawing.Point(460, 531);
            this.comboBoxPuestoEmpleadoMod.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPuestoEmpleadoMod.Name = "comboBoxPuestoEmpleadoMod";
            this.comboBoxPuestoEmpleadoMod.Size = new System.Drawing.Size(185, 24);
            this.comboBoxPuestoEmpleadoMod.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(456, 503);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 24);
            this.label9.TabIndex = 63;
            this.label9.Text = "Puesto";
            // 
            // ErrorEB
            // 
            this.ErrorEB.ContainerControl = this;
            // 
            // textBoxPuestoEmpleadoMod
            // 
            this.textBoxPuestoEmpleadoMod.Location = new System.Drawing.Point(496, 201);
            this.textBoxPuestoEmpleadoMod.Name = "textBoxPuestoEmpleadoMod";
            this.textBoxPuestoEmpleadoMod.Size = new System.Drawing.Size(42, 22);
            this.textBoxPuestoEmpleadoMod.TabIndex = 64;
            this.textBoxPuestoEmpleadoMod.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 666);
            this.Controls.Add(this.textBoxPuestoEmpleadoMod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxPuestoEmpleadoMod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxUsuarioEmpleadoMod);
            this.Controls.Add(this.buttonEliminarEmpleado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxCorreoEmpleadoMod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTelefonoEmergenciaEmpleadoMod);
            this.Controls.Add(this.textBoxTelefonoEmpleadoMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDireccionEmpleadoMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombreEmpleadoMod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdEmpleadoMod);
            this.Controls.Add(this.dataGridViewEmpleado);
            this.Controls.Add(this.buttonAtrasRegistro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Modificar Empleados o Usuarios";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.BindingSource empleadoBindingSource;
      
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
        
        private System.Windows.Forms.Button buttonAtrasRegistro;
        private System.Windows.Forms.DataGridView dataGridViewEmpleado;
        private System.Windows.Forms.TextBox textBoxIdEmpleadoMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombreEmpleadoMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDireccionEmpleadoMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTelefonoEmpleadoMod;
        private System.Windows.Forms.TextBox textBoxTelefonoEmergenciaEmpleadoMod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCorreoEmpleadoMod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEliminarEmpleado;
        private System.Windows.Forms.TextBox textBoxUsuarioEmpleadoMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPuestoEmpleadoMod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider ErrorEB;
        private System.Windows.Forms.TextBox textBoxPuestoEmpleadoMod;
    }
}