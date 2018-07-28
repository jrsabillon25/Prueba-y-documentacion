namespace WindowsFormsApplication1
{
    partial class nuevaContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevaContraseña));
            this.chkPass2 = new System.Windows.Forms.CheckBox();
            this.chkPass1 = new System.Windows.Forms.CheckBox();
            this.txtconfirmNewContra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewContra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPass2
            // 
            this.chkPass2.AutoSize = true;
            this.chkPass2.Location = new System.Drawing.Point(638, 274);
            this.chkPass2.Margin = new System.Windows.Forms.Padding(4);
            this.chkPass2.Name = "chkPass2";
            this.chkPass2.Size = new System.Drawing.Size(18, 17);
            this.chkPass2.TabIndex = 26;
            this.chkPass2.UseVisualStyleBackColor = true;
            this.chkPass2.CheckedChanged += new System.EventHandler(this.chkPass2_CheckedChanged);
            // 
            // chkPass1
            // 
            this.chkPass1.AutoSize = true;
            this.chkPass1.Location = new System.Drawing.Point(638, 230);
            this.chkPass1.Margin = new System.Windows.Forms.Padding(4);
            this.chkPass1.Name = "chkPass1";
            this.chkPass1.Size = new System.Drawing.Size(18, 17);
            this.chkPass1.TabIndex = 25;
            this.chkPass1.UseVisualStyleBackColor = true;
            this.chkPass1.CheckedChanged += new System.EventHandler(this.chkPass1_CheckedChanged);
            // 
            // txtconfirmNewContra
            // 
            this.txtconfirmNewContra.Location = new System.Drawing.Point(395, 271);
            this.txtconfirmNewContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirmNewContra.Name = "txtconfirmNewContra";
            this.txtconfirmNewContra.Size = new System.Drawing.Size(235, 22);
            this.txtconfirmNewContra.TabIndex = 24;
            this.txtconfirmNewContra.TextChanged += new System.EventHandler(this.txtconfirmNewContra_TextChanged);
            this.txtconfirmNewContra.Leave += new System.EventHandler(this.txtconfirmNewContra_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(117, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = " Confirme Nueva Contraseña:";
            // 
            // txtNewContra
            // 
            this.txtNewContra.Location = new System.Drawing.Point(395, 226);
            this.txtNewContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewContra.Name = "txtNewContra";
            this.txtNewContra.Size = new System.Drawing.Size(235, 22);
            this.txtNewContra.TabIndex = 22;
            this.txtNewContra.TextChanged += new System.EventHandler(this.txtNewContra_TextChanged);
            this.txtNewContra.Leave += new System.EventHandler(this.txtNewContra_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(212, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nueva Contraseña:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(744, 505);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 63);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gold;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(435, 315);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 67);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(207, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 53);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nueva Contraseña";
            // 
            // nuevaContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkPass2);
            this.Controls.Add(this.chkPass1);
            this.Controls.Add(this.txtconfirmNewContra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNewContra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "nuevaContraseña";
            this.Text = "nuevaContraseña";
            this.Load += new System.EventHandler(this.nuevaContraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPass2;
        private System.Windows.Forms.CheckBox chkPass1;
        private System.Windows.Forms.TextBox txtconfirmNewContra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewContra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label1;
    }
}