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
    public partial class FormLogin : Form
    {
        int cont;
        int conteo;
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");
        public FormLogin()
        {
            InitializeComponent();
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
            if (txtUser.Text == "")
            {

                ErrorEB.SetError(txtUser, "Ingrese su Usuario");


                noError = false;
            }


            if (txtPwd.Text == "")
            {

                ErrorEB.SetError(txtPwd, "Ingrese su Contraseña");


                noError = false;
            }




            return noError;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if (validarEB())
            {

                ErrorEB.Clear();
                DataClasses1DataContext db = new DataClasses1DataContext();
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Class1 enc = new Class1();
                conexion cn = new conexion();
                int estado = 0;
                var Dencrypt = enc.Decrypt("AOyiDa6ltbbIAgLDzicDuQ==");
                var encrypt = enc.Encrypt(txtPwd.Text);
               

                //MessageBox.Show("El usuario no tiene un puesto asignado", Dencrypt);
               

                conn.Open();
                string qryIntentos = string.Format("select intentos from Empleado where usr_empleado = '{0}'", txtUser.Text);

                SqlCommand cmdint = new SqlCommand(qryIntentos, conexion.con());
                SqlDataReader drint = cmdint.ExecuteReader();

                if (drint.Read())
                {
                    conteo = Convert.ToInt32(drint["intentos"]); //cuantos intentos tiene el usuario?
                }
                conn.Close();
                drint.Close();
                if (conteo >= 2 || estado == 2)
                {
                    string qryBloq = "update Empleado set codigo_estado = 2 where usr_empleado = '"+ txtUser.Text +"'";
                    conn.Open();
                    SqlCommand cmdbloq = new SqlCommand(qryBloq, conn);

                    cmdbloq.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Su cuenta ha sido bloqueada consulte mas informacion en administracion ", caption, buttons);

                }

                else
                {
                    conn.Open();
                    string qryUsuario = string.Format("select usr_empleado from Empleado where usr_empleado == '{0}' and pwd_empleado = '{1}'", txtUser.Text, encrypt);
                    SqlCommand cmdUsuario = new SqlCommand(qryIntentos, conn);
                    SqlDataReader drUsuario = cmdUsuario.ExecuteReader();

                        while (drUsuario.Read())
                        {
                            var algo = drUsuario.GetString(0);
                     
                            MessageBox.Show(algo.ToString());
                        }

                    var user = (from s in db.Empleado where s.usr_empleado == txtUser.Text && s.pwd_empleado == encrypt select s).FirstOrDefault();
                    if (user != null)
                    {

                        if (user.codigo_estado == 3)
                        {
                            cambioContraseña irnueva = new cambioContraseña();
                            irnueva.Show();
                            this.Hide();
                        }
                        else
                        {


                            switch (user.codigo_estado)
                            {
                                case 1:
                                    {
                                        if (user.codigo_estado == 3)
                                        {
                                            //db.EX_estado(1, txtUser.Text);

                                            user.codigo_estado = 1;
                                            this.Hide();
                                            cambioContraseña m = new cambioContraseña();
                                            m.Show();

                                        }
                                        else
                                        {

                                            this.Hide();
                                            maestro m = new maestro();
                                            m.Show();


                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        if (user.codigo_estado == 3)
                                        {
                                            user.codigo_estado = 1;
                                            this.Hide();
                                            cambioContraseña m = new cambioContraseña();
                                            m.Show();
                                        }
                                        else
                                        {

                                            this.Hide();
                                            secretaria s = new secretaria();
                                            s.Show();
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        if (user.codigo_estado == 3)
                                        {
                                            user.codigo_estado = 1;
                                            this.Hide();
                                            cambioContraseña m = new cambioContraseña();
                                            m.Show();
                                        }
                                        else
                                        {
                                            this.Hide();
                                            admin a = new admin();
                                            a.Show();
                                            MessageBox.Show(cont.ToString());
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        MessageBox.Show("El usuario no tiene un puesto asignado", caption, buttons);
                                        break;
                                    }
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña invalido", caption, buttons);
                        conn.Close();
                        conn.Open();
                        string usuario = txtUser.Text;
                        string intentos = string.Format("select intentos from Empleado where usr_empleado = '{0}'", usuario);
                        SqlCommand cmd2 = new SqlCommand(intentos, conn);
                        SqlDataReader dr = cmd2.ExecuteReader();

                        if (dr.Read())
                        {
                            cont = Convert.ToInt32(dr["intentos"]) + 1;
                        }

                        conn.Close();
                        dr.Close();

                        conn.Open();
                        string qry = string.Format("update Empleado set [intentos] = {0} where usr_empleado = '{1}'", cont, usuario);
                        SqlCommand cmd = new SqlCommand(qry, conn);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

            }
        }
    
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblOlvido_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");
            conn.Open();

            string usuario = txtUser.Text;

            string qry = string.Format("select * from Empleado where usr_empleado = '{0}'", usuario);

            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader lect = cmd.ExecuteReader();

            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("debe de ingresar al menos su usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lect.Read())
                {
                    pwdOlvidada pass = new pwdOlvidada();
                    pass.user = txtUser.Text;
                    pass.Show();
                }
                else
                {
                    MessageBox.Show("No se encontro el usuario ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            lect.Close();
            conn.Close();
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            if (txtPwd.Text == "" || txtPwd.Text == "Contraseña")
            {
                txtPwd.Text = "";
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.TextLength == 0)
            {
                errorProvider1.SetError(txtUser, "No se permite campo vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtU_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetrasyNumeros(e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}


