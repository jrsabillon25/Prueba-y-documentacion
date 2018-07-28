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
    public partial class Cobranza : Form
    {
        public Cobranza()
        {
            InitializeComponent();
        }

        private void dataGridViewAlumnoFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Facturacion fact = new Facturacion();

            DataGridViewRow dgv = dataGridViewAlumnoFactura.Rows[e.RowIndex];
            fact.textBoxIdAlumnoFact.Text = dgv.Cells[1].Value.ToString();
            fact.textBoxNombreAlumnoFact.Text = dgv.Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cambiarPrecio irCambiarPrecio = new cambiarPrecio();
            irCambiarPrecio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturacion irFactura = new Facturacion();
            irFactura.Show();
            this.Close();

            
        }

        private void Cobranza_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               conexion cn = new conexion();
               string id = textBoxIdAlumnoCob.Text;
               string str = string.Format("select codigo_alumno, id_alumno, nombre_alumno from Alumno where id_alumno like '{0}%'", id);
               if (textBoxIdAlumnoCob.Text != "")
               {
                   cn.consulta(str , "Alumno");
                   dataGridViewAlumnoFactura.DataSource = cn.ds.Tables["Alumno"];
               } 
               else
               {
                   cn.consulta("select codigo_alumno, id_alumno, nombre_alumno from Alumno", "Alumno");
                   dataGridViewAlumnoFactura.DataSource = cn.ds.Tables["Alumno"];
               }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
