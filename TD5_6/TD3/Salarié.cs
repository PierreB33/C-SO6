using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD5_6;

namespace TD3
{
    internal class Salarié : Personne, IComparable<Salarié>, IIdentifiable<int>
    {
        protected double salaire;
        protected int num_salarié;

        public Salarié(string nom, string prenom, string email, string adresse, double salaire, int num_salarié) : base(nom, prenom, email, adresse)
        {
            this.salaire = salaire;
            this.num_salarié = 0;
        }

        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public int Num_Salarié
        {
            get { return num_salarié; }
            set { num_salarié = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\nSalaire : " + salaire + "\nNuméro de salarié : " + num_salarié;
        }
        public int CompareTo(Salarié other)
        {
            return this.Nom.CompareTo(other.Nom);
        }
        public string Identification(int cle)
        {
            return "Salarié-" + cle.ToString();
        }
    }
}
