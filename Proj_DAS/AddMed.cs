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
    public partial class AddMed : Form
    {
        static string conString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true";
        SqlConnection con = new SqlConnection(conString);

        public AddMed()
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

        private void AddMed_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'citasMedicasDataSet12.Especialidad_Medicos' Puede moverla o quitarla según sea necesario.
            this.especialidad_MedicosTableAdapter.Fill(this.citasMedicasDataSet12.Especialidad_Medicos);
            // TODO: esta línea de código carga datos en la tabla 'citasMedicasDataSet11.Disponibilidad_Medicos' Puede moverla o quitarla según sea necesario.
            this.disponibilidad_MedicosTableAdapter.Fill(this.citasMedicasDataSet11.Disponibilidad_Medicos);
            // TODO: esta línea de código carga datos en la tabla 'citasMedicasDataSet10.Correo_Médicos' Puede moverla o quitarla según sea necesario.
            this.correo_MédicosTableAdapter.Fill(this.citasMedicasDataSet10.Correo_Médicos);
            // TODO: esta línea de código carga datos en la tabla 'citasMedicasDataSet9.Medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.citasMedicasDataSet9.Medicos);

        }

        private String addORupdateMedico(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgMed.Rows[e.RowIndex];
            int id = 0, tel=0;
            int.TryParse(row.Cells["cod_Medico"].Value.ToString(), out id);
            String nombre = row.Cells["nombre"].Value.ToString();
            String ap1 = row.Cells["apellido1"].Value.ToString();
            String ap2 = row.Cells["apellido2"].Value.ToString();
            int.TryParse(row.Cells["tel"].Value.ToString(), out tel);

            if (id == 0) return string.Format("insert into [dbo].[Medicos]  values ({0},'{1}','{2}','{3}',{4})", id, nombre, ap1, ap2, tel);
            else return string.Format("update [dbo].[Medicos] set [nombre]= '{0}', [apellido1]= '{1}', [apellido2]= '{2}', [tel]= {3} WHERE [cod_Medico]={4}", nombre, ap1, ap2, tel, id); //Cambiar la tilde de la variable medico en la DB
        }
        private String addORupdateCorreo(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgCorreo.Rows[e.RowIndex];
            int id = 0, num;
            int.TryParse(row.Cells["cod_Medico2"].Value.ToString(), out id);
            String correo = row.Cells["correo"].Value.ToString();
            int.TryParse(row.Cells["num_Correo"].Value.ToString(), out num);

            if (num == 0) return string.Format("insert into [dbo].[Correo_Medicos]  values ({0},{1},'{2}')", num, id, correo); //MISMOS CAMBIOS POR LA TILDE
            else return string.Format("update [dbo].[Correo_Médicos] set [correo]= '{0}' WHERE [cod_Medico]={1}", correo, id);
        }
        private String addORupdateDispo(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgDispo.Rows[e.RowIndex];
            int id = 0, num = 0;
            int.TryParse(row.Cells["cod_Medico3"].Value.ToString(), out id);
            String dispo = row.Cells["disponibilidad"].Value.ToString();
            int.TryParse(row.Cells["num_Dia"].Value.ToString(), out num);

            if (id == 0) return string.Format("insert into [dbo].[Disponibilidad_Medicos]  values ({0},{1},'{2}')", num, id, dispo);
            else return string.Format("update [dbo].[Disponibilidad_Medicos] set [disponibilidad]= '{0}' WHERE [cod_Medico]={1}", dispo, id); 
        }
        private String addORupdateEspe(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgEsp.Rows[e.RowIndex];
            int id = 0, num = 0;
            int.TryParse(row.Cells["cod_Medico4"].Value.ToString(), out id);
            String esp = row.Cells["especialidad"].Value.ToString();
            int.TryParse(row.Cells["cod_Especialidad"].Value.ToString(), out num);

            if (id == 0) return string.Format("insert into [dbo].[Especialidad_Medicos]  values ({0},{1},'{2}')", num, id, esp);
            else return string.Format("update [dbo].[Especialidad_Medicos] set [especialidad]= '{0}' WHERE [cod_Medico]={1}", esp, id); 
        }

        private void dgMed_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            con = new SqlConnection();
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

        private void dgDispo_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgDispo.IsCurrentRowDirty)
                    return;

                string query = addORupdateDispo((DataGridViewCellCancelEventArgs)e);

                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dgEsp_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgEsp.IsCurrentRowDirty)
                    return;

                string query = addORupdateEspe((DataGridViewCellCancelEventArgs)e);

                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dgMed_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["cod_Medico"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Medicos] WHERE [cod_Medico] = {0}", id);
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
                int.TryParse(e.Row.Cells["cod_Medico2"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Correo_Médicos] WHERE [cod_Médico] = {0}", id);
                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dgDispo_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["cod_Medico3"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Disponibilidad_Medicos] WHERE [cod_Medico] = {0}", id);
                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }

        private void dgEsp_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["cod_Medico4"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Especialidad_Medicos] WHERE [cod_Medico] = {0}", id);
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
