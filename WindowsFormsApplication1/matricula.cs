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
    public partial class matricula : Form
    {
        public matricula()
        {
            InitializeComponent();
        }

        private void btnPrimerIngreso_Click(object sender, EventArgs e)
        {
            primerIngreso irPrimerIngreso = new primerIngreso();
            irPrimerIngreso.Show();
            this.Hide();
        }

        private void btnReingreso_Click(object sender, EventArgs e)
        {
            Reingresocs irReingreso = new Reingresocs();
            irReingreso.Show();
            this.Hide();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            FormLogin irLogin = new FormLogin();
            irLogin.Show();
            this.Hide();
        }

        private void buttonAtrasRegistro_Click(object sender, EventArgs e)
        {
            secretaria irSecretaria = new secretaria();
            irSecretaria.Show();
            this.Hide();
        }
    }
}
