using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMailer.Library
{
    public class MailServerSettings : IReportChange
    {
        protected bool hasChanged;

        public bool HasChanged
        {
            get { return hasChanged; }
            set
            {
                //comment
                /* verif si changement survenu*/
                if (this.hasChanged != value)
                {
                    //comment
                    /* rangement de la nouvelle valeur "value"
                     dans "hasChanged" */
                    this.hasChanged = value;

                    //comment 
                    if (this.Changed != null)
                        this.Changed(this, new ChangedEventArgs(this.HasChanged));
                    /*avec la methode "Invoke" + "?" */
                    //this.Changed?.Invoke(this, new EventArgs());                    
                }
            }
        }


        private string fromName;
        private string fromEmail;
        private string host;
        private string username;
        private string password;

        public string FromName
        {
            get
            {
                return fromName;
            }

            set
            {
                if (fromName != value) { HasChanged = true; }//mise à jour

            }
        }

        public string FromEmail
        {
            get
            {
                return fromEmail;
            }

            set
            {
                if (fromEmail != value) { HasChanged = true; }//mise à jour

            }
        }

        public string Host
        {
            get
            {
                return host;
            }

            set
            {
                if (host != value) { host = value; HasChanged = true; }//mise à jour

            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                if (username != value) { username = value; HasChanged = true; }//mise à jour

            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                if (password != value) { password = value; HasChanged = true; }//mise à jour

            }
        }

        //comment
        /* evenement "Changed" declanché dès qu'un changement est verifié.*/
        public event EventHandler<ChangedEventArgs> Changed;








    }
}
