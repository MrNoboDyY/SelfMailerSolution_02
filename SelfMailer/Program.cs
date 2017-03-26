using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfMailer
{
    static class Program
    {

        public static Library.Project Project;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Project = new Library.Project();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Main());//fromulaire de demarage sera le formulaire "Main"

            //Library.Project P = new Library.Project();



            //comment
            /* utilisation de la methode HasChanged de la class "MailServerSettings" */
            Project.MailServerSettings.HasChanged = true;

            //comment
            /* utilisation de la methode HasChanged de la class "ProjectSettings" */
            Project.ProjectSettings.HasChanged = true;
        }
    }
}
