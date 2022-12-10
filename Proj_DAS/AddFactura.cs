using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_DAS
{
    public partial class AddFactura : Form
    {
        public AddFactura()
        {
            InitializeComponent();
        }

        private void AddFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'citasMedicasDataSet16.Detalle_Factura' Puede moverla o quitarla según sea necesario.
            this.detalle_FacturaTableAdapter.Fill(this.citasMedicasDataSet16.Detalle_Factura);
            // TODO: esta línea de código carga datos en la tabla 'citasMedicasDataSet15.Facturacion' Puede moverla o quitarla según sea necesario.
            this.facturacionTableAdapter.Fill(this.citasMedicasDataSet15.Facturacion);

        }
    }
}
