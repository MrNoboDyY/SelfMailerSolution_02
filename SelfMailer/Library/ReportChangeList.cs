using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMailer.Library
{

    //comment
    /* création d'une class généric le type<T>"
     * sera spécifié à l'instanciation */
    public class ReportChangeList<T> : IReportChildrenChange,
    IEnumerable<T> where T : IReportChange, IKey//qui implemente IReportChange avec HasChanged
    {
        //coment
        /* d'une List "children" */
        protected List<T> children;

        protected bool hasChanged;


        #region HasChanged
        public bool HasChanged
        {
            get
            {
                bool result = false;


                /* boucle sur les elts de la List "children" pour 
                 savoir lequel à changer */
                foreach (IReportChange child in children)//child = var local !!!
                    if (child.HasChanged)
                    {
                        result = true;
                        break;
                    }
                return result || hasChanged;
            }
            set
            {

                if (HasChanged != value)
                {
                    hasChanged = value;
                    if (Changed != null) //this.Changed?.Invoke(this, EventArgs())
                    {
                        Changed(this, new ChangedEventArgs(HasChanged));
                    }
                    if (!value)
                    {
                        foreach (IReportChange child in children)
                            child.HasChanged = value;
                    }
                }
            }

        }
        #endregion

        /* evenement "Changed" declanché dès qu'un changement est verifié.*/
        public event EventHandler<ChangedEventArgs> Changed;


        //comment
        /* constructeur pour instancier la variable children en 
         * une nouvelle liste children */
        public ReportChangeList()
        {
            children = new List<T>();
        }

        public void ChildChanged(object sender, ChangedEventArgs e)
        {
            if (Changed != null) //this.Changed?.Invoke(this , EventArgs())
                Changed(sender, e);

            //throw new NotImplementedException();
        }

        #region Enumerator 
        /* Enumeration sur les elts dde children */
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < children.Count; i++)
            {
                yield return children[i];//resultat en fonction de la derniere val retourné à chaque boucle
            }
            //throw new NotImplementedException();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            /* utilisation de la methode GetEnumerator */
            return GetEnumerator();
            //throw new NotImplementedException();
        }
        #endregion

        #region Add

        /* Method Add  / Ajouter un elt à la list children */
        public void Add(T Child)
        {
            IKey childKey = Child;//instanciation d'une variable Key
            if (Child.Key == null)//verif si Key/ La Clef  est null,avant l'ajout
            {
                IReportChange child = Child;
                child.Changed += new EventHandler<ChangedEventArgs>(ChildChanged);
                children.Add(Child);
            }
        }
        #endregion

        #region IndexeurDeClef
        /* indexeur de type string */
        public T this[string Key]
        {
            get
            {
                /* on parcour la List pour verifier les Keys deja existante */
                foreach (T aChild in children)
                {
                    if ((aChild).Key.Equals(Key))
                    {
                        return aChild;//si la Key existe deja,elle est retournée
                    }
                }
                return default(T);//sinon le valeur par defaut est retournée
            }

            set
            {
                for (int i = 0; i < children.Count; i++)
                {
                    IKey aChild = children[i];
                    if (aChild.Key.Equals(Key))
                    {
                        /* operation de mise à jour si la Key exist */
                        children[i] = value;//affectation de la nouvelle valeur
                        HasChanged = true;//enregistrement du changement
                        break;
                    }
                }
            }
        }
        #endregion

        #region Remove

        public void Remove (string Key)
        {
            if (this[Key] != null)
            {
                children.Remove(this[Key]);
                HasChanged = true;

            }
        }
        #endregion
    }
}
