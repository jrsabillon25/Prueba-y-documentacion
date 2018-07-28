namespace WindowsFormsApplication1
{
    partial class cambiarPrecio
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoPrecio = new System.Windows.Forms.ComboBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.buttonCambiarPrecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 13;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(291, 196);
            this.textBoxIn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(37, 20);
            this.textBoxIn.TabIndex = 12;
            this.textBoxIn.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nuevo Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo de Servicio";
            // 
            // comboBoxTipoPrecio
            // 
            this.comboBoxTipoPrecio.FormattingEnabled = true;
            this.comboBoxTipoPrecio.Items.AddRange(new object[] {
            "Matricula",
            "Mensualidad",
            "Bus"});
            this.comboBoxTipoPrecio.Location = new System.Drawing.Point(66, 129);
            this.comboBoxTipoPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipoPrecio.Name = "comboBoxTipoPrecio";
            this.comboBoxTipoPrecio.Size = new System.Drawing.Size(118, 21);
            this.comboBoxTipoPrecio.TabIndex = 9;
            this.comboBoxTipoPrecio.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoPrecio_SelectedIndexChanged);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(66, 196);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(118, 20);
            this.textBoxPrecio.TabIndex = 8;
            // 
            // buttonCambiarPrecio
            // 
            this.buttonCambiarPrecio.Location = new System.Drawing.Point(169, 278);
            this.buttonCambiarPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCambiarPrecio.Name = "buttonCambiarPrecio";
            this.buttonCambiarPrecio.Size = new System.Drawing.Size(56, 19);
            this.buttonCambiarPrecio.TabIndex = 7;
            this.buttonCambiarPrecio.Text = "Guardar";
            this.buttonCambiarPrecio.UseVisualStyleBackColor = true;
            this.buttonCambiarPrecio.Click += new System.EventHandler(this.buttonCambiarPrecio_Click);
            // 
            // cambiarPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTipoPrecio);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.buttonCambiarPrecio);
            this.Name = "cambiarPrecio";
            this.Text = "cambiarPrecio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoPrecio;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button buttonCambiarPrecio;
    }
}