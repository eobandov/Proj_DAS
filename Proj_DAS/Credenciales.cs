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
    public partial class Credenciales : Form
    {
        public Credenciales()
        {
            InitializeComponent();
        }
        public void abrir_login()
        {
            var fr1 = new Login2();
            fr1.Location = this.Location;
            fr1.StartPosition = FormStartPosition.Manual;
            fr1.FormClosing += delegate { this.Show(); };
            fr1.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            abrir_login();
           
        }
    }
}
