using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD3;

namespace TD5_6
{
    internal class Voiture
    {
        private string plaque_immatriculation;
        private string marque;
        private string modele;
        private int prix_achat;

        public Voiture(string plaque_immatriculation,string marque,string modele,int prix_achat)
        {
            this.plaque_immatriculation = plaque_immatriculation;
            this.marque = marque;
            this.modele = modele;
            this.prix_achat = prix_achat;
        }
        public int Prix_achat
        {
            get { return prix_achat; }
            set { prix_achat = value; }
        }
            
    }
}
