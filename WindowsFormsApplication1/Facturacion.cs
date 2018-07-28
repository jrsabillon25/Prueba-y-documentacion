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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secretaria irSecretaria = new secretaria();
            irSecretaria.Show();
            this.Close();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            /*Cobranza cob = new Cobranza();
            DataGridViewRow dgv = cob.dataGridViewAlumnoFactura.Rows[e.RowIndex];
            textBoxIdAlumnoFact.Text = dgv.Cells[1].Value.ToString();
            textBoxNombreAlumnoFact.Text = dgv.Cells[2].Value.ToString();*/
        }

        private void textBoxIdAlumnoCob_TextChanged(object sender, EventArgs e)
        {

            conexion cn = new conexion();
            string id = textBoxIdAlumnoCob.Text;
            string str = string.Format("select codigo_alumno, id_alumno, nombre_alumno from Alumno where id_alumno like '{0}%'", id);
            if (textBoxIdAlumnoCob.Text != "")
            {
                cn.consulta(str, "Alumno");
                dataGridViewAlumnoFactura.DataSource = cn.ds.Tables["Alumno"];
            }
            else
            {
                cn.consulta("select codigo_alumno, id_alumno, nombre_alumno from Alumno", "Alumno");
                dataGridViewAlumnoFactura.DataSource = cn.ds.Tables["Alumno"];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin ir = new FormLogin();
            ir.Show();
            this.Hide();
        }

        public bool validarEB()
        {

            bool noError = true;
            int count = 0;


            count = count + 1;

            if (count != 0)
            {
                ErrorEB.Clear();
            }

            if (textBoxIdClienteFact.Text == "")
            {

                ErrorEB.SetError(textBoxIdClienteFact, "Ingrese el ID");


                noError = false;
            }

            if (textBoxNombreClienteFact.Text == "")
            {

                ErrorEB.SetError(textBoxNombreClienteFact, "Ingrese el el nombre");


                noError = false;
            }

            return noError;
        }


        private void dataGridViewAlumnoFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewAlumnoFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridViewAlumnoFactura.Rows[e.RowIndex];
            textBoxIdAlumnoFact.Text = dgv.Cells[1].Value.ToString();
            textBoxNombreAlumnoFact.Text = dgv.Cells[2].Value.ToString();
        }

        private void checkBoxMatricula_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validarEB())
            {
                float total = 0;
                if (checkBoxMatricula.Checked == true)
                {
                    total = total + 3000;
                }
                if (checkBoxMensualidad.Checked == true)
                {
                    total = total + 4000;
                }
                if (checkBoxBus.Checked == true)
                {
                    total = total + 1000;
                }
            }
        }

        private void textBoxNombreClienteFact_TextChanged(object sender, EventArgs e)
        {
          

            
        }

        private void textBoxIdClienteFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreClienteFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void textBoxIdClienteFactkeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }
    }
}
