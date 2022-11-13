using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_DAS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Proj_DAS.Login2 loginForm = new Proj_DAS.Login2();
            //loginForm.ShowDialog();
            //Usuario user = loginForm.user;
            //if (user != null)
            //{
            //    MessageBox.Show("Autenticacion exitosa de " + user.usuario, "Proj_DAS", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    MessageBox.Show("Autenticacion cancelada", "Proj_DAS", MessageBoxButtons.OK);
            //}
            Application.Run(new Login2());
        }
    }
}
