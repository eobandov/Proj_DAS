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
            // TODO: esta línea de código carga datos en la tabla 'dSEspe.Especialidad_Medicos' Puede moverla o quitarla según sea necesario.
            this.especialidad_MedicosTableAdapter.Fill(this.dSEspe.Especialidad_Medicos);

            cargar();
        }
        private void cargar()
        {
            this.medicosTableAdapter.Fill(this.dSMedicos.Medicos);
            this.especialidad_MedicosTableAdapter.Fill(this.dSEspe.Especialidad_Medicos);
            this.disponibilidad_MedicosTableAdapter.Fill(this.disponibilidadDS.Disponibilidad_Medicos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }
        private String addORupdateMedico(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgMed.Rows[e.RowIndex];
            int id = 0, tel=0;
            int.TryParse(row.Cells["cod_Medico1"].Value.ToString(), out id);
            String nombre = row.Cells["nombre1"].Value.ToString();
            String ap1 = row.Cells["apellido11"].Value.ToString();
            String ap2 = row.Cells["apellido21"].Value.ToString();
            int.TryParse(row.Cells["tel1"].Value.ToString(), out tel);
            String correo = row.Cells["correo1"].Value.ToString();

            if (id <0) return string.Format("insert into [dbo].[Medicos]  values ('{0}','{1}','{2}',{3},'{4}')", nombre, ap1, ap2, tel,correo);
            else return string.Format("update [dbo].[Medicos] set [nombre]= '{0}', [apellido1]= '{1}', [apellido2]= '{2}', [tel]= {3}, [correo]={4} WHERE [cod_Medico]={5}", nombre, ap1, ap2, tel, correo, id); 
        }

        private String addORupdateDispo(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgDispo.Rows[e.RowIndex];
            int id = 0, num = 0;
            int.TryParse(row.Cells["cod_Medico111"].Value.ToString(), out id);
            int.TryParse(row.Cells["num_Dia111"].Value.ToString(), out num);

            if (id < 0) return string.Format("insert into [dbo].[Disponibilidad_Medicos] ([num_Dia],[cod_Medico])  values ({0},{1})", num, id);
            else return string.Format("update [dbo].[Disponibilidad_Medicos] set [num_Dia] = {0} WHERE [cod_Medico]={1}", num, id);
        }
        private String addORupdateEsp(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgEsp.Rows[e.RowIndex];
            int id = 0, num = 0;
            int.TryParse(row.Cells["cod_Medico222"].Value.ToString(), out id);
            int.TryParse(row.Cells["cod_Especialidad222"].Value.ToString(), out num);
            String esp = row.Cells["especialidad222"].Value.ToString();

            if (num < 0) return string.Format("insert into [dbo].[Especialidad_Medicos] ([cod_Medico],[especialidad]) values ({0},'{1}')", id,esp);
            else return string.Format("update [dbo].[Especialidad_Medicos] set [cod_Medico]= {0},[especialidad] ='{1}' WHERE [cod_Especialidad]={2}", id,esp,num);
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
        private void dgEsp_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgEsp.IsCurrentRowDirty)
                    return;

                string query = addORupdateEsp((DataGridViewCellCancelEventArgs)e);

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
            SqlConnection con = new SqlConnection();
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



        private void dgMed_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            SqlConnection con  = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["cod_Medico1"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Credenciales_Medicos] WHERE [cod_Medico] = {0}", id);
                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                query = string.Format("DELETE FROM [dbo].[Medicos] WHERE [cod_Medico] = {0}", id);
                cmd = new SqlCommand(query, con);
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
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["num_Dia111"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Disponibilidad_Medicos] WHERE [num_Dia] = {0}", id);
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
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["cod_Especialidad222"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Especialidad_Medicos] WHERE [cod_Especialidad] = {0}", id);
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
