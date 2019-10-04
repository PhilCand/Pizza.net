using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza2
{
    static class Program
    {
        public static string userName = "";
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DAL.ImportPizza();            
            DialogResult result = DialogResult.No;            
            using (var loginForm = new LoginForm())

            while (LoginForm.essai > 0 && result == DialogResult.No)
            {
                result = loginForm.ShowDialog();


                if (result == DialogResult.OK)
                {
                    // login was successful
                    loginForm.Close();
                    Application.Run(new MainForm());

                }
            }

        }
    }
}
