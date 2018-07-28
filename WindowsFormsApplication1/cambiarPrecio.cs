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
    public partial class cambiarPrecio : Form
    {
        public cambiarPrecio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cobranza irCobranza = new Cobranza();
            irCobranza.Show();
            this.Hide();
        }

        private void comboBoxTipoPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCambiarPrecio_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoPrecio.Text == "Matricula")
            {
                textBoxIn.Text = "1";
            }
            if (comboBoxTipoPrecio.Text == "Mensualidad")
            {
                textBoxIn.Text = "2";
            }
            if (comboBoxTipoPrecio.Text == "Bus")
            {
                textBoxIn.Text = "3";
            }

            int codPrecio;
            codPrecio = Int32.Parse(textBoxIn.Text);
            float nuevoPrecio;
            nuevoPrecio = float.Parse(textBoxPrecio.Text);

            DataClasses1DataContext db = new DataClasses1DataContext();
            db.modificarPrecio(codPrecio, nuevoPrecio);

            MessageBox.Show("El precio se ha actualizado", "Mensaje");
            textBoxPrecio.Clear();

        }
    }
}
