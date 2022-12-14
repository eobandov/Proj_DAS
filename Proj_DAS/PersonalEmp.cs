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
using System.Collections;

namespace Proj_DAS
{
    public partial class PersonalEmp : Form
    {
        int user;
        public PersonalEmp(int User)
        {
            InitializeComponent();
            this.user = User;
            cargar();
        }

        public static SqlConnection conexion()
        {
            //Aqui se cambia la direccion del db
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true";
            return con;
        }
        public void cargar()
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                string query = string.Format("select * from [CitasMedicas].[dbo].[Empleados] WHERE id_Empleado=" + user);
                SqlCommand comando = new SqlCommand(query, con);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string[] row1 = new string[] { reader.GetDecimal(0).ToString(), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetDecimal(4).ToString(), reader.GetString(5), reader.GetDecimal(6).ToString(),
                        reader.GetDecimal(7).ToString() };
                    dgEmp.Rows.Add(row1);
                }
                else MessageBox.Show("Los datos no se pudieron obtener", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
        private String addORupdateEmpleado(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgEmp.Rows[e.RowIndex];
            int.TryParse(row.Cells["id_Empleado1"].Value.ToString(), out int id);
            String nombre = row.Cells["nombre1"].Value.ToString();
            String ap1 = row.Cells["apellido11"].Value.ToString();
            String ap2 = row.Cells["apellido21"].Value.ToString();
            int.TryParse(row.Cells["tel1"].Value.ToString(), out int tel);
            String correo = row.Cells["correo1"].Value.ToString();
            int.TryParse(row.Cells["num_Cargo"].Value.ToString(), out int cargo);
            int.TryParse(row.Cells["id_Horario"].Value.ToString(), out int horario);

            return string.Format("update [dbo].[Empleados] set [nombre]= '{0}', [apellido1]= '{1}', [apellido2]= '{2}', [tel]= {3}, [correo]='{4}',[num_Cargo]={5}, [id_Horario]={6} WHERE [id_Empleado]={7}", nombre, ap1, ap2, tel, correo, cargo, horario, id);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (txtUsuario.Text != "" && txtContr.Text != "")
            {

                try
                {
                    SqlConnection con = new SqlConnection();
                    con = conexion();
                    con.Open();
                    string query = string.Format("INSERT INTO [dbo].[Credenciales_Empleados] ([usuario],[contrasenha]) VALUES '{2}','{3}'", txtUsuario.Text, txtContr.Text, user);
                    var cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Exito al agregar usuario y contraseña", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    flag = true;
                }
                if (flag)
                {
                    try
                    {

                        SqlConnection con = new SqlConnection();
                        con = conexion();
                        con.Open();
                        string query = string.Format("UPDATE [dbo].[Credenciales_Empleados] SET [usuario] = '{0}',[contrasenha] = '{1}' WHERE [id_Empleado]={2} ", txtUsuario.Text, txtContr.Text, user);
                        var cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Exito al actualizar usuario y contraseña", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fallo al actualizar credenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else MessageBox.Show("Los datos son incorrectos", "Fallo al agregar credenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgEmp_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgEmp.IsCurrentRowDirty)
                    return;
                string query = addORupdateEmpleado((DataGridViewCellCancelEventArgs)e);
                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
    }
}
