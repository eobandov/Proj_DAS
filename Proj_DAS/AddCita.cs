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
    public partial class AddCita : Form
    {
        public AddCita()
        {
            InitializeComponent();
            init();
        }
        public static SqlConnection conexion()
        {
            //Aqui se cambia la direccion del db
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true";
            return con;
        }

        private String AdaddORupdateCita()
        {
            int.TryParse(txtConsul.Text, out int consul);
            int.TryParse(txtMed.Text, out int med);
            int.TryParse(txtPax.Text, out int pax);
            int.TryParse(txtEmp.Text, out int emp);
            int.TryParse(txtCita.Text, out int cita);

            if (txtCita.Text == "")            
                return String.Format("INSERT INTO [dbo].[Citas] ([fechaCita],[horaCita],[consultorio],[cod_Medico],[id_Paciente], " +
                    "[id_Empleado]) VALUES ('{0}','{1}', {2},{3},{4},{5})", txtFecha.Text, txtHora.Text, consul, med,pax,emp);
            else return String.Format("UPDATE [dbo].[Citas] SET [fechaCita] ='{0}',[horaCita]='{1}',[consultorio]={2},[cod_Medico]" +
                "={3},[id_Paciente]={4}, [id_Empleado]={5} WHERE [cod_Cita]={6}", txtFecha.Text, txtHora.Text,consul, med,
                    pax, emp,cita);

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dbprocedimiento();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtCita.Enabled = true;
            if (txtCita.Text != "") dbprocedimiento();
            else MessageBox.Show("Ingresar ahora codigo de la cita que desea cambiar", "Modificar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void init()
        {
            txtCita.Clear();
            txtMed.Clear();
            txtPax.Clear();
            txtFecha.Clear();
            txtHora.Clear();
            txtConsul.Clear();
            txtEmp.Clear();
            txtCita.Enabled = false;           
        }
        private void dbprocedimiento()
        {
            if (txtMed.Text != "" || txtPax.Text != "" || txtFecha.Text != "" || txtHora.Text != "" || txtConsul.Text != "" || txtEmp.Text != "")
            {

                //Abrir conexion
                SqlConnection cn = new SqlConnection();
                cn = conexion();
                cn.Open();
                try
                {
                    //Enviar query
                    string cadena = AdaddORupdateCita();
                    SqlCommand comando = new SqlCommand(cadena, cn);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Consulta enviada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                cn.Close();

            }
            else MessageBox.Show("Favor de ingresar todos los datos", "Error de Entrada de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            init();
        }
    }
}
