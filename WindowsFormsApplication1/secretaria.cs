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
    public partial class secretaria : Form
    {
        public secretaria()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            matricula irMatricula = new matricula();
            irMatricula.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            estados irEstado = new estados();
            irEstado.Show();
            this.Hide();

        }

        private void secretaria_Load(object sender, EventArgs e)
        {

        }

        private void buttonFacturar_Click(object sender, EventArgs e)
        {
            Facturacion irFactura = new Facturacion();
            irFactura.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cambiarPrecio irCambio = new cambiarPrecio();
            irCambio.Show();
            this.Hide();
        }
    }
}
