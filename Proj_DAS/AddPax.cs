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
    public partial class AddPax : Form
    {
        static string conString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true";
        SqlConnection con = new SqlConnection(conString);

        public AddPax()
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


        private void AddPax_Load(object sender, EventArgs e)
        {
            
            this.correo_PacientesTableAdapter.Fill(this.citasMedicasDataSet2.Correo_Pacientes);
            this.domicilio_PacientesTableAdapter.Fill(this.citasMedicasDataSet1.Domicilio_Pacientes);
            this.pacientesTableAdapter.Fill(this.citasMedicasDataSet.Pacientes);
        }

        private void dgPax_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgPax.IsCurrentRowDirty)
                    return;

                string query = addORupdateP((DataGridViewCellCancelEventArgs)e);

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

                string query = addORupdateC((DataGridViewCellCancelEventArgs)e);

                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
        private void dgDomicilio_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                if (!dgDomicilio.IsCurrentRowDirty)
                    return;

                string query = addORupdateD((DataGridViewCellCancelEventArgs)e);

                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
        private String addORupdateP(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgPax.Rows[e.RowIndex];
            int id = 0, edad, tel;
            int.TryParse(row.Cells["id_Paciente"].Value.ToString(), out id);
            String nombre = row.Cells["nombre"].Value.ToString();
            String ap1 = row.Cells["apellido1"].Value.ToString();
            String ap2 = row.Cells["apellido2"].Value.ToString();
            int.TryParse(row.Cells["edad"].Value.ToString(), out edad);
            int.TryParse(row.Cells["tel"].Value.ToString(), out tel);

            if (id == 0) return string.Format("insert into [dbo].[Pacientes]  values ({0},'{1}','{2}','{3}',{4},{5})", id, nombre, ap1, ap2, edad, tel);
            else return string.Format("update [dbo].[Pacientes] set [nombre]= '{0}', [apellido1]= '{1}', [apellido2]= '{2}', [edad]= {3}, [tel]= {4} WHERE [id_Paciente]={5}", nombre, ap1, ap2, edad, tel, id);
        }

        private String addORupdateC(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgCorreo.Rows[e.RowIndex];
            int id = 0, num;
            int.TryParse(row.Cells["id_Paciente2"].Value.ToString(), out id);
            String correo = row.Cells["correo"].Value.ToString();
            int.TryParse(row.Cells["num_Correo"].Value.ToString(), out num);

            if (num == 0) return string.Format("insert into [dbo].[Correo_Pacientes]  values ({0},{1},'{2}')", num, id,correo);
            else return string.Format("update [dbo].[Correo_Pacientes] set [correo]= '{0}' WHERE [id_Paciente]={1}", correo,id);
        }

        private String addORupdateD(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgDomicilio.Rows[e.RowIndex];
            int id = 0, dom,prov;
            int.TryParse(row.Cells["id_Paciente3"].Value.ToString(), out id);
            int.TryParse(row.Cells["num_Provincia"].Value.ToString(), out prov);
            int.TryParse(row.Cells["num_Domicilio"].Value.ToString(), out dom);
            String canton = row.Cells["canton"].Value.ToString();
            String distrito = row.Cells["Distrito"].Value.ToString();
            String senhas = row.Cells["otrasSenhas"].Value.ToString();

            //return string.Format("insert into [dbo].[Domicilio_Pacientes]  values ({0},{1},{2},'{3}','{4}','{5}')", prov, dom, id, canton, distrito, senhas);
            if (dom == 0) return string.Format("insert into [dbo].[Correo_Pacientes]  values ({0},{1},{2},'{3}','{4}','{5}')", prov, dom, id, canton, distrito, senhas);
            else return string.Format("update [dbo].[Domicilio_Pacientes] set [num_Provincia] = {0}, [num_Domicilio] = {1}, [canton] = '{2}', [Distrito] ='{3}',[otrasSenhas] = '{4}' WHERE [id_Paciente]={5}", prov, dom, canton, distrito, senhas,id);
        }


        private void dgPax_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["id_Paciente"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Pacientes] WHERE [id_Paciente] = {0}", id);
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
                int.TryParse(e.Row.Cells["id_Paciente2"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Correo_Pacientes] WHERE [id_Paciente] = {0}", id);
                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
        private void dgDomicilio_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["id_Paciente3"].Value.ToString(), out id);
                string query = string.Format("DELETE FROM [dbo].[Domicilio_Pacientes] WHERE [id_Paciente] = {0}", id);
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
