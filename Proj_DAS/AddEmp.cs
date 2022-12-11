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
    public partial class AddEmp : Form
    {
        static string conString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true";
        SqlConnection con = new SqlConnection(conString);
        public AddEmp()
        {
            InitializeComponent();
        }
        public static SqlConnection conexion()
        {
            //Aqui se cambia la direccion del db
            SqlConnection con = new SqlConnection
            {
                ConnectionString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true"
            };
            return con;
        }
        private void cargar()
        {
            this.empleadosTableAdapter.Fill(this.dSEmpleados.Empleados);
        }
        private void AddEmp_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private String addORupdateEmpleado(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgEmp.Rows[e.RowIndex];
            int id = 0, tel = 0, cargo = 0, horario=0;
            int.TryParse(row.Cells["id_Empleado1"].Value.ToString(), out id);
            String nombre = row.Cells["nombre1"].Value.ToString();
            String ap1 = row.Cells["apellido11"].Value.ToString();
            String ap2 = row.Cells["apellido21"].Value.ToString();
            int.TryParse(row.Cells["tel1"].Value.ToString(), out tel);
            String correo = row.Cells["correo1"].Value.ToString();
            int.TryParse(row.Cells["num_Cargo"].Value.ToString(), out cargo);
            int.TryParse(row.Cells["id_Horario"].Value.ToString(), out horario);

            if (id>0) return string.Format("update [dbo].[Empleados] set [nombre]= '{0}', [apellido1]= '{1}', [apellido2]= '{2}', [tel]= {3}, [correo]='{4}',[num_Cargo]={5}, [id_Horario]={6} WHERE [id_Empleado]={7}", nombre, ap1, ap2, tel, correo, cargo, horario, id);
            else return string.Format("insert into [dbo].[Empleados]  values ('{0}','{1}','{2}',{3},'{4}',{5},{6})", nombre, ap1, ap2, tel, correo, cargo, horario);
        }
        
        private void dgEmp_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            con = new SqlConnection();
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

        
        private void dgEmp_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["id_Empleado1"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Credenciales_Empleados] WHERE [id_Empleado] = {0}", id);
                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                query = string.Format("DELETE FROM [dbo].[Empleados] WHERE [id_Empleado] = {0}", id);
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }

    }
}
