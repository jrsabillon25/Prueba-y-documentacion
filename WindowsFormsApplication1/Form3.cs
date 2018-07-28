using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void buttonRegistrarUsuarioMenu_Click(object sender, EventArgs e)
        {
            Form1 ir = new Form1();
            ir.Show();
            this.Hide();

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            FormLogin irLogin = new FormLogin();
            irLogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transporte irtransporte = new Transporte();
            irtransporte.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
