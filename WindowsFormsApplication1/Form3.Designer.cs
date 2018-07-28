namespace WindowsFormsApplication1
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistrarUsuarioMenu = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 50);
            this.label2.TabIndex = 35;
            this.label2.Text = "Menu Administrador";
            // 
            // buttonRegistrarUsuarioMenu
            // 
            this.buttonRegistrarUsuarioMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRegistrarUsuarioMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarUsuarioMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegistrarUsuarioMenu.Location = new System.Drawing.Point(436, 267);
            this.buttonRegistrarUsuarioMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistrarUsuarioMenu.Name = "buttonRegistrarUsuarioMenu";
            this.buttonRegistrarUsuarioMenu.Size = new System.Drawing.Size(225, 134);
            this.buttonRegistrarUsuarioMenu.TabIndex = 33;
            this.buttonRegistrarUsuarioMenu.Text = "Registrar o Modificar Empleado";
            this.buttonRegistrarUsuarioMenu.UseVisualStyleBackColor = false;
            this.buttonRegistrarUsuarioMenu.Click += new System.EventHandler(this.buttonRegistrarUsuarioMenu_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalir.Location = new System.Drawing.Point(926, 562);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(116, 63);
            this.buttonSalir.TabIndex = 36;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 655);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRegistrarUsuarioMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin";
            this.Text = "Administardor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegistrarUsuarioMenu;
        private System.Windows.Forms.Button buttonSalir;
    }
}