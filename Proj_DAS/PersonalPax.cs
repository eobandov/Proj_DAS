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
                string query = string.Format("select * from [CitasMedicas].[dbo].[Pacientes] WHERE id_Paciente="+user) ;
                SqlCommand comando = new SqlCommand(query, con);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string[] row1 = new string[] { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetInt32(4).ToString(), reader.GetInt32(5).ToString(), reader.GetString(6) };
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContr.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con = conexion();
                con.Open();
                try
                {
                    string query = string.Format("INSERT INTO [dbo].[Credenciales_Pacientes] ([usuario],[contrasenha]) VALUES '{2}','{3}'", txtUsuario.Text, txtContr.Text);
                    var cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();

            }
            else MessageBox.Show("Los datos son incorrectos", "Fallo al agregar credenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
