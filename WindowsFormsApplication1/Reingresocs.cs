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
    public partial class Reingresocs : Form
    {
        public Reingresocs()
        {
            InitializeComponent();
            
            radioButtonReingresoContinuo.Checked = true;
            radioButtonMateriaNo.Checked=true;
            radioButtonTPAno.Checked = true;

           

        }

        private void groupBox5_Enter(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRetrasadaReingreso.Enabled = false;
        }

        private void radioButtonTPAno_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTPAreingreso.Enabled = false;
        }
        
        private void Reingresocs_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonTraslado_CheckedChanged(object sender, EventArgs e)
        {
           // label10.ForeColor = Red();

            textBoxProcedenciaReingreso.Enabled = true;
            checkBoxConducta.Enabled = true;
            checkBoxNotas.Enabled = true;
        }

        private void textBoxIdAlumnoReingreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdAlumnoReingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumeros(e);

           
        }

        private void textBoxRetrasadaReingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }

        private void textBoxProcedenciaReingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }


        public bool validarEB()
        {
            bool noError = true;
            int count = 0;


            count=count+1;

            if (count!=0){
              ErrorEB.Clear();
            }
            if (checkBoxNotas.Checked == false && radioButtonTraslado.Checked== true)
            {

                ErrorEB.SetError(checkBoxNotas, "Verifique que entrego Notas");


                noError = false;
            }

            if (checkBoxConducta.Checked == false && radioButtonTraslado.Checked == true)
            {

                ErrorEB.SetError(checkBoxConducta, "Verifique que  entrego Constancia de Conducta");


                noError = false;
            }

            if (checkBoxFoto.Checked == false)
            {

                ErrorEB.SetError(checkBoxFoto, "Verifique que  entrego  Foto");


                noError = false;
            }

            if (checkBoxFoto.Checked == false)
            {

                ErrorEB.SetError(textBoxProcedenciaReingreso, "");


                noError = false;
            }


            if (textBoxIdAlumnoReingreso.Text == "")
            {
                
                ErrorEB.SetError(textBoxIdAlumnoReingreso, "Ingrese  el ID del Alumno");
              
                
                noError = false;
            }

             if (comboBoxGrado2.Text == "")
            {
                
                ErrorEB.SetError(comboBoxGrado2, "Ingrese el Grado a Matricular");
              
                
                noError = false;
            }

                 if (comboBoxSeccion2.Text == "")
            {
                
                ErrorEB.SetError(comboBoxSeccion2, "Ingrese la Seccion");
              
                
                noError = false;
            }

                   if (    textBoxRetrasadaReingreso.Text == "" && radioButtonMateriaSi.Checked==true)
            {
                
                ErrorEB.SetError( textBoxRetrasadaReingreso, "Ingrese la Materia Retrasada");
              
                
                noError = false;
            }

                        if (    textBoxTPAreingreso.Text == "" && radioButtonTPAsi.Checked==true   )
            {
                
                ErrorEB.SetError( textBoxTPAreingreso, "Ingrese TPA");
              
                
                noError = false;
            }

                        if (textBoxProcedenciaReingreso.Text == "" && radioButtonTraslado.Checked == true)
            {
                
                ErrorEB.SetError( textBoxProcedenciaReingreso, "Ingrese Instituto de Precedencia");
              
                
                noError = false;
            }

        

            return noError;
        }  
        private void button1_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            bool respuesta = true;

        
            
     
            if (validarEB())
            {
                respuesta = cn.NoExistenciasA(Convert.ToString(textBoxIdAlumnoReingreso.Text));
                ErrorEB.Clear();

                if (respuesta != true)
                {



                    string año2 = dateTimePickerReingreso.Text;

                    DataClasses1DataContext db = new DataClasses1DataContext();

                    int codigo = Convert.ToInt32(textBoxIdAlumnoReingreso.Text);
                    conexion xl = new conexion();
                    SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");

                    conn.Open();
                    string comando =  string.Format("select count(a.codigo_alumno) from  [dbo].[Alumno] a inner join [dbo].[grado_alumno] b on a.codigo_alumno = b.codigo_alumno inner join [dbo].[Periodos_Grado] c on b.codigo_periodoGrado = c.codigo_periodoGrado inner join [dbo].[Grado] d on c.codigo_grado= d.codigo_grado inner join [dbo].[Seccion] e on c.codigo_seccion = e.codigo_seccion where c.codigo_grado = {0} AND c.codigo_seccion = {1}", comboBoxGrado2.SelectedIndex +1, comboBoxSeccion2.SelectedIndex+1);
                    SqlCommand cmd = new SqlCommand(comando ,conn);
                    
                    Int32 count = (Int32)cmd.ExecuteScalar();
                    conn.Close();
                    
                    if (count <= 30)
                    {
                        string actualizar = "materiaRetrasada ='" + textBoxRetrasadaReingreso.Text + "',materiaTPA ='" + textBoxTPAreingreso + "', instituto_procedencia ='" + textBoxProcedenciaReingreso.Text + "'";
                        if (cn.actualizar("Alumno", actualizar, "id_alumno=" + textBoxIdAlumnoReingreso.Text))
                        {
                            MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK);

                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el Registro", "Mensaje", MessageBoxButtons.OK);
                        }
                        if (comboBoxGrado2.Text == "1er grado")
                        {
                            textBoxGrado2.Clear();
                            textBoxGrado2.Text = "1";
                        }
                        if (comboBoxGrado2.Text == "2do grado")
                        {
                            textBoxGrado2.Clear();
                            textBoxGrado2.Text = "2";
                        }
                        if (comboBoxGrado2.Text == "3er grado")
                        {
                            textBoxGrado2.Clear();
                            textBoxGrado2.Text = "3";
                        }
                        if (comboBoxGrado2.Text == "4to grado")
                        {
                            textBoxGrado2.Clear();
                            textBoxGrado2.Text = "4";
                        }
                        if (comboBoxGrado2.Text == "5to grado")
                        {
                            textBoxGrado2.Clear();
                            textBoxGrado2.Text = "5";
                        }
                        if (comboBoxGrado2.Text == "6to grado")
                        {
                            textBoxGrado2.Clear();
                            textBoxGrado2.Text = "6";
                        }
                        if (comboBoxGrado2.Text == "7mo grado")
                        {
                            textBoxGrado2.Clear();
                            textBoxGrado2.Text = "7";
                        }
                        if (comboBoxGrado2.Text == "8vo grado")
                        {
                            textBoxGrado2.Clear();
                            textBoxGrado2.Text = "8";
                        }
                        if (comboBoxGrado2.Text == "9no grado")
                        {
                            textBoxGrado2.Clear();
                            textBoxGrado2.Text = "9";
                        }
                        if (comboBoxGrado2.Text == "10mo grado")
                        {
                            textBoxGrado2.Clear();
                            textBoxGrado2.Text = "10";
                        }
                        if (comboBoxGrado2.Text == "11vo grado")
                        {
                            textBoxGrado2.Clear();
                            textBoxGrado2.Text = "11";
                        }
                        int grado2;
                        grado2 = Int32.Parse(textBoxGrado2.Text);

                        if (comboBoxSeccion2.Text == "A")
                        {
                            textBoxSeccion2.Clear();
                            textBoxSeccion2.Text = "1";
                        }
                        if (comboBoxSeccion2.Text == "B")
                        {
                            textBoxSeccion2.Clear();
                            textBoxSeccion2.Text = "2";
                        }
                        if (comboBoxSeccion2.Text == "C")
                        {
                            textBoxSeccion2.Clear();
                            textBoxSeccion2.Text = "3";
                        }

                        int seccion2;
                        seccion2 = Int32.Parse(textBoxSeccion2.Text);

                        if (comboBoxGrado2.Text == "1er grado" && comboBoxSeccion2.Text == "A")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "1";
                        }
                        if (comboBoxGrado2.Text == "1er grado" && comboBoxSeccion2.Text == "B")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "2";
                        }
                        if (comboBoxGrado2.Text == "1er grado" && comboBoxSeccion2.Text == "C")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "3";
                        }
                        if (comboBoxGrado2.Text == "2do grado" && comboBoxSeccion2.Text == "A")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "4";
                        }
                        if (comboBoxGrado2.Text == "2do grado" && comboBoxSeccion2.Text == "B")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "5";
                        }
                        if (comboBoxGrado2.Text == "2do grado" && comboBoxSeccion2.Text == "C")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "6";
                        }
                        if (comboBoxGrado2.Text == "3er grado" && comboBoxSeccion2.Text == "A")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "7";
                        }
                        if (comboBoxGrado2.Text == "3er grado" && comboBoxSeccion2.Text == "B")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "8";
                        }
                        if (comboBoxGrado2.Text == "3er grado" && comboBoxSeccion2.Text == "C")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "9";
                        }
                        if (comboBoxGrado2.Text == "4to grado" && comboBoxSeccion2.Text == "A")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "10";
                        }
                        if (comboBoxGrado2.Text == "4to grado" && comboBoxSeccion2.Text == "B")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "11";
                        }
                        if (comboBoxGrado2.Text == "4to grado" && comboBoxSeccion2.Text == "C")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "12";
                        }
                        if (comboBoxGrado2.Text == "5to grado" && comboBoxSeccion2.Text == "A")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "13";
                        }
                        if (comboBoxGrado2.Text == "5to grado" && comboBoxSeccion2.Text == "B")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "14";
                        }
                        if (comboBoxGrado2.Text == "5to grado" && comboBoxSeccion2.Text == "C")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "15";
                        }
                        if (comboBoxGrado2.Text == "6to grado" && comboBoxSeccion2.Text == "A")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "16";
                        }
                        if (comboBoxGrado2.Text == "6to grado" && comboBoxSeccion2.Text == "B")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "17";
                        }
                        if (comboBoxGrado2.Text == "6to grado" && comboBoxSeccion2.Text == "C")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "18";
                        }
                        if (comboBoxGrado2.Text == "7mo grado" && comboBoxSeccion2.Text == "A")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "19";
                        }
                        if (comboBoxGrado2.Text == "7mo grado" && comboBoxSeccion2.Text == "B")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "20";
                        }
                        if (comboBoxGrado2.Text == "7mo grado" && comboBoxSeccion2.Text == "C")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "21";
                        }
                        if (comboBoxGrado2.Text == "8vo grado" && comboBoxSeccion2.Text == "A")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "22";
                        }
                        if (comboBoxGrado2.Text == "8vo grado" && comboBoxSeccion2.Text == "B")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "23";
                        }
                        if (comboBoxGrado2.Text == "8vo grado" && comboBoxSeccion2.Text == "C")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "24";
                        }
                        if (comboBoxGrado2.Text == "9no grado" && comboBoxSeccion2.Text == "A")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "25";
                        }
                        if (comboBoxGrado2.Text == "9no grado" && comboBoxSeccion2.Text == "B")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "26";
                        }
                        if (comboBoxGrado2.Text == "9no grado" && comboBoxSeccion2.Text == "C")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "27";
                        }
                        if (comboBoxGrado2.Text == "10mo grado" && comboBoxSeccion2.Text == "A")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "28";
                        }
                        if (comboBoxGrado2.Text == "10mo grado" && comboBoxSeccion2.Text == "B")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "29";
                        }
                        if (comboBoxGrado2.Text == "10mo grado" && comboBoxSeccion2.Text == "C")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "30";
                        }
                        if (comboBoxGrado2.Text == "11vo grado" && comboBoxSeccion2.Text == "A")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "31";
                        }
                        if (comboBoxGrado2.Text == "11vo grado" && comboBoxSeccion2.Text == "B")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "32";
                        }
                        if (comboBoxGrado2.Text == "11vo grado" && comboBoxSeccion2.Text == "C")
                        {
                            textBoxGrado2.Clear(); textBoxAula2.Text = "33";
                        }

                        int aula2;
                        aula2 = Int32.Parse(textBoxAula2.Text);


                        db.ingresarPeriodosGrados(dateTimePickerReingreso.Text, grado2, seccion2, aula2);
                        db.insertarGradoAlumno();
                        MessageBox.Show("Datos Guardados correctamente", "Mensaje", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Seccion ya tiene 30 alumnos");
                    }

                    }
                    else
                    {
                        MessageBox.Show("El id NO Existe", "Mensaje", MessageBoxButtons.OK);

                    }
                
              } 
            
            
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(comboBoxGrado2.Items.Count<=0)
            {
                MessageBox.Show("El genero no puede quedar vacio", "Mensaje", MessageBoxButtons.OK);

            }
        }

        private void textBoxProcedenciaReingreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonReingresoContinuo_CheckedChanged(object sender, EventArgs e)
        {
            ErrorEB.Clear();
            textBoxProcedenciaReingreso.Enabled = false;
            checkBoxConducta.Enabled = false;
            checkBoxNotas.Enabled = false;
        }

        private void radioButtonTPAsi_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTPAreingreso.Enabled = true;
        }

        private void radioButtonMateriaSi_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRetrasadaReingreso.Enabled = true;
        }

        private void comboBoxSeccion2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificarAlumno irAlumno = new modificarAlumno();
            irAlumno.Show();
            this.Hide();
        }

        private void textBoxGrado2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreAlumnoReingreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreAlumnoReingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           conexion cn = new conexion();


           /*string cadSql = "select nombre_alumno from Alumno where id_alumno='"+ textBoxIdAlumnoReingreso.Text + "' ";
           
           SqlCommand p = new SqlCommand(cadSql);
           cn.Open();
           textBoxNombreAlumnoReingreso.Text = Convert.ToString(p.ExecuteNonQuery());*/

           


            //textBoxNombreAlumnoReingreso
        }

        private string ToString(SqlCommand p)
        {
            throw new NotImplementedException();
        }

        private void textBoxTPAreingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetas(e);
        }
    
         
     }
}