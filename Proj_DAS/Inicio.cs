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
    public partial class Form1 : Form
    {
        //Formulario BASE NO USAR
        public Form1()
        {
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            gbUsuario.Enabled = true;
            gbUsuario.Visible = true;
            gbPaciente.Visible = false;
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

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            gbPaciente.Visible = true;
            gbUsuario.Visible = false;
        }

        private void btnCita_Click(object sender, EventArgs e)
        {

        }

        private void btnPago_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnPax_CheckedChanged(object sender, EventArgs e)
        {
            btnEA.Checked = false;
            btnEM.Checked = false;
        }

        private void btnEA_CheckedChanged(object sender, EventArgs e)
        {
            btnPax.Checked = false;
            btnEM.Checked = false;
        }

        private void btnEM_CheckedChanged(object sender, EventArgs e)
        {
            btnEA.Checked = false;
            btnPax.Checked = false;
        }
    }
}
