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
                if(this.hasChanged != value)
                {
                    //comment
                    /* rangement de la nouvelle valeur "value"
                     dans "hasChanged" */
                    this.hasChanged = value;

                    //comment 
                    if (this.Changed != null)
                        this.Changed(this, new EventArgs());
                     /*avec la methode "Invoke" + "?" */
                    //this.Changed?.Invoke(this, new EventArgs());                    
                }
            }
        }
        //comment
        /* evenement "Changed" declanché dès qu'un changement est verifié.*/
        public event EventHandler Changed;
    }
}
