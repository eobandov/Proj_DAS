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
    public partial class detalleCitas : Form
    {
        
        public detalleCitas()
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
        public void cargar(int user)
        {
            SqlConnection con = new SqlConnection();
            con = conexion();
            con.Open();
            try
            {
                string query = string.Format("select * from [CitasMedicas].[dbo].[Historial_Pacientes] WHERE id_Paciente=" + user);
                SqlCommand comando = new SqlCommand(query, con);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string a = reader.GetDecimal(0).ToString();
                    string b = reader.GetDecimal(1).ToString();
                    string c = reader.GetString(2);
                    string d = reader.GetDateTime(3).ToShortDateString();
                    string[] row1 = new string[] { a,b,c,d };
                    dgPax.Rows.Add(row1);
                }
                else MessageBox.Show("Los datos no se pudieron obtener", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            int.TryParse(row.Cells["num_historial1"].Value.ToString(), out int num_historial);
            int.TryParse(row.Cells["id_Paciente1"].Value.ToString(), out int id);
            String historial = row.Cells["historial1"].Value.ToString();
            String fecha = row.Cells["fechaRegistro1"].Value.ToString();
            DateTime ff =Convert.ToDateTime( fecha);
            if (num_historial < 0) return string.Format("insert into [dbo].[Historial_Pacientes] ([id_Paciente],[historial],[fechaRegistro])  values ({0},'{1}','{2}')", id, historial, ff);
            else return string.Format("update [dbo].[Historial_Pacientes] set [id_Paciente]= {0}, [historial]= '{1}', [fechaRegistro]= '{2}' WHERE num_historial={3}", id,historial,ff,num_historial);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtPax.Text != "")
            {
                int.TryParse(txtPax.Text,out int cc);
                cargar(cc);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            newCargar();
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

        private void detalleCitas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pacienteDSprueba.Pacientes' Puede moverla o quitarla según sea necesario.
            newCargar();
        }
        private void newCargar()
        {
            this.pacientesTableAdapter.Fill(this.pacienteDSprueba.Pacientes);
            this.historial_PacientesTableAdapter.Fill(this.historialDS.Historial_Pacientes);
        }
    }
}
