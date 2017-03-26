using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.RegularExpressions;

namespace SelfMailer.Forms
{
    public partial class MailServerSettings : Form
    {
        

        public MailServerSettings()
        {
            /*Restauration des données a l'ouverture*/
            InitializeComponent();
            FromName.Text = Program.Project.MailServerSettings.FromName;
            Text = Program.Project.MailServerSettings.FromEmail;
            Host.Text = Program.Project.MailServerSettings.Host;
            Username.Text = Program.Project.MailServerSettings.Username;
            Password.Text = Program.Project.MailServerSettings.Password;

        }

        private void Valid_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(" Voulez-vous vraiment sauvegarder les données ????");
            if (string.IsNullOrWhiteSpace(Host.Text))//alert sur le champ Hôte si il est vide !!!
            {
                errorProvider.SetError(Host,"Le champ Hôte doit être complété.");
            }else if (ValidateChildren())
            {
                //even de sauvegarde sur le bouton Valider
                Program.Project.MailServerSettings.FromName = FromName.Text;
                Program.Project.MailServerSettings.FromEmail = Text;
                Program.Project.MailServerSettings.Host = Host.Text;
                Program.Project.MailServerSettings.Username = Username.Text;
                Program.Project.MailServerSettings.Password = Password.Text;
                DialogResult = DialogResult.OK;
            }

        }

        //private void FromEmail_Validating(object sender, CancelEventArgs e)
        //{
        //    string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\." +
        //                        @"[0-9]{1,3}\.[0-9]{1,3}\.)|" +
        //                        @"(([a-zA-Z0-9\-]+\.)+))" +
        //                        @"([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$";

        //    //pattern de validation pour l'Email 
        //    Regex reg = new Regex(pattern);
        //    if (!reg.IsMatch(this.FromEmail.Text))//s'il n'est pas correct
        //    {
        //        //retourne la valeur saisie en precisant l'incoherence
        //        errorProvider.SetError(FromEmail, "le format :  " + FromEmail.Text + "  n'est pas correct ");
        //        e.Cancel = true;
        //    }

        //}
    }
}
