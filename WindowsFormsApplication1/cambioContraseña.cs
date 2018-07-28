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
    public partial class cambioContraseña : Form
    {
        public string user;
     //   SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");
        public cambioContraseña()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtconfirmNewContra.Text.Trim() == "" || txtNewContra.Text.Trim() == "" || txtRespuesta.Text.Trim() == ""))
                {
                    MessageBox.Show("no se permiten campos vacios");
                }
                else
                {
                    if (txtNewContra.Text == txtconfirmNewContra.Text)
                    {
                        if (txtconfirmNewContra.TextLength < 8)
                        {
                            MessageBox.Show("La contraseña debe contener al menos 8 caracteres");
                        }
                        else
                        {
                            int pregunta = cmbPregunta.SelectedIndex + 1;
                            Class1 cl = new Class1();
                            string password = cl.Encrypt(txtNewContra.Text);
                            string respuesta = cl.Encrypt(txtRespuesta.Text);
                            SqlConnection cnn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");
       
                            string qry = string.Format("Update Empleado set codPregunta = {0}, Respuesta = '{1}', pwd_empleado = '{2}', codigo_estado = 1 where usr_empleado = '{3}'", pregunta, respuesta, password, user);
                            SqlCommand cmd = new SqlCommand(qry, cnn);
                            cmd.Connection.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Modificacion realizada satisfactoriamente, inicie sesión", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cmd.Connection.Close();
                            this.Hide();
                            FormLogin m = new FormLogin();
                            m.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambioContraseña_Load(object sender, EventArgs e)
        {
            txtRespuesta.MaxLength = 15;
            txtconfirmNewContra.MaxLength = 15;
            txtNewContra.MaxLength = 15;

            txtNewContra.PasswordChar = '*';
            txtconfirmNewContra.PasswordChar = '*';
            
//            cn.Open();

            string qry = "select Pregunta_Seguridad from Preguntas_Seguridad";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(qry, conexion.con());
            da.Fill(dt);

            cmbPregunta.ValueMember = "codPregunta";
            cmbPregunta.DisplayMember = "Pregunta_Seguridad";
            cmbPregunta.DataSource = dt;

          //  cn.Close();
        }

        private void txtNewContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SinEspacios(e);
        }

        private void txtconfirmNewContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SinEspacios(e);   
        }

        private void txtRespuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SinEspacios(e);
        }

        private void txtRespuesta_Leave(object sender, EventArgs e)
        {
            if (txtRespuesta.TextLength == 0)
            {
                errorProvider1.SetError(txtRespuesta, "este campo no puede estar vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNewContra_Leave(object sender, EventArgs e)
        {
            if (txtNewContra.TextLength == 0)
            {
                //errorProvider2.SetError(txtNewContra, "este campo no puede estar vacio");
            }
            else
            {
                //errorProvider2.Clear();
            }
        }

        private void txtconfirmNewContra_Leave(object sender, EventArgs e)
        {
            if (txtconfirmNewContra.TextLength == 0)
            {
               // errorProvider3.SetError(txtconfirmNewContra, "este campo no puede estar vacio");
            }
            else
            {
                //errorProvider3.Clear();
            }
        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfirmNewContra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
