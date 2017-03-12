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

        private string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\." +
                                 @"[0-9]{1,3}\.[0-9]{1,3}\.)|"+
                                 @"(([a-zA-Z0-9\-]+\.)+))" +
                                 @"([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$";

        public MailServerSettings()
        {
            InitializeComponent();
        }

        private void Valid_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(" Voulez-vous vraiment sauvegarder les données ????");
            if (string.IsNullOrWhiteSpace(Host.Text))//alert sur le champ Hôte si il est vide !!!
            {
                MessageBox.Show("Le champ Hôte doit être complété.");
            }else if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }

        }

        private void FromEmail_Validating(object sender, CancelEventArgs e)
        {//pattern de validation pour l'Email 
            Regex reg = new Regex(pattern);
            if (!reg.IsMatch(this.FromEmail.Text))//s'il n'est pas correct
            {
                //retourne la valeur saisie en precisant l'incoherence
                MessageBox.Show("le format :  "+ FromEmail.Text +"  n'est pas correct ");
                e.Cancel = true;
            }

        }
    }
}
