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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true";
            return con;
        }

        private void AddEmp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'citasMedicasDataSet8.Correo_Empleados' Puede moverla o quitarla según sea necesario.
            this.correo_EmpleadosTableAdapter2.Fill(this.citasMedicasDataSet8.Correo_Empleados);
            this.cargo_EmpleadosTableAdapter.Fill(this.citasMedicasDataSet7.Cargo_Empleados);
            this.horario_EmpleadosTableAdapter.Fill(this.citasMedicasDataSet6.Horario_Empleados);
            //this.correo_EmpleadosTableAdapter.Fill(this.citasMedicasDataSet4.Correo_Empleados);
            this.empleadosTableAdapter.Fill(this.citasMedicasDataSet3.Empleados);

        }
        private String addORupdateEmpleado(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgEmp.Rows[e.RowIndex];
            int id = 0, tel = 0;
            int.TryParse(row.Cells["id_Empleado"].Value.ToString(), out id);
            String nombre = row.Cells["nombre"].Value.ToString();
            String ap1 = row.Cells["apellido1"].Value.ToString();
            String ap2 = row.Cells["apellido2"].Value.ToString();
            int.TryParse(row.Cells["tel"].Value.ToString(), out tel);

            if (id == 0) return string.Format("insert into [dbo].[Empleados]  values ({0},'{1}','{2}','{3}',{4})", id, nombre, ap1, ap2, tel);
            else return string.Format("update [dbo].[Empleados] set [nombre]= '{0}', [apellido1]= '{1}', [apellido2]= '{2}', [tel]= {3} WHERE [id_Empleado]={4}", nombre, ap1, ap2, tel, id);
        }

        private String addORupdateCorreo(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgCorreo.Rows[e.RowIndex];
            int id = 0, num = 0;
            int.TryParse(row.Cells["id_Empleado2"].Value.ToString(), out id);
            String correo = row.Cells["correo"].Value.ToString();
            int.TryParse(row.Cells["num_Correo"].Value.ToString(), out num);

            if (num == 0) return string.Format("insert into [dbo].[Correo_Empleados]  values ({0},{1},'{2}')", num, id, correo);
            else return string.Format("update [dbo].[Correo_Empleados] set [correo]= '{0}' WHERE [id_Empleado]={1}", correo, id);
        }

        private String addORupdateHorario(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgHorario.Rows[e.RowIndex];
            int id = 0, hor = 0;
            int.TryParse(row.Cells["id_Empleado3"].Value.ToString(), out id);
            int.TryParse(row.Cells["id_Horario"].Value.ToString(), out hor);
            String inicio = row.Cells["dia_Inicio"].Value.ToString();
            String fin = row.Cells["dia_Final"].Value.ToString();

            if (hor == 0) return string.Format("insert into [dbo].[Horario_Empleados]  values ({0},{1},'{2}','{3}')", id, hor, inicio, fin);
            else return string.Format("update [dbo].[Horario_Empleados] set [id_Horario] = {0}, [dia_Inicio] = '{1}', [dia_Final] = '{2}' WHERE [id_Empleado]={3}", hor, inicio, fin, id);
        }
        private String addORupdateCargo(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgCargo.Rows[e.RowIndex];
            int id = 0, num = 0;
            int.TryParse(row.Cells["id_Empleado4"].Value.ToString(), out id);
            String cargo = row.Cells["cargo"].Value.ToString();
            int.TryParse(row.Cells["num_Cargo"].Value.ToString(), out num);

            if (num == 0) return string.Format("insert into [dbo].[Cargo_Empleados]  values ({0},{1},'{2}')", num, id, cargo);
            else return string.Format("update [dbo].[Cargo_Empleados] set [cargo]= '{0}' WHERE [id_Empleado]={1}", cargo, id);
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

        private void dgCorreo_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgCorreo.IsCurrentRowDirty)
                    return;

                string query = addORupdateCorreo((DataGridViewCellCancelEventArgs)e);

                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dgCargo_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgCargo.IsCurrentRowDirty)
                    return;

                string query = addORupdateCargo((DataGridViewCellCancelEventArgs)e);

                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dgHorario_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgHorario.IsCurrentRowDirty)
                    return;

                string query = addORupdateHorario((DataGridViewCellCancelEventArgs)e);

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
                int.TryParse(e.Row.Cells["id_Empleado"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Empleados] WHERE [id_Empleado] = {0}", id);
                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dgCorreo_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["id_Empleado2"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Correo_Empleados] WHERE [id_Empleado] = {0}", id);
                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dgCargo_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["id_Empleado3"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Cargo_Empleados] WHERE [id_Empleado] = {0}", id);
                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dgHorario_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["id_Empleado4"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Horario_Empleados] WHERE [id_Empleado] = {0}", id);
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
