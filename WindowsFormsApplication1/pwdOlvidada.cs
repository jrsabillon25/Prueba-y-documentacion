using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class pwdOlvidada : Form
    {
        public string user;
        public pwdOlvidada()
        {
            InitializeComponent();
        }

        private void btnPregunta_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");
                Class1 cl = new Class1();

                string var = txtPregunta.Text;
                string qry = string.Format("select * from [dbo].[Empleado] where Respuesta = '{0}'", cl.Encrypt(var));
                //string selectAns = string.Format("select")
                SqlCommand cmd = new SqlCommand(qry, conn);

                conn.Open();
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    nuevaContraseña frm = new nuevaContraseña();
                    frm.user = this.user;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Respuesta de seguridad incorrecta", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPregunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPregunta_Click(object sender, EventArgs e)
        {

        }

        private void pwdOlvidada_Load(object sender, EventArgs e)
        {
            txtPregunta.MaxLength = 16;
            txtPregunta.PasswordChar = '*';
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");
                string qry = string.Format("select Pregunta_Seguridad from Preguntas_Seguridad a join Empleado b on a.codPregunta = b.codPregunta where usr_empleado = '{0}'", user);
                SqlCommand cmd = new SqlCommand(qry, conn);
                conn.Open();
                SqlDataReader read = null;
                read = cmd.ExecuteReader();

                if (read.Read())
                {
                    lblPregunta.Text = Convert.ToString(read["Pregunta_Seguridad"]);
                }

                conn.Close();
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPregunta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SinEspacios(e);
        }

        private void txtPregunta_Validated(object sender, EventArgs e)
        {
            if (txtPregunta.TextLength == 0)
            {
                errorProvider1.SetError(txtPregunta, "No puede dejar este campo vacio");
            }
        }
    }
}
