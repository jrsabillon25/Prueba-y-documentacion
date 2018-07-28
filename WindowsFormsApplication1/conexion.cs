using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class conexion
    {

     
     
     SqlDataReader dr;
     //public SqlConnection conexion.con() = new SqlConnection("Data Source=localhost;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");
     private SqlCommandBuilder cmb;
     public DataSet ds = new DataSet();
     public SqlDataAdapter da = new SqlDataAdapter();
     public SqlCommand cmd = new SqlCommand();
     public DataTable dt = new DataTable();
     public SqlCommand comando;
    
     public static SqlConnection con(){
        /*try{                  
            cn.Open();            
        }catch(Exception ex){
            MessageBox.Show ("No se conecto a la Base de Datos"+ex.ToString());
        }*/
        SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inst_JoseCelilioValle;Integrated Security=True");
        try
        {
            cn.Open();
            MessageBox.Show("conectado");
        }catch(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return cn;
     }

     public bool ExistenciasU(string id)
     {
         bool resultado = true;

         try
         {
             cmd = new SqlCommand("select *from Empleado where   usr_empleado= '" +id+ "'", conexion.con());
             dr = cmd.ExecuteReader();
             if (dr.Read())
             {
                 resultado = false;
             }
         }
         catch (Exception ex)
         {
             MessageBox.Show("Error en el precedimiento:" + ex.ToString());
         }
         dr.Close();
         return resultado;
     }
        
        
        
        
        
        
        public bool Existencias(int id  )
         {
             bool resultado = false;

            try{
             cmd = new SqlCommand("select *from Alumno where  id_alumno= '"+id+"'",conexion.con());
             dr = cmd.ExecuteReader();
             if (dr.Read())
             {
                 resultado = true;
             }
                }
            catch(Exception ex )
             {
                 MessageBox.Show("Error en el precedimiento:"+ ex.ToString());
             }
            dr.Close();
             return resultado;
         }


        /////////////////////////////////////////////////////////////////////////////////////////






         public bool NoExistencias(string id)
         {
            bool resultado = false;

             try
             {
                 cmd = new SqlCommand("select * from Empleado where id_empleado = '" + id + "'", conexion.con());
                 dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                     resultado = false;
                 }
                 else
                 {
                     resultado = true;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error en el precedimiento:" + ex.ToString());
             }
             dr.Close();
             return resultado;
         }

         public bool NoExistenciasA(string id)
         {
             bool resultado = false;

             try
             {
                 cmd = new SqlCommand("select * from Alumno where id_alumno = '" + id + "'", conexion.con());
                 dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                     resultado = false;
                 }
                 else
                 {
                     resultado = true;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error en el precedimiento:" + ex.ToString());
             }
             dr.Close();
             return resultado;
         }


         public bool ExistenciasE(string id)
         {
             bool resultado = false;

             try
             {
                 cmd = new SqlCommand("select *from Empleado where  id_empleado ='" + id + "'", conexion.con());
                 dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                     resultado = true;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error en el precedimiento:" + ex.ToString());
             }
             dr.Close();
             return resultado;
         }




         public bool Existencias2(int id)
         {
             bool resultado = false;

             try
             {
                 cmd = new SqlCommand("select *from Encargado where  id_encargado = '" + id + "'", conexion.con());
                 dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                     resultado = true;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error en el precedimiento:" + ex.ToString());
             }
             dr.Close();
             return resultado;
         }

         public bool ExistenciasCR(int id)
         {
             bool resultado = false;

             try
             {
                 cmd = new SqlCommand("select *from Buses where  codigo_ruta = '" + id + "'", conexion.con());
                 dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                     resultado = true;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error en el precedimiento:" + ex.ToString());
             }
             dr.Close();
             return resultado;
         }


         public bool ExistenciasB(int id)
         {
             bool resultado = false;

             try
             {
                 cmd = new SqlCommand("select * from Buses where  codigo_empleado = '" + id + "'", conexion.con());
                 dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                     resultado = true;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error en el precedimiento:" + ex.ToString());
             }
             dr.Close();
             return resultado;
         }

         public bool ExistenciasNB(int id)
         {
             bool resultado = false;

             try
             {
                 cmd = new SqlCommand("select * from Buses where  numero_bus = '" + id + "'", conexion.con());
                 dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                     resultado = true;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error en el precedimiento:" + ex.ToString());
             }
             dr.Close();
             return resultado;
         }

         public bool ExistenciasPB(string id)
         {
             bool resultado = false;

             try
             {
                 cmd = new SqlCommand("select * from Buses where  placa_bus = '" + id + "'", conexion.con());
                 dr = cmd.ExecuteReader();
                 if (dr.Read())
                 {
                     resultado = true;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error en el precedimiento:" + ex.ToString());
             }
             dr.Close();
             return resultado;
         }

      
        public void consulta(string sql, string tabla)
         {
             try
             {
                 ds.Tables.Clear();
                 da = new SqlDataAdapter(sql, conexion.con());
                 cmb = new SqlCommandBuilder(da);
                 da.Fill(ds, tabla);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
         }
     

        public bool eliminar(string tabla, string condicion)
        {
            
            string elimina = "delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(elimina, conexion.con());
            int i = comando.ExecuteNonQuery();
            conexion.con().Close();
            if(i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool actualizar(string tabla, string campos, string condicion)
        {
            
            string actualizar = "update " + tabla + " set " + campos + " where " + condicion;
            comando = new SqlCommand(actualizar, conexion.con());
            int i = comando.ExecuteNonQuery();
            conexion.con().Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool actualizar2(string tabla, string campos, string condicion)
        {

            string actualizar2 = "update " + tabla + " set " + campos + " where " + condicion;
            comando = new SqlCommand(actualizar2, conexion.con());
            int i = comando.ExecuteNonQuery();
            conexion.con().Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Insertar(string sql)
        {
            comando = new SqlCommand(sql, conexion.con());
            int i = comando.ExecuteNonQuery();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void cargarAula(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from Aula", conexion.con());
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Se Puedo Llenar" + ex.ToString());
            }
        }
        //llama los datoss de buses
        public void cargarBuses(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select codigo_bus,codigo_estado,numero_bus from buses", conexion.con());
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Se Puedo Llenar" + ex.ToString());
            }
        }
        //llama los datoss de Empleados
        public void cargarEmpleado(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select codigo_empleado,nombre_empleado,codigo_estado from Empleado", conexion.con());
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Se Puedo Llenar" + ex.ToString());
            }
        }
        //llama los datoss de Alumnos
        public void cargarAlumno(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select codigo_alumno,nombre_alumno,codigo_estado from Alumno", conexion.con());
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Se Puedo Llenar" + ex.ToString());
            }
        }
        //llama los datoss de asignatura
        public void cargarAsignatura(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from Asignatura", conexion.con());
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Se Puedo Llenar" + ex.ToString());
            }
        }

        public void autocompletado_alumnos(TextBox cajatexto)
        {
            try
            {
                cmd = new SqlCommand("select id_alumno from Alumnos", conexion.con());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cajatexto.AutoCompleteCustomSource.Add(dr["id_alumno"].ToString());

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Se Puedo Guey" + ex.ToString());

            }
        }

     

           }


}
