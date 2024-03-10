using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3
{
    internal class Personne
    {
        protected string nom;
        protected string prenom;
        protected string email;
        protected string adresse;

        public Personne(string nom, string prenom, string email, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.adresse = adresse;
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public override string ToString()
        {
            return ("Nom : " + nom + "\nPrénom : " + prenom + "\nEmail : " + email + "\nAdresse : " + adresse);
        }
    }
}
