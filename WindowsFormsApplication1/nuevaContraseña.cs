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
    public partial class nuevaContraseña : Form
    {
        public string user;
        public nuevaContraseña()
        {
            InitializeComponent();
        }
        
        private void nuevaContraseña_Load(object sender, EventArgs e)
        {
            txtconfirmNewContra.PasswordChar = '*';
            txtNewContra.PasswordChar = '*';
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
           
            
            if (txtconfirmNewContra.Text != txtNewContra.Text)
            {
                MessageBox.Show("Contraseñas incorrectas", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtconfirmNewContra.TextLength < 8 || txtNewContra.TextLength < 8)
                {
                    MessageBox.Show("La contraseña debe contener al menos 8 caracteres");
                }
                else
                {
                


                    SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");
                    pwdOlvidada pass = new pwdOlvidada();
                    Class1 cl = new Class1();
                    string encrypted = cl.Encrypt(txtNewContra.Text);

                    string qry = string.Format("update Empleado set [pwd_empleado] = '{0}' where usr_empleado = '{1}'", encrypted, user);

                    SqlCommand cmd = new SqlCommand(qry, conn);
                    cmd.Connection.Open();
                    var command = cmd.ExecuteNonQuery();

                    string qryBloq = "update Empleado set codigo_estado = 1 where usr_empleado = '" + user + "'";
                    SqlCommand cmd2 = new SqlCommand(qryBloq, conn);
                    cmd2.ExecuteNonQuery();

                    string qryBloq2 = "update Empleado set intentos = 0 where usr_empleado = '" + user + "'";
                    SqlCommand cmd3 = new SqlCommand(qryBloq2, conn);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Cambio de contraseña realizado, porfavor inicie sesion de nuevo.", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide(); 


                    conn.Close();


                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkPass1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass1.Checked == true)
            {
                if (txtNewContra.PasswordChar == '*')
                {
                    txtNewContra.PasswordChar = '\0';
                }
            }
            else
            {
                txtNewContra.PasswordChar = '*';
            }
        }

        private void chkPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass2.Checked == true)
            {
                if (txtconfirmNewContra.PasswordChar == '*')
                {
                    txtconfirmNewContra.PasswordChar = '\0';
                }
            }
            else
            {
                txtconfirmNewContra.PasswordChar = '*';
            }
        }

        private void txtNewContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfirmNewContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfirmNewContra_Leave(object sender, EventArgs e)
        {
            if (txtconfirmNewContra.Text.Trim() == "")
            {

                errorProvider2.SetError(txtconfirmNewContra, "no se puede dejar este campo vacio");

            }
        }

        private void txtNewContra_Leave(object sender, EventArgs e)
        {
            if (txtNewContra.TextLength == 0)
            {
                errorProvider1.SetError(txtNewContra, "no se puede dejar este campo vacio");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


