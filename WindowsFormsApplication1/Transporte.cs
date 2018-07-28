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
    public partial class Transporte : Form
    {
        public Transporte()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            FormLogin irlogin = new FormLogin();
            irlogin.Show();
            this.Hide();
        }

        private void buttonAtrasRegistro_Click(object sender, EventArgs e)
        {
            admin irMenuAdmin = new admin();
            irMenuAdmin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admin irMenuAdmin = new admin();
            irMenuAdmin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormLogin irlogin = new FormLogin();
            irlogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            conexion cn = new conexion();
            bool respuesta = true;
            bool respuesta2 = true;
            bool respuesta3 = true;

            if (validarEB())
            {
                respuesta = cn.ExistenciasB(int.Parse(textBox2.Text));
                respuesta2 = cn.ExistenciasNB(int.Parse(textBoxNumeroBusE.Text));
                respuesta3 = cn.ExistenciasPB(Convert.ToString(textBoxPlacaBusE.Text));


                if (respuesta3 != true)
                {


                    if (respuesta2 != true)
                    {

                        if (respuesta != true)
                        {
                            if (textBox2.Text == " ")
                            {
                                MessageBox.Show("Debe seleccionar un Chofer");
                            }
                            else
                            {
                                int num;
                                int num2;
                                num = int.Parse(textBoxNumeroBusE.Text);
                                num2 = int.Parse(textBox2.Text);


                                db.insertarruta(textBoxDescripcioE.Text);
                                db.insertarbuses(1, null, num2, num, textBoxPlacaBusE.Text);

                                MessageBox.Show("la ruta se guardo");

                                cn.consulta("select * from Buses", "Buses");
                                dataGridAgrarR.DataSource = cn.ds.Tables["Buses"];
                            }
                        }
                        else
                        {

                            MessageBox.Show("Este Chofer ya tiene Ruta Asignada", "Mensaje", MessageBoxButtons.OK);
                           
                            

                        }

                    }
                    else
                    {
                        MessageBox.Show("Este Numero de Bus ya esta Asignado", "Mensaje", MessageBoxButtons.OK);
                        textBoxNumeroBusE.Clear();
                        textBoxNumeroBusE.Focus();


                    }
                }
                else
                {
                    MessageBox.Show("Esta placa ya Existe", "Mensaje", MessageBoxButtons.OK);
                    textBoxPlacaBusE.Clear();
                    textBoxPlacaBusE.Focus();
                }
            }
         
         }
            
    
                
               
               

            
           
        

        public bool validarEB()
        {

           
            bool noError = true;
            int count = 0;
            
            

            count = count + 1;

            if (count != 0)
            {
                ErrorID.Clear();
            }

            if (textBox2.Text == "")
            {

                ErrorID.SetError(textBox2, "Elija Chofer");

                noError = false;
            }


            if (textBoxDescripcioE.Text == "")
            {

                ErrorID.SetError(textBoxDescripcioE, "Ingrese la descripcion de la Ruta");

                noError = false;
            }

            if (textBoxNumeroBusE.Text == "")
            {

                ErrorID.SetError(textBoxNumeroBusE, "Ingrese el numero del bus");

                noError = false;
            }

            if (textBoxPlacaBusE.Text == "")
            {

                ErrorID.SetError(textBoxPlacaBusE, "Ingrese la placa del bus");

                noError = false;
            }




            return noError;
        }


        private void Transporte_Load(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            cn.consulta("select codigo_empleado, nombre_empleado  from Empleado where  codigo_puestoEmpleado = 4 ", "Empleado");
            dataGridView1.DataSource=cn.ds.Tables["Empleado"];

            cn.consulta("select * from Buses", "Buses");
            dataGridAgrarR.DataSource = cn.ds.Tables["Buses"];

            cn.consulta("select codigo_ruta,codigo_alumno,id_alumno, nombre_alumno from Alumno ", "Alumno");
            dataGridLARutas.DataSource = cn.ds.Tables["Alumno"];

            cn.consulta("select * from Ruta", "Ruta");
            dataGridViewRutas.DataSource = cn.ds.Tables["Ruta"];
          
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
            textBox2.Text = dgv.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridAgrarR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridAgrarR.Rows[e.RowIndex];
             textBoxCodigoBus.Text = dgv.Cells[0].Value.ToString();
             
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCodigoBus_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
              conexion cn = new conexion();
              if (cn.eliminar("Buses", "codigo_bus = " + textBoxCodigoBus.Text))
              {
                  MessageBox.Show("El Registro se ha elimindado", "Mensaje", MessageBoxButtons.OK);
              }
              else
              {
                  MessageBox.Show("Error al eliminar el Registro", "Mensaje", MessageBoxButtons.OK);
              }
        }

        private void textBoxCodigoRbuscar_TextChanged(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            if (textBoxCodigoRbuscar.Text != "")
            {
                cn.consulta("select codigo_ruta,codigo_alumno,id_alumno, nombre_alumno from Alumno where codigo_ruta = " + textBoxCodigoRbuscar.Text, "Alumno");
                dataGridLARutas.DataSource = cn.ds.Tables["Alumno"];
            }
            else
            {
                cn.consulta("select codigo_ruta,codigo_alumno,id_alumno, nombre_alumno from Alumno", "Alumno");
                dataGridLARutas.DataSource = cn.ds.Tables["Alumno"];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                //string connstring = "connection string";
                using (SqlConnection cn = new SqlConnection())
                {
                   
                    string sql = "SELECT nombre_alumno from Alumno where id_alumno =@id";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        textBox3.Text = Convert.ToString(reader["nombre"]);
                    }
                    
                }
            }
               
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            conexion cn = new conexion();
            bool respuesta = true;


        
            if (validarEBc())
            {

                respuesta = cn.ExistenciasCR(int.Parse(textBoxCodigoRbuscar.Text));
                if (respuesta != true)
                {

                    string actualizar = "codigo_ruta ='" + textBoxCodigoRbuscar.Text + "'";
                    if (cn.actualizar("Alumno", actualizar, "id_alumno=" + textBox1.Text))
                    {
                        MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK);
                        cn.consulta("select codigo_ruta, id_alumno, nombre_alumno from Alumno", "Alumno");
                        dataGridLARutas.DataSource = cn.ds.Tables["Alumno"];
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el Registro", "Mensaje", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("El ID  Existe", "Mensaje", MessageBoxButtons.OK);
                }
            }
        }


        public bool validarEBc()
        {

            bool noError = true;
            int count = 0;


            count = count + 1;

            if (count != 0)
            {
                ErrorEB.Clear();
            }

            if (textBoxCodigoRbuscar.Text == "")
            {

                ErrorEB.SetError(textBoxCodigoRbuscar, "Ingrese el codigo de Ruta");


                noError = false;
            }

            if (textBox1.Text == "")
            {

                ErrorEB.SetError(textBox1, "Ingrese el ID Alumno");


                noError = false;
            }


            if (textBox3.Text == "")
            {

                ErrorEB.SetError(textBox3, "Ingrese el Nombre del Alumno");


                noError = false;
            }




            return noError;
        }

        private void textBoxNumeroBusE_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBoxcodigoR_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBoxcodigoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBoxNombreA_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }
    }

 
}
