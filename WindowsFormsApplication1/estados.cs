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
using System.Web;
using System.Data.Sql;

namespace WindowsFormsApplication1
{
    public partial class estados : Form
    {

        int posicion;
       // bool ok = true;
        conexion cn = new conexion();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0B14AK\\SQLEXPRESS;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");
        public estados()
        {
            
            InitializeComponent();
            
        }

        private void txtnumero_bus_TextChanged(object sender, EventArgs e)
        {

        }

        private void estados_Load(object sender, EventArgs e)
        {
            /* Conexion c = new Conexion();
             c.cargarAula(dgestado_aula);
             c.cargarBuses(dgestado_bus);
             c.cargarEmpleado(dgestado_empleado);
             c.cargarAlumno(dgestado_alumno);
             c.cargarAsignatura(dgestado_asignatura);*/

            DataTable dt = new DataTable();
            //SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");
            string qry = "select Estado.descripcion_estado from Estado";
            
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            con.Open();
           
            da.Fill(dt);
            cmbestado_aula.ValueMember = "codigo_estado";
            cmbestado_aula.DisplayMember = "descripcion_estado";
            cmbestado_bus.ValueMember = "codigo_estado";
            cmbestado_bus.DisplayMember = "descripcion_estado";
            cmbestado_empleado.ValueMember = "codigo_estado";
            cmbestado_empleado.DisplayMember = "descripcion_estado";
            cmbestado_asignatura.ValueMember = "codigo_estado";
            cmbestado_asignatura.DisplayMember = "descripcion_estado";
            cmbestado_aulmno.ValueMember = "codigo_estado"; ;
            cmbestado_aulmno.DisplayMember = "descripcion_estado";

            cmbestado_aula.DataSource = dt;
            cmbestado_bus.DataSource = dt;
            cmbestado_empleado.DataSource = dt;
            cmbestado_aulmno.DataSource = dt;
            cmbestado_asignatura.DataSource = dt;

            //llenar datagrid aula
            DataTable dt2 = new DataTable();
            string qryAula = "select codigo_aula, descricion_aula, descripcion_estado from Aula a join Estado b on a.codigo_estado = b.codigo_estado";
            SqlCommand cmd = new SqlCommand(qryAula, con);
            SqlDataAdapter da2 = new SqlDataAdapter(qryAula, con);
            da2.Fill(dt2);
            dgestado_aula.DataSource = dt2;

            //llenar datagrid buses
            DataTable dt3 = new DataTable();
            string qryBuses = "select codigo_bus, numero_bus, descripcion_estado from Buses a join Estado b on a.codigo_estado = b.codigo_estado";
            SqlCommand cmd1 = new SqlCommand(qryBuses, con);
            SqlDataAdapter da3 = new SqlDataAdapter(qryBuses, con);
            da3.Fill(dt3);
            dgestado_bus.DataSource = dt3;


            //llenar datagrid empleado
            DataTable dt4 = new DataTable();
            string qryEmpleado = "select id_empleado, nombre_empleado, descripcion_estado from Empleado a join Estado b on a.codigo_estado = b.codigo_estado";
            SqlCommand cmd2 = new SqlCommand(qryEmpleado, con);
            SqlDataAdapter da4 = new SqlDataAdapter(qryEmpleado, con);
            da4.Fill(dt4);
            dgestado_empleado.DataSource = dt4;

            //llenar datagrid alumno
            DataTable dt5 = new DataTable();
            string qryalumno = "select id_alumno, nombre_alumno, descripcion_estado from Alumno a join Estado b on a.codigo_estado = b.codigo_estado";
            SqlCommand cmd3 = new SqlCommand(qryalumno, con);
            SqlDataAdapter da5 = new SqlDataAdapter(qryalumno, con);
            da5.Fill(dt5);
            dgestado_alumno.DataSource = dt5;




            //llenar datagrid asignatura
            DataTable dt6 = new DataTable();
            string qryasignatura = "select codigo_asignatura, descripcion_asignatura, descripcion_estado from Asignatura a join Estado b on a.codigo_estado = b.codigo_estado";
            SqlCommand cmd4 = new SqlCommand(qryasignatura, con);
            SqlDataAdapter da6 = new SqlDataAdapter(qryasignatura, con);
            da6.Fill(dt6);
            dgestado_asignatura.DataSource = dt6;





            con.Close();



        }

        private void dgestado_bus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgestado_bus.CurrentRow.Index;
            txtplaca_bus.Text = dgestado_bus[0, posicion].Value.ToString();
            txtnumero_bus.Text = dgestado_bus[1, posicion].Value.ToString();
            cmbestado_bus.Text = dgestado_bus[2, posicion].Value.ToString();

        }

