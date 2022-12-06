using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proj_DAS
{
    class Conexion
    {
        public static SqlConnection conexion()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog='CitasMedicas'; integrated security = true";
            return con;
        }

        public SqlConnection abrir()
        {

            SqlConnection cn = new SqlConnection();
            cn = conexion();

            return cn;
        }
    }
}
