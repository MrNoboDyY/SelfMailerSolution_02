using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfMailer
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Library.Project P = new Library.Project();

            //comment
            /* utilisation de la methode HasChanged de la class "MailServerSettings" */
            P.MailServerSettings.HasChanged = true;

            //comment
            /* utilisation de la methode HasChanged de la class "ProjectSettings" */
            P.ProjectSettings.HasChanged = true;
        }
    }
}
