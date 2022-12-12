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
    public partial class PersonalPax : Form
    {
        int user;
        // Agregar variable Paciente de forma global
        public Paciente pax = null;
        

        public PersonalPax(int User)
        {
            InitializeComponent();
            this.user = User;
            cargarPax();
            cargarDom();
        }
        public static SqlConnection conexion()
        {
            //Aqui se cambia la direccion del db
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true";
            return con;
        }
        private String addORupdateP(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgPax.Rows[e.RowIndex];
            int.TryParse(row.Cells["id_Paciente"].Value.ToString(), out int id);
            String nombre = row.Cells["nombre"].Value.ToString();
            String ap1 = row.Cells["apellido1"].Value.ToString();
            String ap2 = row.Cells["apellido2"].Value.ToString();
            int.TryParse(row.Cells["edad"].Value.ToString(), out int edad);
            int.TryParse(row.Cells["tel"].Value.ToString(), out int tel);
            String correo = row.Cells["correo"].Value.ToString();
            return string.Format("update [dbo].[Pacientes] set [nombre]= '{0}', [apellido1]= '{1}', [apellido2]= '{2}', [edad]= {3}, [tel]= {4}, [correo]='{5}' WHERE [id_Paciente]={6}", nombre, ap1, ap2, edad, tel, correo, id);
        }
        private String addORupdateD(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgDomicilio.Rows[e.RowIndex];
            int.TryParse(row.Cells["id_Paciente1"].Value.ToString(), out int id);
            int.TryParse(row.Cells["num_Provincia"].Value.ToString(), out int prov);
            int.TryParse(row.Cells["num_Domicilio"].Value.ToString(), out int dom);
            String canton = row.Cells["canton1"].Value.ToString();
            String distrito = row.Cells["Distrito"].Value.ToString();
            String senhas = row.Cells["otrasSenhas"].Value.ToString();

            return string.Format("update [dbo].[Domicilio_Pacientes] set [num_Provincia] = {0}, [num_Domicilio] = {1}, [canton] = '{2}', [Distrito] ='{3}',[otrasSenhas] = '{4}' WHERE [id_Paciente]={5}", prov, dom, canton, distrito, senhas, id);
        }
        public void cargarPax()
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                string query = ("select * from [CitasMedicas].[dbo].[Pacientes] WHERE id_Paciente="+user) ;
                SqlCommand comando = new SqlCommand(query, con);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string[] row1 = new string[] { reader.GetDecimal(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetDecimal(4).ToString(), reader.GetDecimal(5).ToString(), reader.GetString(6) };
                    dgPax.Rows.Add(row1);
                    txtContr.Enabled = true;
                    txtUsuario.Enabled = true;
                }
                else MessageBox.Show("Los datos no se pudieron obtener", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
        public void cargarDom()
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                string query = ("select * from [CitasMedicas].[dbo].[Domicilio_Pacientes] WHERE id_Paciente=" + user);
                SqlCommand comando = new SqlCommand(query, con);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string[] row1 = new string[] { reader.GetDecimal(0).ToString(), reader.GetDecimal(1).ToString(), 
                        reader.GetDecimal(2).ToString(), reader.GetString(3),reader.GetString(4), reader.GetString(5)};
                    dgDomicilio.Rows.Add(row1);
                }
                else MessageBox.Show("Los datos no se pudieron obtener", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool flag = false ;
            if (txtUsuario.Text != "" && txtContr.Text != "")
            {
                
                try
                {
                    SqlConnection con = new SqlConnection();
                    con = conexion();
                    con.Open();
                    string query = string.Format("INSERT INTO [dbo].[Credenciales_Pacientes] ([usuario],[contrasenha]) VALUES '{2}','{3}'", txtUsuario.Text, txtContr.Text,user);
                    var cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Exito al agregar usuario y contraseña","Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        string query = string.Format("UPDATE [dbo].[Credenciales_Pacientes] SET [usuario] = '{0}',[contrasenha] = '{1}' WHERE [id_Paciente]={2} ", txtUsuario.Text, txtContr.Text, user);
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
        private void dgPax_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgPax.IsCurrentRowDirty)
                    return;

                string query = addORupdateP((DataGridViewCellCancelEventArgs)e);

                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dgDomicilio_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgDomicilio.IsCurrentRowDirty)
                    return;

                string query = addORupdateD((DataGridViewCellCancelEventArgs)e);

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
