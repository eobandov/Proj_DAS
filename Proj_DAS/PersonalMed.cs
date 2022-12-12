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
    public partial class PersonalMed : Form
    {
        int user;
        // Agregar variable Paciente de forma global
        public Paciente pax = null;
        public PersonalMed(int User)
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
        private String addORupdateMedico(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgMed.Rows[e.RowIndex];
            int id = 0, tel = 0;
            int.TryParse(row.Cells["cod_Medico"].Value.ToString(), out id);
            String nombre = row.Cells["nombre"].Value.ToString();
            String ap1 = row.Cells["apellido1"].Value.ToString();
            String ap2 = row.Cells["apellido2"].Value.ToString();
            int.TryParse(row.Cells["tel"].Value.ToString(), out tel);
            String correo = row.Cells["correo"].Value.ToString();

            return string.Format("update [dbo].[Medicos] set [nombre]= '{0}', [apellido1]= '{1}', [apellido2]= '{2}', [tel]= {3}, [correo]={4} WHERE [cod_Medico]={5}", nombre, ap1, ap2, tel, correo, id);
        }
        public void cargar()
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                string query = ("select * from [CitasMedicas].[dbo].[Medicos] WHERE id_Paciente=" + user);
                SqlCommand comando = new SqlCommand(query, con);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string[] row1 = new string[] { reader.GetDecimal(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetDecimal(4).ToString(),  reader.GetString(5) };
                    dgMed.Rows.Add(row1);
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
                    string query = string.Format("INSERT INTO [dbo].[Credenciales_Medicos] ([usuario],[contrasenha]) VALUES '{2}','{3}'", txtUsuario.Text, txtContr.Text, user);
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
                        string query = string.Format("UPDATE [dbo].[Credenciales_Medicos] SET [usuario] = '{0}',[contrasenha] = '{1}' WHERE [id_Paciente]={2} ", txtUsuario.Text, txtContr.Text, user);
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

        private void dgMed_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgMed.IsCurrentRowDirty)
                    return;

                string query = addORupdateMedico((DataGridViewCellCancelEventArgs)e);

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
