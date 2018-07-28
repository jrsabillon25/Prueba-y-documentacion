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
    public partial class primerIngreso : Form
    {
        public primerIngreso()
        {
            InitializeComponent();
            radioButton2.Checked = true;
            radioButton4.Checked = true;
            


            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            FormLogin irLogin = new FormLogin();
            irLogin.Show();
            this.Hide();
        }

        private void buttonAtrasRegistro_Click(object sender, EventArgs e)
        {
            matricula irMatricula = new matricula();
            irMatricula.Show();
            this.Hide();
        }

        private void textBoxIdPrimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }
        conexion con = new conexion();
        private void button1_Click(object sender, EventArgs e)
        {
            bool r = true;
            bool r2 = true;



            if (validarEB())
            {

                        ErrorEB.Clear();



                        if (comboBoxGrado.Text == "1er grado")
                        {
                            textBoxGrado.Clear();
                            textBoxGrado.Text = "1";
                        }
                        if (comboBoxGrado.Text == "2do grado")
                        {
                            textBoxGrado.Clear();
                            textBoxGrado.Text = "2";
                        }
                        if (comboBoxGrado.Text == "3er grado")
                        {
                            textBoxGrado.Clear();
                            textBoxGrado.Text = "3";
                        }
                        if (comboBoxGrado.Text == "4to grado")
                        {
                            textBoxGrado.Clear();
                            textBoxGrado.Text = "4";
                        }
                        if (comboBoxGrado.Text == "5to grado")
                        {
                            textBoxGrado.Clear();
                            textBoxGrado.Text = "5";
                        }
                        if (comboBoxGrado.Text == "6to grado")
                        {
                            textBoxGrado.Clear();
                            textBoxGrado.Text = "6";
                        }
                        if (comboBoxGrado.Text == "7mo grado")
                        {
                            textBoxGrado.Clear();
                            textBoxGrado.Text = "7";
                        }
                        if (comboBoxGrado.Text == "8vo grado")
                        {
                            textBoxGrado.Clear();
                            textBoxGrado.Text = "8";
                        }
                        if (comboBoxGrado.Text == "9no grado")
                        {
                            textBoxGrado.Clear();
                            textBoxGrado.Text = "9";
                        }
                        if (comboBoxGrado.Text == "10mo grado")
                        {
                            textBoxGrado.Clear();
                            textBoxGrado.Text = "10";
                        }
                        if (comboBoxGrado.Text == "11vo grado")
                        {
                            textBoxGrado.Clear();
                            textBoxGrado.Text = "11";
                        }
                        if (comboBoxSeccion.Text == "A")
                        {
                            textBoxSeccion.Clear();
                            textBoxSeccion.Text = "1";
                        }
                        if (comboBoxSeccion.Text == "B")
                        {
                            textBoxSeccion.Clear();
                            textBoxSeccion.Text = "2";
                        }
                        if (comboBoxSeccion.Text == "C")
                        {
                            textBoxSeccion.Clear();
                            textBoxSeccion.Text = "3";
                        }

                        DataClasses1DataContext db = new DataClasses1DataContext();

                        string fechaNac = dateTimePicker1.Text;

                        bool respuesta = true;
                      
                        respuesta = con.Existencias(int.Parse(textBoxIdPrimer.Text));
                     
                  
                            r = validaciones.Correo(textBoxCorreoEncargado.Text);
                          

                            if (r ==false ||   r2 == false)
                            {
                                if (r ==false){
                                MessageBox.Show("Correo Electronico invalido, el correo debe tener el formato ejemplo@dominio.com ", "Mensaje", MessageBoxButtons.OK);
                                textBoxCorreoEncargado.SelectAll();
                                textBoxCorreoEncargado.Focus();
                                }


                                  if (r2 ==false){
                                MessageBox.Show("Correo Electronico invalido, el correo debe tener el formato ejemplo@dominio.com ", "Mensaje", MessageBoxButtons.OK);
                                textBoxCorreoEncargado2.SelectAll();
                                textBoxCorreoEncargado2.Focus();
                                }




                                
                            }
                            else
                            {
                                r2 = validaciones.Correo(textBoxCorreoEncargado.Text);
                             


                                   
                             
                        if (respuesta != true)
                        {
                            
                                    int grado;
                                    grado = Int32.Parse(textBoxGrado.Text);
                                    int seccion;
                                    seccion = Int32.Parse(textBoxSeccion.Text);
                                    string año = dateTimePicker2.Text;

                                    conexion xl = new conexion();
                                    SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");

                                    conn.Open();
                                    string comando = string.Format("select count(a.codigo_alumno) from  [dbo].[Alumno] a inner join [dbo].[grado_alumno] b on a.codigo_alumno = b.codigo_alumno inner join [dbo].[Periodos_Grado] c on b.codigo_periodoGrado = c.codigo_periodoGrado inner join [dbo].[Grado] d on c.codigo_grado= d.codigo_grado inner join [dbo].[Seccion] e on c.codigo_seccion = e.codigo_seccion where c.codigo_grado = {0} AND c.codigo_seccion = {1}", comboBoxGrado.SelectedIndex + 1, comboBoxSeccion.SelectedIndex + 1);
                                    SqlCommand cmd = new SqlCommand(comando, conn);

                                    Int32 count = (Int32)cmd.ExecuteScalar();
                                    conn.Close();
  
                                    //Int32 count = (Int32) db.ExecuteCommand("select count(a.codigo_alumno) from  [dbo].[Alumno] a inner join [dbo].[grado_alumno] b on a.codigo_alumno = b.codigo_alumno inner join [dbo].[Periodos_Grado] c on b.codigo_periodoGrado = c.codigo_periodoGrado inner join [dbo].[Grado] d on c.codigo_grado= d.codigo_grado inner join [dbo].[Seccion] e on c.codigo_seccion = e.codigo_seccion where c.codigo_grado = {0} AND c.codigo_seccion = {1}",Convert.ToInt32(comboBoxGrado.SelectedIndex),Convert.ToInt32(comboBoxSeccion.SelectedIndex));
                                    if (count <= 10)
                                    {
                                        string cursoInicial = comboBoxGrado.Text;

                                        db.ingresarAlumnos(textBoxIdPrimer.Text, textBoxNombrePrimer.Text, 1, fechaNac, textBoxDireccionPrimer.Text, textBoxLugarPrimer.Text, comboBoxGenero.Text, textBoxTelefonoAlumno.Text, cursoInicial, textBoxInstituto.Text, textBoxRetrasada.Text, textBoxTPA.Text);
                                        db.ingresarEncargado(textBoxIdEncargado.Text, textBoxNombreEncargado.Text, textBoxTrabajoEncargado.Text, textBoxTelefonoEncargado.Text, textBoxCelularEncargado.Text, textBoxCorreoEncargado.Text, textBoxDireccionEncargado.Text);
                                        db.insertarAlumnoEncargado();
                                        db.ingresarEncargado2(textBoxIdEncargado2.Text, textBoxNombreEncargado2.Text, textBoxTrabajoEncargado2.Text, textBoxTelefonoEncargado2.Text, textBoxCelularEncargado2.Text, textBoxCorreoEncargado2.Text, textBoxDireccionEncargado2.Text);

                                        db.insertarAlumnoEncargado2();

                                        if (comboBoxGrado.Text == "1er grado" && comboBoxSeccion.Text == "A")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "1";
                                        }
                                        if (comboBoxGrado.Text == "1er grado" && comboBoxSeccion.Text == "B")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "2";
                                        }
                                        if (comboBoxGrado.Text == "1er grado" && comboBoxSeccion.Text == "C")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "3";
                                        }
                                        if (comboBoxGrado.Text == "2do grado" && comboBoxSeccion.Text == "A")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "4";
                                        }
                                        if (comboBoxGrado.Text == "2do grado" && comboBoxSeccion.Text == "B")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "5";
                                        }
                                        if (comboBoxGrado.Text == "2do grado" && comboBoxSeccion.Text == "C")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "6";
                                        }
                                        if (comboBoxGrado.Text == "3er grado" && comboBoxSeccion.Text == "A")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "7";
                                        }
                                        if (comboBoxGrado.Text == "3er grado" && comboBoxSeccion.Text == "B")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "8";
                                        }
                                        if (comboBoxGrado.Text == "3er grado" && comboBoxSeccion.Text == "C")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "9";
                                        }
                                        if (comboBoxGrado.Text == "4to grado" && comboBoxSeccion.Text == "A")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "10";
                                        }
                                        if (comboBoxGrado.Text == "4to grado" && comboBoxSeccion.Text == "B")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "11";
                                        }
                                        if (comboBoxGrado.Text == "4to grado" && comboBoxSeccion.Text == "C")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "12";
                                        }
                                        if (comboBoxGrado.Text == "5to grado" && comboBoxSeccion.Text == "A")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "13";
                                        }
                                        if (comboBoxGrado.Text == "5to grado" && comboBoxSeccion.Text == "B")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "14";
                                        }
                                        if (comboBoxGrado.Text == "5to grado" && comboBoxSeccion.Text == "C")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "15";
                                        }
                                        if (comboBoxGrado.Text == "6to grado" && comboBoxSeccion.Text == "A")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "16";
                                        }
                                        if (comboBoxGrado.Text == "6to grado" && comboBoxSeccion.Text == "B")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "17";
                                        }
                                        if (comboBoxGrado.Text == "6to grado" && comboBoxSeccion.Text == "C")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "18";
                                        }
                                        if (comboBoxGrado.Text == "7mo grado" && comboBoxSeccion.Text == "A")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "19";
                                        }
                                        if (comboBoxGrado.Text == "7mo grado" && comboBoxSeccion.Text == "B")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "20";
                                        }
                                        if (comboBoxGrado.Text == "7mo grado" && comboBoxSeccion.Text == "C")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "21";
                                        }
                                        if (comboBoxGrado.Text == "8vo grado" && comboBoxSeccion.Text == "A")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "22";
                                        }
                                        if (comboBoxGrado.Text == "8vo grado" && comboBoxSeccion.Text == "B")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "23";
                                        }
                                        if (comboBoxGrado.Text == "8vo grado" && comboBoxSeccion.Text == "C")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "24";
                                        }
                                        if (comboBoxGrado.Text == "9no grado" && comboBoxSeccion.Text == "A")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "25";
                                        }
                                        if (comboBoxGrado.Text == "9no grado" && comboBoxSeccion.Text == "B")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "26";
                                        }
                                        if (comboBoxGrado.Text == "9no grado" && comboBoxSeccion.Text == "C")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "27";
                                        }
                                        if (comboBoxGrado.Text == "10mo grado" && comboBoxSeccion.Text == "A")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "28";
                                        }
                                        if (comboBoxGrado.Text == "10mo grado" && comboBoxSeccion.Text == "B")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "29";
                                        }
                                        if (comboBoxGrado.Text == "10mo grado" && comboBoxSeccion.Text == "C")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "30";
                                        }
                                        if (comboBoxGrado.Text == "11vo grado" && comboBoxSeccion.Text == "A")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "31";
                                        }
                                        if (comboBoxGrado.Text == "11vo grado" && comboBoxSeccion.Text == "B")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "32";
                                        }
                                        if (comboBoxGrado.Text == "11vo grado" && comboBoxSeccion.Text == "C")
                                        {
                                            textBoxGrado.Clear(); textBoxAula.Text = "33";
                                        }

                                        int aula;
                                        aula = Int32.Parse(textBoxAula.Text);

                                        db.ingresarPeriodosGrados(dateTimePicker2.Text, grado, seccion, aula);
                                        db.insertarGradoAlumno();
                                        MessageBox.Show("Se ha guardado correctamente", "Mensaje", MessageBoxButtons.OK);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Seccion ya contiene mas de 30 alumnos");
                                    }
                             
                            
                        }
                        else
                        {
                            MessageBox.Show("El ID del Alumno ya Existe", "Mensaje", MessageBoxButtons.OK);
                            textBoxIdPrimer.Clear();
                            textBoxIdPrimer.Focus();
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

            if (checkBox1.Checked==false)
            {

                ErrorEB.SetError(checkBox1, "Debe entregar sertificado de notas");


                noError = false;
            }

            if (checkBox2.Checked == false)
            {

                ErrorEB.SetError(checkBox2, "Debe entregar sertificado de notas");


                noError = false;
            }

            if (checkBox3.Checked == false)
            {

                ErrorEB.SetError(checkBox3, "Debe entregar constancia de conducta");


                noError = false;
            }

            if (checkBox4.Checked == false)
            {

                ErrorEB.SetError(checkBox4, "Debe entregar Fotografia");


                noError = false;
            }



            if (textBoxIdPrimer.Text == "")
            {
                
                ErrorEB.SetError(textBoxIdPrimer, "Ingrese  el ID");
              
                
                noError = false;
            }
           
            if (textBoxNombrePrimer.Text == "")
            {
                
                ErrorEB.SetError(textBoxNombrePrimer, "Ingrese  el Nombre");

                noError = false;
            }

            if (textBoxLugarPrimer.Text == "")
            {
                
                ErrorEB.SetError(textBoxLugarPrimer, "Ingrese  lugar de Nacimiento");

                noError = false;
            }

            if (textBoxTelefonoAlumno.Text == "")
            {
                
               
            }

            if (textBoxDireccionPrimer.Text == "")
            {
                
                ErrorEB.SetError(textBoxDireccionPrimer, "Ingrese  la Direccion");

                noError = false;
            }

            if (comboBoxGenero.Text == "")
            {
              
                ErrorEB.SetError(comboBoxGenero, "Elija Genero");

                noError = false;
            }

            if (textBoxRetrasada.Text == "" && radioButton1.Checked== true )
            {
                
                ErrorEB.SetError(textBoxRetrasada, "Ingrese Materia Retrasada");

                noError = false;
            }

            if (textBoxTPA.Text == "" && radioButton3.Checked == true)
            {
                
                ErrorEB.SetError(textBoxTPA, "Ingrese Materia de TPA");

                noError = false;
            }

            if (textBoxIdEncargado.Text == "" )
            {
               
                ErrorEB.SetError(textBoxIdEncargado, "Ingrese ID del Primer Encargado");

                noError = false;
            }

            if (textBoxNombreEncargado.Text == "")
            {
               
                ErrorEB.SetError(textBoxNombreEncargado, "Ingrese Nombre del Primer encargado");

                noError = false;
            }

            if (textBoxDireccionEncargado.Text == "")
            {
                
                ErrorEB.SetError(textBoxDireccionEncargado, "Ingrese la Direccion del Encargado ");

                noError = false;
            }

            if (textBoxCelularEncargado.Text == "")
            {
                
                ErrorEB.SetError(textBoxCelularEncargado, "Ingrese el Celular de Encargado ");

                noError = false;
            }

            if (textBoxTelefonoEncargado.Text == "")
            {
                
                ErrorEB.SetError(textBoxTelefonoEncargado, "Ingrese el Telefono de Encargado ");

                noError = false;
            }

            if (textBoxCorreoEncargado.Text == "")
            {

                ErrorEB.SetError(textBoxCorreoEncargado, "Ingrese el Correo de Encargado ");

                
                

                noError = false;
            }

            if (textBoxTelefonoAlumno.Text == "")
            {

                ErrorEB.SetError(textBoxTelefonoAlumno, "Ingrese telefono del Alumno ");




                noError = false;
            }



            if (textBoxTrabajoEncargado.Text == "")
            {
               
                ErrorEB.SetError(textBoxTrabajoEncargado, "Ingrese el el lugar de trabajo Encargado ");

                noError = false;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                  if (textBoxIdEncargado2.Text == "" )
            {
                
                ErrorEB.SetError(textBoxIdEncargado2, "Ingrese ID del Primer Encargado");

                noError = false;
            }

            if (textBoxNombreEncargado2.Text == "")
            {
                
                ErrorEB.SetError(textBoxNombreEncargado2, "Ingrese Nombre del segundo encargado");

                noError = false;
            }

            if (textBoxDireccionEncargado2.Text == "")
            {
                
                ErrorEB.SetError(textBoxDireccionEncargado2, "Ingrese la Direccion del Encargado ");

                noError = false;
            }

            if (textBoxCelularEncargado2.Text == "")
            {
                
                ErrorEB.SetError(textBoxCelularEncargado2, "Ingrese el Celular de Encargado ");

                noError = false;
            }

            if (textBoxTelefonoEncargado2.Text == "")
            {
                
                ErrorEB.SetError(textBoxTelefonoEncargado2, "Ingrese el Telefono de Encargado ");

                noError = false;
            }
            
            if (textBoxCorreoEncargado2.Text == "")
            {
               
                ErrorEB.SetError(textBoxCorreoEncargado2, "Ingrese el Correo de Encargado ");

                noError = false;
            }

            if (textBoxTrabajoEncargado2.Text == "")
            {
                
                ErrorEB.SetError(textBoxTrabajoEncargado2, "Ingrese el el lugar de trabajo Encargado ");

                noError = false;
            }

            if (comboBoxGrado.Text == "")
            {
               
                ErrorEB.SetError(comboBoxGrado, "Ingrese el Grado ");

                noError = false;
            }

            if (comboBoxSeccion.Text == "")
            {
                
                ErrorEB.SetError(comboBoxSeccion, "Ingrese la Seccion ");

                noError = false;
            }

            if (textBoxInstituto.Text == "")
            {
                
                ErrorEB.SetError(textBoxInstituto, "Ingrese la Seccion ");

                noError = false;
            }




            return noError;
        }

        private void textBosNombrePrimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void textBoxLugarPrimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void textBoxDireccionPrimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxGenero.Items.Count<=0)
            {
                MessageBox.Show("El genero no puede quedar vacio", "Mensaje", MessageBoxButtons.OK);

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void tetxBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetrasyNumeros(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void tetxBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void tetxBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetrasyNumeros(e);
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox17_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTPA.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
                textBoxRetrasada.Enabled = true;
           
            
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRetrasada.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTPA.Enabled = false;
        }

        private void textBoxDireccionPrimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpiarPrimerIngreso_Click(object sender, EventArgs e)
        {

            ErrorEB.Clear();
            textBoxIdPrimer.Clear();
            textBoxNombrePrimer.Clear();
            textBoxLugarPrimer.Clear();
            textBoxDireccionPrimer.Clear();
            textBoxTelefonoAlumno.Clear();
            textBoxTPA.Clear();
            textBoxRetrasada.Clear();
            textBoxInstituto.Clear();
            textBoxIdEncargado.Clear();
            textBoxIdEncargado2.Clear();
            textBoxNombreEncargado.Clear();
            textBoxNombreEncargado2.Clear();
            textBoxDireccionEncargado.Clear();
            textBoxDireccionEncargado2.Clear();
            textBoxCelularEncargado.Clear();
            textBoxCelularEncargado2.Clear();
            textBoxTelefonoEncargado.Clear();
            textBoxTelefonoEncargado2.Clear();
            textBoxCorreoEncargado.Clear();
            textBoxCorreoEncargado2.Clear();
            textBoxTrabajoEncargado.Clear();
            textBoxTrabajoEncargado2.Clear();
            radioButton2.Checked = true;
            radioButton4.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

        }

        private void textBoxTelefonoAlumno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxLugarPrimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCelularEncargado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxIdPrimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefonoEncargado2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefonoAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBoxCelularEncargado2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBoxCorreoEncargado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTrabajoEncargado2_TextChanged(object sender, EventArgs e)
        {

        }

        private void primerIngreso_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCorreoEncargado2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCelularEncargado2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);
        }

        private void textBoxTrabajoEncargado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
