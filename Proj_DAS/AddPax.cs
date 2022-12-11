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
            cargar();          
        }
        private void cargar()
        {
            this.domicilio_PacientesTableAdapter.Fill(this.domicilioDS.Domicilio_Pacientes);
            this.pacientesTableAdapter.Fill(this.pacientesDS.Pacientes);
        }
        private void dgPax_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            SqlConnection con = new SqlConnection();
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

        private void dgDomicilio_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            SqlConnection con = new SqlConnection();
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
            int.TryParse(row.Cells["id_Paciente1"].Value.ToString(), out id);
            String nombre = row.Cells["nombre1"].Value.ToString();
            String ap1 = row.Cells["apellido11"].Value.ToString();
            String ap2 = row.Cells["apellido21"].Value.ToString();
            int.TryParse(row.Cells["edad1"].Value.ToString(), out edad);
            int.TryParse(row.Cells["tel1"].Value.ToString(), out tel);
            String correo = row.Cells["correo1"].Value.ToString();

            if (id == 0) return string.Format("insert into [dbo].[Pacientes]  values ({0},'{1}','{2}','{3}',{4},{5},'{6}')", id, nombre, ap1, ap2, edad, tel,correo);
            else return string.Format("update [dbo].[Pacientes] set [nombre]= '{0}', [apellido1]= '{1}', [apellido2]= '{2}', [edad]= {3}, [tel]= {4}, [correo]='{5}' WHERE [id_Paciente]={6}", nombre, ap1, ap2, edad, tel,correo, id);
        }
        


        private String addORupdateD(DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgDomicilio.Rows[e.RowIndex];
            int id = 0, dom,prov;
            int.TryParse(row.Cells["id_Paciente22"].Value.ToString(), out id);
            int.TryParse(row.Cells["num_Provincia1"].Value.ToString(), out prov);
            int.TryParse(row.Cells["num_Domicilio1"].Value.ToString(), out dom);
            String canton = row.Cells["canton1"].Value.ToString();
            String distrito = row.Cells["Distrito1"].Value.ToString();
            String senhas = row.Cells["otrasSenhas1"].Value.ToString();

            if (dom == 0) return string.Format("insert into [dbo].[Domicilio_Pacientes]  values ({0},{1},{2},'{3}','{4}','{5}')", prov, dom, id, canton, distrito, senhas);
            else return string.Format("update [dbo].[Domicilio_Pacientes] set [num_Provincia] = {0}, [num_Domicilio] = {1}, [canton] = '{2}', [Distrito] ='{3}',[otrasSenhas] = '{4}' WHERE [id_Paciente]={5}", prov, dom, canton, distrito, senhas,id);
        }


        private void dgPax_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["id_Paciente1"].Value.ToString(), out id);
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

        
        private void dgDomicilio_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                int id = 0;
                int.TryParse(e.Row.Cells["id_Paciente22"].Value.ToString(), out id);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargar();
        }

    }
}
