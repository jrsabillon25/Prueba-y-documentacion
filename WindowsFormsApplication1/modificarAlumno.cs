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
    public partial class modificarAlumno : Form
    {
        public modificarAlumno()
        {
            InitializeComponent();

            radioButton4.Checked = true;
            radioButton2.Checked = true;
        }

        private void modificarAlumno_Load(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            cn.consulta("select * from alumno_encargado", "alumno_encargado");
            dataGridViewAlumnoEncargado.DataSource = cn.ds.Tables["alumno_encargado"];

            cn.consulta("select * from Alumno", "Alumno");
            dataGridViewAlumno.DataSource = cn.ds.Tables["Alumno"];

            cn.consulta("select * from Encargado", "Encargado");
            dataGridViewEncargado.DataSource = cn.ds.Tables["Encargado"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIdEncargadoMod_TextChanged(object sender, EventArgs e)
        {
            conexion cn = new conexion();
           
            if (textBoxIdEncargadoMod.Text != "")
            {    
            cn.consulta("select * from Encargado where codigo_encargado = " + textBoxIdEncargadoMod.Text, "Encargado");
                dataGridViewEncargado.DataSource = cn.ds.Tables["Encargado"];
            }
            else
            {
                cn.consulta("select * from Encargado", "Encargado");
                dataGridViewEncargado.DataSource = cn.ds.Tables["Encargado"];
            }
            
          
        }

        private void textBoxNombreAlumnoMod_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBoxIdAlumnoMod_TextChanged(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            if (textBoxIdAlumnoMod.Text != "")
            {
                cn.consulta("select codigo_alumno, id_alumno, nombre_alumno, direccion_alumno, telefono_alumno from Alumno where codigo_alumno = " + textBoxIdAlumnoMod.Text, "Alumno");
                dataGridViewAlumno.DataSource = cn.ds.Tables["Alumno"];
                cn.consulta("select * from alumno_encargado where codigo_alumno = " + textBoxIdAlumnoMod.Text, "alumno_encargado");
                dataGridViewAlumnoEncargado.DataSource = cn.ds.Tables["alumno_encargado"];
            }
            else
            {
                cn.consulta("select codigo_alumno, id_alumno, nombre_alumno, direccion_alumno, telefono_alumno from Alumno", "Alumno");
                dataGridViewAlumno.DataSource = cn.ds.Tables["Alumno"];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conexion cn = new conexion();
            string actualizar = "nombre_alumno ='" + textBoxNombreAlumnoMod.Text + "', direccion_alumno ='" + textBoxDireccionAlumnoMod.Text + "', telefono_alumno ='" + textBoxTelefonoAlumnoMod.Text + "'";
            if (cn.actualizar("Alumno", actualizar, "codigo_alumno=" + textBoxIdAlumnoMod.Text))
            {
                MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK);
                cn.consulta("select codigo_alumno, id_alumno, nombre_alumno, direccion_alumno, telefono_alumno from Alumno where codigo_alumno = "+ textBoxIdAlumnoMod.Text, "Alumno");
                dataGridViewAlumno.DataSource = cn.ds.Tables["Alumno"];
                
            }
            else
            {
                MessageBox.Show("Error al actualizar el Registro", "Mensaje", MessageBoxButtons.OK);
            }
           

           
        }

        private void dataGridViewAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridViewAlumno.Rows[e.RowIndex];
            textBoxIdAlumnoMod.Text = dgv.Cells[0].Value.ToString();
            textBoxNombreAlumnoMod.Text = dgv.Cells[1].Value.ToString();
            textBoxDireccionAlumnoMod.Text = dgv.Cells[2].Value.ToString();
            textBoxTelefonoAlumnoMod.Text = dgv.Cells[3].Value.ToString();
        }

        private void dataGridViewEncargado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridViewEncargado.Rows[e.RowIndex];
            textBoxIdEncargadoMod.Text = dgv.Cells[0].Value.ToString();
            textBoxNombreEncargadoMod.Text = dgv.Cells[2].Value.ToString();
            textBoxTrabajoEncargadoMod.Text = dgv.Cells[3].Value.ToString();
            textBoxTelefonoEncargadoMod.Text = dgv.Cells[4].Value.ToString();
            textBoxCelularEncargadoMod.Text = dgv.Cells[5].Value.ToString();
            textBoxCorreoEncargadoMod.Text = dgv.Cells[6].Value.ToString();
            textBoxDireccionEncargadoMod.Text = dgv.Cells[7].Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxIdEncargadoMod.Enabled = true;
            textBoxNombreEncargadoMod.Enabled = true;
            textBoxTelefonoEncargadoMod.Enabled = true;
            textBoxTrabajoEncargadoMod.Enabled = true;
            textBoxDireccionEncargadoMod.Enabled = true;
            textBoxCelularEncargadoMod.Enabled = true;
            textBoxCorreoEncargadoMod.Enabled = true;
            button2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxIdEncargadoMod.Enabled = false;
            textBoxNombreEncargadoMod.Enabled = false;
            textBoxTelefonoEncargadoMod.Enabled = false;
            textBoxTrabajoEncargadoMod.Enabled = false;
            textBoxDireccionEncargadoMod.Enabled = false;
            textBoxCelularEncargadoMod.Enabled = false;
            textBoxCorreoEncargadoMod.Enabled = false;
            button2.Enabled = false;
        }

        private void textBoxDireccionEncargadoMod_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDireccionAlumnoMod.Enabled = false;
            textBoxNombreAlumnoMod.Enabled = false;
            textBoxTelefonoAlumnoMod.Enabled = false;
            button1.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTrabajoEncargadoMod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDireccionAlumnoMod.Enabled = true;
            textBoxNombreAlumnoMod.Enabled = true;
            textBoxTelefonoAlumnoMod.Enabled = true;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            string actualizar2 = "nombre_encargado ='" + textBoxNombreEncargadoMod.Text + "', direccion_encargado ='" + textBoxDireccionEncargadoMod.Text + "', telefono_encargado ='" + textBoxTelefonoEncargadoMod.Text + "', celular_encargado ='" + textBoxCelularEncargadoMod.Text + "', email_encargado ='" + textBoxCorreoEncargadoMod.Text + "', lugar_trabajo ='" + textBoxTrabajoEncargadoMod.Text + "'";

            if (cn.actualizar2("Encargado", actualizar2, "codigo_encargado=" + textBoxIdEncargadoMod.Text))
            {
                MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK);
                cn.consulta("select * from Encargado where codigo_encargado ="+ textBoxIdEncargadoMod.Text, "Encargado");
                dataGridViewEncargado.DataSource = cn.ds.Tables["Encargado"];

            }
            else
            {
                MessageBox.Show("Error al actualizar el Registro", "Mensaje", MessageBoxButtons.OK);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
