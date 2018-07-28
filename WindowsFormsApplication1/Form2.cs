using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }




        private void Form2_Load(object sender, EventArgs e)
        {

            conexion cn = new conexion();

            cn.consulta("select codigo_empleado, id_empleado,codigo_puestoEmpleado, nombre_empleado, direccion_empleado, telefono_empleado, telefono_emplaedoEmergencia, email_empleado, usr_empleado from Empleado", "Empleado");
            dataGridViewEmpleado.DataSource = cn.ds.Tables["Empleado"];




        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin irLogin = new FormLogin();
            irLogin.Show();
            this.Hide();
        }

        private void buttonAtrasRegistro_Click(object sender, EventArgs e)
        {
            Form1 irForm1 = new Form1();
            irForm1.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void mostrarDatos()
        {

        }

        private void buttonEliminarEmpleado_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            if (cn.eliminar("Empleado", "id_empleado = " + textBoxIdEmpleadoMod.Text))
            {
                MessageBox.Show("El Registro se ha elimindado", "Mensaje", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error al eliminar el Registro", "Mensaje", MessageBoxButtons.OK);
            }


            cn.consulta("select codigo_empleado, id_empleado,codigo_puestoEmpleado, nombre_empleado, direccion_empleado, telefono_empleado, telefono_emplaedoEmergencia, email_empleado, usr_empleado from Empleado", "Empleado");
            dataGridViewEmpleado.DataSource = cn.ds.Tables["Empleado"];
        }

        private void dataGridViewEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dataGridViewEmpleado.Rows[e.RowIndex];
                textBoxIdEmpleadoMod.Text = dgv.Cells[1].Value.ToString();
                textBoxPuestoEmpleadoMod.Text = dgv.Cells[2].Value.ToString();
                textBoxNombreEmpleadoMod.Text = dgv.Cells[3].Value.ToString();
                textBoxDireccionEmpleadoMod.Text = dgv.Cells[4].Value.ToString();
                textBoxTelefonoEmpleadoMod.Text = dgv.Cells[5].Value.ToString();
                textBoxTelefonoEmergenciaEmpleadoMod.Text = dgv.Cells[6].Value.ToString();
                textBoxCorreoEmpleadoMod.Text = dgv.Cells[7].Value.ToString();
                textBoxUsuarioEmpleadoMod.Text = dgv.Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            bool respuesta = true;
            bool r = true;

            if (validarEB())
            {
                r =validaciones.Correo(textBoxCorreoEmpleadoMod.Text);
                if (r!=true)
                {

                    MessageBox.Show("Correo Electronico invalido, el correo debe tener el formato ejemplo@dominio.com ", "Mensaje", MessageBoxButtons.OK);
                    textBoxCorreoEmpleadoMod.SelectAll();
                    textBoxCorreoEmpleadoMod.Focus();


                }
                else
                {





                    if (comboBoxPuestoEmpleadoMod.Text == "Profesor")
                    {
                        textBoxPuestoEmpleadoMod.Clear();
                        textBoxPuestoEmpleadoMod.Text = "1";
                    }
                    if (comboBoxPuestoEmpleadoMod.Text == "Secretaria")
                    {
                        textBoxPuestoEmpleadoMod.Clear();
                        textBoxPuestoEmpleadoMod.Text = "2";
                    }
                    if (comboBoxPuestoEmpleadoMod.Text == "Administrador")
                    {
                        textBoxPuestoEmpleadoMod.Clear();
                        textBoxPuestoEmpleadoMod.Text = "3";
                    }
                    if (comboBoxPuestoEmpleadoMod.Text == "Chofer")
                    {
                        textBoxPuestoEmpleadoMod.Clear();
                        textBoxPuestoEmpleadoMod.Text = "4";
                    }
                    if (comboBoxPuestoEmpleadoMod.Text == "Personal Limpieza")
                    {
                        textBoxPuestoEmpleadoMod.Clear();
                        textBoxPuestoEmpleadoMod.Text = "5";
                    }

                    int puestoMod;
                    puestoMod = Int32.Parse(textBoxPuestoEmpleadoMod.Text);

                    respuesta = cn.NoExistencias(Convert.ToString(textBoxIdEmpleadoMod.Text));







                    if (respuesta != true)
                    {


                        string actualizar = "codigo_puestoEmpleado ='" + puestoMod + "',nombre_empleado ='" + textBoxNombreEmpleadoMod.Text + "', direccion_empleado ='" + textBoxDireccionEmpleadoMod.Text + "', telefono_empleado ='" + textBoxTelefonoEmpleadoMod.Text + "', telefono_emplaedoEmergencia ='" + textBoxTelefonoEmergenciaEmpleadoMod.Text + "', email_empleado ='" + textBoxCorreoEmpleadoMod.Text + "', usr_empleado ='" + textBoxUsuarioEmpleadoMod.Text + "'";
                        if (cn.actualizar("Empleado", actualizar, "id_empleado=" + Convert.ToString(textBoxIdEmpleadoMod.Text)))
                        {
                            MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK);
                            cn.consulta("select codigo_empleado, id_empleado,codigo_puestoEmpleado, nombre_empleado, direccion_empleado, telefono_empleado, telefono_emplaedoEmergencia, email_empleado, usr_empleado from Empleado", "Empleado");
                            dataGridViewEmpleado.DataSource = cn.ds.Tables["Empleado"];
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el Registro", "Mensaje", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("EL ID NO Existe", "Mensaje", MessageBoxButtons.OK);
                        textBoxIdEmpleadoMod.Clear();
                        textBoxIdEmpleadoMod.Focus();

                    }
                }
            }
        }
        public bool validarEB()
        {
            
            bool noError = true;
            int count = 0;


            count=count+1;

            if (count!=0){
              ErrorEB.Clear();
            }

            if (textBoxIdEmpleadoMod.Text == "")
            {

                ErrorEB.SetError(textBoxIdEmpleadoMod, "Ingrese el ID");


                noError = false;
            }

            if (textBoxNombreEmpleadoMod.Text == "")
            {

                ErrorEB.SetError(textBoxNombreEmpleadoMod, "Ingrese el  Nombre ");


                noError = false;
            }

            if (textBoxDireccionEmpleadoMod.Text == "")
            {

                ErrorEB.SetError(textBoxDireccionEmpleadoMod, "Ingrese la Direccion ");


                noError = false;
            }

            if (textBoxCorreoEmpleadoMod.Text == "")
            {

                ErrorEB.SetError(textBoxCorreoEmpleadoMod, "Ingrese el Correo ");


                noError = false;
            }

            if (textBoxUsuarioEmpleadoMod.Text == "")
            {

                ErrorEB.SetError(textBoxUsuarioEmpleadoMod, "Ingrese el Usuario ");


                noError = false;
            }

            if (textBoxTelefonoEmpleadoMod.Text == "")
            {

                ErrorEB.SetError(textBoxTelefonoEmpleadoMod, "Ingrese el Telefono ");


                noError = false;
            }

            if (textBoxTelefonoEmergenciaEmpleadoMod.Text == "")
            {

                ErrorEB.SetError(textBoxTelefonoEmergenciaEmpleadoMod, "Ingrese el Telefono de Emergencia ");


                noError = false;
            }

            if (comboBoxPuestoEmpleadoMod.Text == "")
            {

                ErrorEB.SetError(comboBoxPuestoEmpleadoMod, "Ingrese elija el Puesto ");


                noError = false;
            }





            return noError;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void textBoxIdEmpleadoMod_TextChanged(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            string id = textBoxIdEmpleadoMod.Text;
            string str = string.Format("select codigo_empleado, id_empleado,codigo_puestoEmpleado, nombre_empleado, direccion_empleado, telefono_empleado, telefono_emplaedoEmergencia, email_empleado, usr_empleado from Empleado where id_empleado like '{0}%'", id);
            if (textBoxIdEmpleadoMod.Text != "")
            {
                cn.consulta(str , "Empleado");
                dataGridViewEmpleado.DataSource = cn.ds.Tables["Empleado"];
            } 
            else
            {
                cn.consulta("select codigo_empleado, id_empleado,codigo_puestoEmpleado, nombre_empleado, direccion_empleado, telefono_empleado, telefono_emplaedoEmergencia, email_empleado, usr_empleado from Empleado", "Empleado");
                dataGridViewEmpleado.DataSource = cn.ds.Tables["Empleado"];
            }
        }

        private void textBoxIdEmpleadoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBoxNombreEmpleadoMod_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxNombreEmpleadoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void textBoxCorreoEmpleadoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void textBoxCorreoEmpleadoMod_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxNombreEmpleadoMod_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void textBoxTelefonoEmpleadoMod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}