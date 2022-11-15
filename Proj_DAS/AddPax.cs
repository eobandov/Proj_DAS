using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data
    .SqlClient;
namespace Proj_DAS
{
    public partial class AddPax : Form
    {
        String mod = "";
        public AddPax(String mod)
        {
            InitializeComponent();
            limpiar();
            this.mod = mod;
            if (mod == "Modificar usuario") 
            { 
                prepMod(false);
                btnAgregar.Text = "Modificar usuario";
            }
        }
        public static SqlConnection conexion()
        {
            //Aqui se cambia la direccion del db
            //"server=localhost ; database=CitasMedicas ; integrated security = true"
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true";
            return con;
        }
        public Boolean user = true;
        public Paciente pac = null;
        public void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtEdad.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtProvincia.Clear();
            txtCanton.Clear();
            txtDistrito.Clear();
            txtSenhas.Clear();
            txtUsuario.Clear();
            txtContr.Clear();
        }

        public int provincia(String p)
        {
            int prov=0;
            switch (p)
            {
                case "San Jose": prov = 1; break;
                case "Alajuela": prov = 2; break;
                case "Cartago": prov = 3; break;
                case "Heredia": prov = 4; break;
                case "Guanacaste": prov = 5; break;
                case "Puntarenas": prov = 6; break;
                case "Limon": prov = 7; break;
                default: prov = 0; break;
            }
            return prov;
        }
        public int conteo()
        {
            int cont = 0;

            SqlConnection cn = new SqlConnection();
            cn = conexion();
            cn.Open();

            string cadena = "select count(*) from [CitasMedicas ].[dbo].[Domicilio_Pacientes]";

            SqlCommand comando = new SqlCommand(cadena, cn);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                cont = reader.GetInt32(0);
                //Cerrando la conexion a la base de datos
                cn.Close();
            }

            return cont;
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (verificar() == false) MessageBox.Show("Faltan datos", "Fallo en Agregar nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                switch (mod)
                {
                    case "Agregar usuario":

                        //Abrir conexion
                        SqlConnection cn = new SqlConnection();
                        cn = conexion();
                        cn.Open();

                        //Enviar query
                        string cadena = "select * from [CitasMedicas ].[dbo].[Pacientes] WHERE id_Paciente=" + txtId.Text;

                        SqlCommand comando = new SqlCommand(cadena, cn);
                        SqlDataReader reader = comando.ExecuteReader();

                        if (reader.Read())
                        {
                            user = true;
                            MessageBox.Show("Usuario encontrado, no se puede volver a agregar.", "Fallo en Agregar nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            prepMod(true);
                        }
                        else
                        {
                            user = false;
                            btnAgregar.Enabled = true;
                            MessageBox.Show("Usuario puede ser agregado ahora.", "Agregar nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //Cerrando la conexion a la base de datos
                        cn.Close();

                        break;
                    case "Modificar usuario":
                        SqlConnection con = new SqlConnection();
                        con = conexion();
                        con.Open();

                        //Enviar query
                        string cadena2 = "select * from [CitasMedicas ].[dbo].[Pacientes] WHERE id_Paciente=" + txtId.Text;
                        SqlCommand comando2 = new SqlCommand(cadena2, con);
                        SqlDataReader reader2 = comando2.ExecuteReader();

                        if (reader2.Read())
                        {
                            user = true;
                            MessageBox.Show("Usuario encontrado, ahora se puede modificar.", "Modficar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            prepMod(true);

                            //Obtener datos
                            pac = new Paciente();
                            pac.id_Paciente = Decimal.ToInt32(reader2.GetDecimal(0));
                            pac.nombre = reader2.GetString(1);
                            pac.apellido1 = reader2.GetString(2);
                            pac.apellido2 = reader2.GetString(3);
                            pac.edad = Decimal.ToInt32(reader2.GetDecimal(4));
                            pac.tel = Decimal.ToInt32(reader2.GetDecimal(5));

                            //Cerrando la conexion a la base de datos
                            con.Close();
                            txtNombre.Text = pac.nombre;
                            txtApellido1.Text = pac.apellido1;
                            txtApellido2.Text = pac.apellido2;
                            txtEdad.Text = pac.edad.ToString();
                            txtTelefono.Text = pac.tel.ToString();
                            btnAgregar.Enabled = true;
                        }
                        else
                        {
                            user = false;
                            MessageBox.Show("Usuario no encontrado.", "Fallo en modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        con.Close();
                        break;
                }
            }
            
            
        }
        public Boolean verificar()
        {
            Boolean flag = false;

            if (txtId.Text != "" || txtNombre.Text != "" || txtApellido1.Text != "" || txtApellido2.Text != "" ||
                txtEdad.Text != "" || txtTelefono.Text != "" || txtCorreo.Text != "" || txtUsuario.Text != "" ||
                txtContr.Text != "" || txtProvincia.Text != "" || txtCanton.Text != "" || txtDistrito.Text != "" ||
                txtSenhas.Text != "" )
            {
                flag = true;
            }           
            return flag;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (user == false)
            {
                int cont;
                cont = conteo();

                //Abrir conexion
                SqlConnection cn = new SqlConnection();
                cn = conexion();
                cn.Open();

                //Enviar query
                string cadena = "insert into [CitasMedicas ].[dbo].[Pacientes] values(" + txtId.Text + ",'" + txtNombre.Text + "','"
                    + txtApellido1.Text + "','" + txtApellido2.Text + "'," + txtEdad.Text + "," + txtTelefono.Text + ")";

                SqlCommand com1 = new SqlCommand(cadena, cn);
                com1.ExecuteNonQuery();

                int prov = provincia(txtProvincia.Text);

                cadena = "insert into [CitasMedicas ].[dbo].[Domicilio_Pacientes] values(" + prov + "," + cont + "," + txtId.Text + ",'" + txtCanton.Text +
                    "','" + txtDistrito.Text + "','" + txtSenhas.Text + "')";

                SqlCommand com2 = new SqlCommand(cadena, cn);
                com2.ExecuteNonQuery();

                MessageBox.Show("Los datos se almacenaron correctamente", "Control de Entrada de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Cerrando la conexion a la base de datos
                cn.Close();

                limpiar();
            }
            else if (user == true)
            {
                SqlConnection cn = new SqlConnection();
                cn = conexion();
                cn.Open();

                //CAMBIARLO
                string cadena = "update * from [CitasMedicas ].[dbo].[Pacientes] WHERE id_Paciente=" + txtId.Text ;

                SqlCommand comando = new SqlCommand(cadena, cn);

                cn.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Inicio fr = new Inicio()
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            fr.FormClosing += delegate { this.Show(); };
            fr.Show();
            this.Hide();
        }
        public void prepMod(Boolean h)
        {          
            txtNombre.Enabled = h;
            txtApellido1.Enabled = h;
            txtApellido2.Enabled =h;
            txtEdad.Enabled = h;
            txtTelefono.Enabled = h;
            txtCorreo.Enabled = h;
            txtProvincia.Enabled = h;
            txtCanton.Enabled = h;
            txtDistrito.Enabled = h;
            txtSenhas.Enabled = h;
            txtUsuario.Enabled = h;
            txtContr.Enabled =h;
        }
    }
}
