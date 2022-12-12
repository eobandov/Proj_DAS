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
namespace Proj_DAS
{
    public partial class Credenciales : Form
    {
        public Credenciales()
        {
            InitializeComponent();
            limpiar();
        }
        public static SqlConnection conexion()
        {
            //Aqui se cambia la direccion del db
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true";
            return con;
        }
        public void abrir_login()
        {
            var fr1 = new Login2();
            fr1.Location = this.Location;
            fr1.StartPosition = FormStartPosition.Manual;
            fr1.FormClosing += delegate { this.Show(); };
            fr1.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            abrir_login();
           
        }
        public void limpiar()
        {
            txtUsuario.Clear();
            txtContr.Clear();
            txtValidar.Clear();
        }

        private bool crearCred(string cadena)
        {
            bool flag = false;
            if (txtContr.Text == txtValidar.Text)
            {
                SqlConnection cn = new SqlConnection();
                cn = conexion();
                cn.Open();
                try
                {
                    SqlCommand comando = new SqlCommand(cadena, cn);
                    comando.ExecuteNonQuery();
                    flag = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = false;
                }
                cn.Close();
            }
            else
            {
                MessageBox.Show("Ambas contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return flag;
        }
        private void btnConexion_Click(object sender, EventArgs e)
        {
            String cadena=string.Format("INSERT INTO[dbo].[Credenciales_Pacientes]([usuario],[contrasenha]) VALUES('{0}', '{1}'", txtContr.Text, txtValidar.Text);
            if (crearCred(cadena)!=true)
            {
                cadena = string.Format("INSERT INTO[dbo].[Credenciales_Empleados]([usuario],[contrasenha]) VALUES('{0}', '{1}'", txtContr.Text, txtValidar.Text);
                if (crearCred(cadena) != true)
                {
                    cadena = string.Format("INSERT INTO[dbo].[Credenciales_Medicos]([usuario],[contrasenha]) VALUES('{0}', '{1}'", txtContr.Text, txtValidar.Text);
                    if (crearCred(cadena) != true) MessageBox.Show("Datos de usuario y contraseña no encontrados, favor contactar a los administradores", "Error de Entrada de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else MessageBox.Show("Faltan datos", "Error de Entrada de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
