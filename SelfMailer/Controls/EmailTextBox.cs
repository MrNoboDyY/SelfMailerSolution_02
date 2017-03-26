using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfMailer.Controls
{
    class EmailTextBox : System.Windows.Forms.TextBox
    {
        protected Color PreviousBackColor { get; set; }

        public EmailTextBox()
        {
            PreviousBackColor = BackColor;
        }
      protected override void  OnValidating (System.ComponentModel.CancelEventArgs e)
        {
            base.OnValidating(e);
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\." +
                                 @"[0-9]{1,3}\.[0-9]{1,3}\.)|" +
                                 @"(([a-zA-Z0-9\-]+\.)+))" +
                                 @"([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$";

            //pattern de validation pour l'Email 
            Regex reg = new Regex(pattern);
            if (!reg.IsMatch(Text))//s'il n'est pas correct
            {
                //retourne la valeur saisie en precisant l'incoherence
                //ErrorProvider.SetError(FromEmail, "le format :  " + FromEmail.Text + "  n'est pas correct ");
                BackColor = Color.Bisque;
                e.Cancel = true;
            }
            else BackColor = PreviousBackColor;
        }

    }
}
