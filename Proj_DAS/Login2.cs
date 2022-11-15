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
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
            limpiar();
        }

        // Agregar variable Usuario de forma global
        public Usuario user = null;

        public static SqlConnection conexion()
        {
            //Aqui se cambia la direccion del db
            //"server=localhost ; database=CitasMedicas ; integrated security = true"
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true";
            return con;
        }
        public void limpiar()
        {
            txtUsuario.Clear();
            txtContr.Clear();
        }

        public void abrir_inicio()
        {
            var fr1 = new Inicio();
            fr1.Location = this.Location;
            fr1.StartPosition = FormStartPosition.Manual;
            fr1.FormClosing += delegate { this.Show(); };
            fr1.Show();
            this.Hide();
        }
        private void btnConexion_Click(object sender, EventArgs e)
        {
            //Log in            
            
            if (txtUsuario.Text != "" || txtContr.Text != "")
            {
                //Abrir conexion
                SqlConnection cn = new SqlConnection();
                cn = conexion();
                cn.Open();

                //Enviar query
                string cadena = "select * from [CitasMedicas ].[dbo].[Credenciales_Empleados] WHERE usuario='" + txtUsuario.Text + "' AND contrasenha='" + txtContr.Text+"'";

                SqlCommand comando = new SqlCommand(cadena, cn);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    user = new Usuario();
                    user.usuario = reader.GetString(2);
                    //Cerrando la conexion a la base de datos
                    cn.Close();
                    MessageBox.Show("Bienvenid@ "+user.usuario+"!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    abrir_inicio();
                }
                else
                {
                    MessageBox.Show("Los datos son incorrectos", "Fallo de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
                cn.Close();

            }
            else
            {
                MessageBox.Show("Favor de ingresar datos de usuario y contraseña", "Error de Entrada de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContr_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
