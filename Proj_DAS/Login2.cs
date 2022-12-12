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

        public void abrir_inicio(int ww, string mod)
        {
            var fr1 = new Inicio(ww,mod);
            fr1.Location = this.Location;
            fr1.StartPosition = FormStartPosition.Manual;
            fr1.FormClosing += delegate { this.Show(); };
            fr1.Show();
            this.Hide();
        }
        public void abrir_cred()
        {
            var fr1 = new Credenciales();
            fr1.Location = this.Location;
            fr1.StartPosition = FormStartPosition.Manual;
            fr1.FormClosing += delegate { this.Show(); };
            fr1.Show();
            this.Hide();
        }
        private bool login(string cadena, string mod)
        {
            bool flag = false;
            SqlConnection cn = new SqlConnection();
            cn = conexion();
            cn.Open();
            try
            {
                SqlCommand comando = new SqlCommand(cadena, cn);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    decimal t;
                    int ww;
                    string us;
                    user = new Usuario();
                    t = reader.GetDecimal(0);
                    ww = Decimal.ToInt32(t);
                    us = reader.GetString(1);
                    //Cerrando la conexion a la base de datos
                    cn.Close();
                    MessageBox.Show("Bienvenid@ " + us + "!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    abrir_inicio(ww,mod);
                    flag = true;
                }
                else
                {
                     flag = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cn.Close();
            return flag;
        }
        private void btnConexion_Click(object sender, EventArgs e)
        {
            //Log in            
            string query,mod;
            if (txtUsuario.Text != "" || txtContr.Text != "")
            {
                query = "select * from [CitasMedicas].[dbo].[Credenciales_Medicos] WHERE usuario='" + txtUsuario.Text + "' AND contrasenha='" + txtContr.Text + "'";
                mod = "Medico";
                if (login(query,mod) != true)
                {
                    query = "select * from [CitasMedicas].[dbo].[Credenciales_Pacientes] WHERE usuario='" + txtUsuario.Text + "' AND contrasenha='" + txtContr.Text + "'";
                    mod = "Paciente";
                    if (login(query,mod) != true)
                    {
                        query = "select * from [CitasMedicas].[dbo].[Credenciales_Empleados] WHERE usuario='" + txtUsuario.Text + "' AND contrasenha='" + txtContr.Text + "'";
                        mod = "Empleado";
                        if (login(query,mod) != true) MessageBox.Show("Datos de usuario y contraseña no encontrados", "Error de Entrada de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else MessageBox.Show("Favor de ingresar datos de usuario y contraseña", "Error de Entrada de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            abrir_cred();
        }

    }
}
