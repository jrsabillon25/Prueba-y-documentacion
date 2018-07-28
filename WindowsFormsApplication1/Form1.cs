using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public char KeyChar { get; set; }

        
        
        public Form1()
        {
            InitializeComponent();
            radioButtonNO.Checked = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBoxCorreo.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                textBoxUsuario.Enabled = false;
                textBoxContrasena.Enabled = false;
        }

        private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
        {
           
                textBoxUsuario.Enabled=true;
                textBoxUsuario.Clear();
                textBoxContrasena.Clear(); 
            textBoxContrasena.Enabled = true;
            
                    
             
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            bool respuesta = true;
            DataClasses1DataContext db = new DataClasses1DataContext();
            Class1 enc = new Class1();

            Int32 puesto;
            //respuesta = cn.ExistenciasE(int.Parse(textBoxId.Text));



                bool r = true;

                if (validarEB())
                {
                    bool respuestaU = true;

                    respuestaU = cn.ExistenciasU(textBoxUsuario.Text);
                    if (respuestaU != true)
                    {

                        MessageBox.Show("Ese nommbre de Usuario ya existe. ", "Mensaje", MessageBoxButtons.OK);
                        textBoxUsuario.SelectAll();
                        textBoxUsuario.Focus();


                    }
                    else
                    {



                        if (textBoxContrasena.TextLength < 8 || textBoxContrasena.TextLength < 8)
                        {
                            MessageBox.Show("La contraseña debe contener al menos 8 caracteres");
                        }
                        else
                        {



                            r = validaciones.Correo(textBoxCorreo.Text);
                            if (r != true)
                            {

                                MessageBox.Show("Correo Electronico invalido, el correo debe tener el formato ejemplo@dominio.com ", "Mensaje", MessageBoxButtons.OK);
                                textBoxCorreo.SelectAll();
                                textBoxCorreo.Focus();


                            }
                            else
                            {



                                ErrorEB.Clear();
                                respuesta = cn.ExistenciasE(textBoxId.Text);
                                if (respuesta != true)
                                {


                                    puesto = Int32.Parse(textBoxPuesto.Text);

                                    db.ingresarEmpleados(textBoxId.Text, textBoxNombre.Text, puesto, 3, textBoxCorreo.Text, textBoxtelefono.Text, textBoxEmergencia.Text, textBoxDireccion.Text, textBoxUsuario.Text, enc.Encrypt(textBoxContrasena.Text));
                                    MessageBox.Show("Se ha guardado correctamente", "Mensaje", MessageBoxButtons.OK);
                                }
                                else
                                {

                                    MessageBox.Show("El ID ya existe ", "Mensaje", MessageBoxButtons.OK);
                                    textBoxId.Clear();
                                    textBoxId.Focus();
                                }



                            }
                        }
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
                ErrorEB.Clear();
            }

            if (textBoxNombre.Text == "")
            {
              
                ErrorEB.SetError(textBoxNombre, "Ingrese  el Nombre");

                noError = false;
            }

            if (textBoxId.Text == "")
            {

                ErrorEB.SetError(textBoxId, "Ingrese  el ID");
                noError = false;
            }

            if (textBoxtelefono.Text == "")
            {

                ErrorEB.SetError(textBoxtelefono, "Ingrese  el telefono");
                noError = false;
            }
            if (textBoxEmergencia.Text == "")
            {

                ErrorEB.SetError(textBoxEmergencia, "Ingrese  el  Numero de Emergencia");
                noError = false;
            }
            if (textBoxCorreo.Text == "")
            {

                ErrorEB.SetError(textBoxCorreo, "Ingrese  el Correo");
                noError = false;
            }
            if (textBoxDireccion.Text == "")
            {

                ErrorEB.SetError(textBoxDireccion, "Ingrese   la direccion");
                noError = false;
            }



            if (comboBox1.Text == "")
            {

                ErrorEB.SetError(comboBox1, "Elija   el Puesto");
                noError = false;
            }

            if (textBoxPuesto.Text == "")
            {

                ErrorEB.SetError(textBoxPuesto, "Elija el puesto");
                noError = false;
            }

            if (radioButtonSi.Checked == true)
            {
                if (textBoxUsuario.Text == "")
                {

                    ErrorEB.SetError(textBoxUsuario, "Ingrese el Usuario");
                   
                }

                if (textBoxContrasena.Text == "")
                {
                    ErrorEB.SetError(textBoxContrasena, "Ingrese la Contraseña");
                    
                }

            }


            return noError;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Profesor")
            {
                textBoxPuesto.Clear();
                textBoxPuesto.Text = "1";
            }
            
            if (comboBox1.Text == "Secretaria")
            {
                textBoxPuesto.Clear();
                textBoxPuesto.Text = "2";
            }
          
            if (comboBox1.Text == "Administrador")
            {
                textBoxPuesto.Clear();
                textBoxPuesto.Text = "3";
            }
           
            if (comboBox1.Text == "Chofer")
            {
                textBoxPuesto.Clear();
                textBoxPuesto.Text = "4";
            }
            
            if (comboBox1.Text == "Personal Limpieza")
            {
                textBoxPuesto.Clear();
                textBoxPuesto.Text = "5";
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                MessageBox.Show("No se puede utilizar el boton derecho");
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 ver = new Form2();
            ver.Show();
            this.Hide();
            
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
     
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombretextBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void textBoxtelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxtelefonotextBoxtelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBoxEmergencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {

            validaciones.soloNumeros(e);
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetrasyNumeros(e);
        }

        private void textBoxContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetrasyNumeros(e);
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetrasyNumerosyPunto(e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void textBoxPuesto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


