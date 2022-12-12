using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Proj_DAS
{
    public partial class Inicio : Form
    {
        //Formulario BASE NO USAR
        public int user;
        public Inicio(int User)
        {
            InitializeComponent();
            this.user = User;
        }

        private void AbrirForm(Object formSec)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form ap = formSec as Form;
            ap.TopLevel = false;
            ap.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(ap);
            this.panelContenedor.Tag = ap;
            ap.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirForm(new AddEmp());
        }

        // Funcion de Arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            AbrirForm(new AddPax());
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            AbrirForm(new AddCita());
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            AbrirForm(new AddFactura());
        }       

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            AbrirForm(new AddMed());
        }

        private void btnRCitas_Click(object sender, EventArgs e)
        {
            AbrirForm(new rreporteCitas());
        }

        private void btnRFacturas_Click(object sender, EventArgs e)
        {
            AbrirForm(new reporteFacturas());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirForm(new PersonalPax(user));

        }

        private void btnModCita_Click(object sender, EventArgs e)
        {
            AbrirForm(new detalleCitas());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Informacion());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirForm(new PersonalEmp(user));
        }

        private void pbMed_Click(object sender, EventArgs e)
        {

        }
    }
}
