using SelfMailer.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfMailer.Library
{

    public class Project : IReportChildrenChange//IReportChange
    {

        //comment
        /* constructeur vide*/
        public Project()
        {
            #region ChildChanged
            //comment
            /* initalisation + association a la methode "ChildChanged" */
            ProjectSettings = new ProjectSettings();
            ProjectSettings.Changed += new EventHandler<ChangedEventArgs>(ChildChanged);

            MailServerSettings = new MailServerSettings();
            MailServerSettings.Changed += new EventHandler<ChangedEventArgs>(ChildChanged);
        }

         # endregion

        public ProjectSettings ProjectSettings { get; set; }

        public MailServerSettings MailServerSettings { get; set; }

        public event EventHandler<ChangedEventArgs> Changed;


        private string path;
        private DataTable data = new DataTable();
        private bool hasChanged;
        private string filename;

        #region Constructeur
        public string Filename
        {
            get
            {
                return filename;
            }

            protected set
            {
                if (this.filename != value)
                {
                    this.filename = value;
                    this.HasChanged = true;
                }
            }
        }

        public string Path
        {
            get
            {
                return path;
            }

            protected set
            {
                if (this.path != value)
                {
                    this.path = value;
                    this.HasChanged = true;
                }
            }
        }

        public bool HasChanged
        {
            get
            {
                return hasChanged;
            }

            set
            {
                hasChanged = value;
            }
        }

        public DataTable Data
        {
            get
            {
                return data;
            }

            protected set
            {
                if (this.data != value)
                {
                    this.data = value;
                    this.HasChanged = true;
                }
            }
        }
        #endregion

        #region Sauvegarde ou pas des fichiers
        public void Save(bool Ask, bool ShowDialog)
        {
            //comment 
            /* si l'utilisateur doit confirmer la sauvegarde du projet 
             et que ce derneir a été modifié ,il doit cliquer sur le 
             Bouton "Yes" de la boite de dialogue*/
            if (!Ask || (this.HasChanged && MessageBox.Show("voulez-vous sauvegarder les modifs ??",
                "Sauver",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes))
            {
                //comment
                /* si l'utilisateur n'a pas la possibilité de choisir un fichier et que 
                 le nom du fichier ainsi que son chemin sont définis ,
                 le projet est enregistré et la propriété "HasChanged" est reinitialisée*/
                if (!ShowDialog
                    && !string.IsNullOrEmpty(Filename)
                    && !string.IsNullOrEmpty(Path))
                {
                    //comment
                    /* sauvegarde des données non implementée*/
                    this.HasChanged = false;
                }
                else
                {
                    //comment
                    /* instanciation et initialisation de la boite de dialogue 
                     de sauvegarde des fichiers*/
                    SaveFileDialog sfdProject = new SaveFileDialog();
                    sfdProject.Filter = "Self Mailer (*.smpx)| *.smpx";
                    sfdProject.RestoreDirectory = true;
                    sfdProject.SupportMultiDottedExtensions = true;
                    sfdProject.Title = "Sauver le Projet";

                    //comment
                    /* affichage de la boite de dialogue et test 
                     de la valeur de retour*/
                    if (sfdProject.ShowDialog() == DialogResult.OK)
                    {

                        //comment
                        /* assignation des valeurs aux variables et sauvegarde du projet*/
                        this.Filename = System.IO.Path.GetFileName(sfdProject.FileName);
                        this.Path = System.IO.Path.GetDirectoryName(sfdProject.FileName);

                        //comment
                        /* sauvegarde des données non implémentée*/
                        HasChanged = false;
                    }
                }

            }
        }

# endregion

       

        //comment
		/*  implementation dela methode */
        public void ChildChanged(object sender , ChangedEventArgs e) {
            if (sender is IReportChange) {
                IReportChange Child = (IReportChange)sender;
                HasChanged = Child.HasChanged;
                //MessageBox.Show("Changement de l'objet de type " + Child.GetType().ToString());
            }
        }
    }
}
