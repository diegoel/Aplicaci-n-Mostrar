using Aplicaci_n_Mostrar.User_Interfaces_UI_;
using System;
using System.Windows.Forms;

namespace Aplicaci_n_Mostrar
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
            Application.Run(new FormPrincipal());
        }
    }
}