        private void btnmodificar_bus_Click(object sender, EventArgs e)
        {
            string placa_bus, num_bus, estado_bus;
           
                placa_bus = txtplaca_bus.Text;
                num_bus = txtnumero_bus.Text;
                estado_bus = cmbestado_bus.Text;

                dgestado_bus[0, posicion].Value = txtplaca_bus.Text;
                dgestado_bus[1, posicion].Value = txtnumero_bus.Text;
                dgestado_bus[2, posicion].Value = cmbestado_bus.Text;
                MessageBox.Show("Datos Ingresados");
            


            int estado = cmbestado_bus.SelectedIndex + 1;
            string bus = txtplaca_bus.Text;
            string qry = string.Format("update Buses set codigo_estado = {0} where codigo_bus = {1}", estado, bus);
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnmodi_aula_Click(object sender, EventArgs e)
        {
            string cod_aula, desc_aula, estado_aula;
          
                cod_aula = txtcodigo_aula.Text;
                desc_aula = txtdescri_aula.Text;
                estado_aula = cmbestado_aula.Text;

                dgestado_aula[0, posicion].Value = txtcodigo_aula.Text;
                dgestado_aula[1, posicion].Value = txtdescri_aula.Text;
                dgestado_aula[2, posicion].Value = cmbestado_aula.Text;

            int estado = cmbestado_aula.SelectedIndex + 1;
            int aula = Convert.ToInt32(txtcodigo_aula.Text);
            string qry = string.Format("update Aula set codigo_estado = {0} where codigo_aula = {1}", estado, aula);
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            var command = cmd.ExecuteNonQuery();

            MessageBox.Show(command.ToString());
            con.Close();
        }

        private void dgestado_aula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgestado_aula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgestado_aula.CurrentRow.Index;
            txtcodigo_aula.Text = dgestado_aula[0, posicion].Value.ToString();
            txtdescri_aula.Text = dgestado_aula[1, posicion].Value.ToString();
            cmbestado_aula.Text = dgestado_aula[2, posicion].Value.ToString();
        }

        private void dgestado_empleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgestado_empleado.CurrentRow.Index;
            txtid_empleado.Text = dgestado_empleado[0, posicion].Value.ToString();
            txtnom_empleado.Text = dgestado_empleado[1, posicion].Value.ToString();
            cmbestado_empleado.Text = dgestado_empleado[2, posicion].Value.ToString();

        }

        private void dgestado_alumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgestado_alumno.CurrentRow.Index;
            txtcodigo_alumno.Text = dgestado_alumno[0, posicion].Value.ToString();
            txtnombre_alumno.Text = dgestado_alumno[1, posicion].Value.ToString();
            cmbestado_aulmno.Text = dgestado_alumno[2, posicion].Value.ToString();
        }

        private void dgestado_asignatura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgestado_asignatura.CurrentRow.Index;
            txtcodigo_asignatura.Text = dgestado_asignatura[0, posicion].Value.ToString();
            txtdescripcion_asignatura.Text = dgestado_asignatura[1, posicion].Value.ToString();
            cmbestado_asignatura.Text = dgestado_asignatura[2, posicion].Value.ToString();
        }

        private void btnmodificar_asignatura_Click(object sender, EventArgs e)
        {
            string cod_asignatura, desc_asignatura, estado_asignatura;
            cod_asignatura = txtcodigo_asignatura.Text;
            desc_asignatura = txtdescripcion_asignatura.Text;
            estado_asignatura = cmbestado_asignatura.Text;

            dgestado_asignatura[0, posicion].Value = txtcodigo_asignatura.Text;
            dgestado_asignatura[1, posicion].Value = txtdescripcion_asignatura.Text;
            dgestado_asignatura[2, posicion].Value = cmbestado_asignatura.Text;


            int estado = cmbestado_asignatura.SelectedIndex + 1;
            int asignatura = Convert.ToInt32(txtcodigo_asignatura.Text);
            string qry = string.Format("update Asignatura set codigo_estado = {0} where codigo_asignatura = {1}", estado, asignatura);
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            var command = cmd.ExecuteNonQuery();

            MessageBox.Show(command.ToString());
            con.Close();
        }

        private void btnmodif_empleado_Click(object sender, EventArgs e)
        {
            string cod_empleado, nombre_empleado, estado_empleado;
            txtid_empleado.Clear();

            cod_empleado = txtid_empleado.Text;
            nombre_empleado = txtnom_empleado.Text;
            estado_empleado = cmbestado_empleado.Text;

            txtid_empleado.Text = Convert.ToString( dgestado_empleado[0, posicion].Value);
            dgestado_empleado[1, posicion].Value = txtnom_empleado.Text;
            dgestado_empleado[2, posicion].Value = cmbestado_empleado.Text;


            int estado = cmbestado_empleado.SelectedIndex + 1;
            int empleado = Convert.ToInt32(txtid_empleado.Text);
            if (estado == 3)
            {
                string qry = string.Format("update Empleado set codigo_estado = 3, intentos = 0 where id_empleado = {1}", estado, empleado);
                SqlCommand cmd = new SqlCommand(qry, con);
                con.Open();
                var prueba = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(prueba.ToString());       
            }
            else
            {

                string qry = string.Format("update Empleado set codigo_estado = {0}, intentos = 0 where id_empleado = {1}", estado, empleado);
                SqlCommand cmd = new SqlCommand(qry, con);
                con.Open();
                var prueba = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(prueba.ToString());       
            }
        }

        private void btnmodificar_alumno_Click(object sender, EventArgs e)
        {
            string cod_alumno, nombre_alumno, estado_alumno;
            cod_alumno = txtcodigo_alumno.Text;
            nombre_alumno = txtnombre_alumno.Text;
            estado_alumno = cmbestado_aulmno.Text;

            dgestado_alumno[0, posicion].Value = txtcodigo_alumno.Text;
            dgestado_alumno[1, posicion].Value = txtnombre_alumno.Text;
            dgestado_alumno[2, posicion].Value = cmbestado_aulmno.Text;




            int estado = cmbestado_aula.SelectedIndex + 1;
            int alumno = Convert.ToInt32(txtcodigo_alumno.Text);
            string qry = string.Format("update Alumno set codigo_estado = {0} where id_alumno = {1}", estado, alumno);
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            FormLogin irLogin = new FormLogin();
            irLogin.Show();
            this.Hide();
        }

        private void buttonAtrasRegistro_Click(object sender, EventArgs e)
        {
            secretaria irS = new secretaria();
            irS.Show();
            this.Hide();
        }
    }
}
