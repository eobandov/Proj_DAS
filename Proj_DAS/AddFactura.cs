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
    public partial class AddFactura : Form
    {
        public AddFactura()
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
        private void init()
        {
            txtCant.Clear();
            txtDescrip.Clear();
            lblSubtotal.Text = "-";
            lblTotal.Text = "-";
            txtFactura.Enabled = false;
        }
        private void dbprocedimiento()
        {
            if ( txtFecha.Text != "" || txtCant.Text != "" || txtDescrip.Text != "")
            {
                //Abrir conexion
                SqlConnection cn = new SqlConnection();
                cn = conexion();
                cn.Open();
                try
                {
                    //Enviar query
                    string cadena = AdaddORupdateFactura("Factura");
                    SqlCommand comando = new SqlCommand(cadena, cn);
                    comando.ExecuteNonQuery();
                    cadena = AdaddORupdateFactura("Detalle");
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Factura creada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private int codTarifa(int tarifa)
        {
            int cod_tarifa;
            switch (tarifa)
            {
                case 45000: cod_tarifa = 1; break;
                case 55000: cod_tarifa = 2; break;
                case 60000: cod_tarifa = 3; break;
                case 50000: cod_tarifa = 4; break;
                default: cod_tarifa = 1; break;
            }
            return cod_tarifa;
        }
        private String AdaddORupdateFactura(String mod)
        {
            int factura,metodo, pax, emp, cita,tarifa,cod_tarifa,total,total_iva, iva,esp,cant,monto,subtotal;
            int.TryParse(txtFactura.Text, out factura);
            int.TryParse(txtPax.Text, out pax);
            int.TryParse(txtCita.Text, out cita);
            String fecha = txtFecha.Text;
            if (txtMetodo.Text == "Efectivo") metodo = 1;
            else metodo = 2;
            int.TryParse(txtTarifa.Text, out tarifa);
            int.TryParse(txtEmp.Text, out emp);
            int.TryParse(txtEsp.Text, out esp);
            int.TryParse(txtCant.Text, out cant);
            String descripcion = txtDescrip.Text;

            //Obtener codigo de tarifa
            cod_tarifa = codTarifa(tarifa);

            //Calculos
            total = tarifa;
            iva = Convert.ToInt32(total * .04);
            total_iva = total + iva;
            monto = tarifa;
            subtotal = tarifa;

            if(mod == "Factura")
            {
                if (txtFactura.Text == "")
                    return String.Format("INSERT INTO [dbo].[Facturacion] ([fechaPago],[total],[iva],[total_Iva],[cod_Cita], " +
                        "[id_Paciente],[id_Empleado],[num_MetodoPago]) VALUES ('{0}',{1},{2},{3},{4},{5},{6},{7})", fecha, 
                        total,iva,total_iva, cita,pax,emp,metodo);
                else return String.Format("UPDATE [dbo].[Facturacion] SET [fechaPago] ='{0}' ,[total] = {1},[iva] = {2}," +
                    "[total_Iva] = {3},[cod_Cita] = {4},[id_Paciente] = {5},[id_Empleado] = {6},[num_MetodoPago] ={7} " +
                    "WHERE [id_Factura]={8}", fecha,total,iva,total_iva,cita,pax,emp,metodo,factura);
            }
            else //mod = Detalles
            {
                if (txtFactura.Text == "")
                    return String.Format("INSERT INTO [dbo].[Detalle_Factura] ([cod_Especialidad],[descripcion],[cod_Tarifa]," +
                        "[cantidad],[monto],[subtotal]) VALUES ({0},'{1}',{2},{3},{4},{5},{6},{7})", esp,descripcion, cod_tarifa,
                        cant, cita,monto,subtotal);
                else return String.Format("UPDATE [dbo].[Detalle_Factura] SET [cod_Especialidad] = {0},[descripcion] = '{1}'," +
                    "[cod_Tarifa] = {2},[cantidad] = {3},[monto] = {4},[subtotal] = {5} WHERE [id_Factura]={6}", esp, descripcion,
                     cod_tarifa,cant, cita, monto, subtotal,factura);
            }
            
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int subtotal, total;
            int.TryParse(txtTarifa.Text, out int tarifa);
            subtotal = tarifa;
            total = Convert.ToInt32(subtotal * .04)+subtotal;
            lblSubtotal.Text = subtotal.ToString();
            lblTotal.Text = total.ToString();
            
            btnCrear.Enabled = true;
        }

        private void AddFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'preciosDS.Tarifas' Puede moverla o quitarla según sea necesario.
            this.tarifasTableAdapter1.Fill(this.preciosDS.Tarifas);
            // TODO: esta línea de código carga datos en la tabla 'pruebaEspecialidadDS.Especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.pruebaEspecialidadDS.Especialidades);
            // TODO: esta línea de código carga datos en la tabla 'pruebaEmpDS.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.pruebaEmpDS.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'pruebaTarifaDS.Tarifas' Puede moverla o quitarla según sea necesario.
            this.tarifasTableAdapter.Fill(this.pruebaTarifaDS.Tarifas);
            // TODO: esta línea de código carga datos en la tabla 'pruebaMetodoDS.Metodo_Pago' Puede moverla o quitarla según sea necesario.
            this.metodo_PagoTableAdapter.Fill(this.pruebaMetodoDS.Metodo_Pago);
            // TODO: esta línea de código carga datos en la tabla 'pruebaPacienteDS.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.pruebaPacienteDS.Pacientes);
            // TODO: esta línea de código carga datos en la tabla 'pruebaFacturaDS.Facturacion' Puede moverla o quitarla según sea necesario.
            this.facturacionTableAdapter.Fill(this.pruebaFacturaDS.Facturacion);
            // TODO: esta línea de código carga datos en la tabla 'pruebaCitaDS.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.pruebaCitaDS.Citas);
            // TODO: esta línea de código carga datos en la tabla 'pacientePruebaDS.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.pruebaPacienteDS.Pacientes);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            dbprocedimiento();
            init();
            btnCrear.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            init();
            btnCrear.Enabled = false;
        }
    }
}
