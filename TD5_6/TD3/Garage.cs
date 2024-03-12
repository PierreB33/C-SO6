using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD5_6
{
    internal class Garage : IMoyenne<List<Voiture>>
    {
        private string num_siret;
        private List<Voiture> flotte;

        public Garage(string num_siret, List<Voiture> flotte)
        {
            this.num_siret = num_siret;
            this.flotte = flotte;
        }
        public double Moyenne(List<Voiture> voitures)
        { 
            double somme = 0;
            double moyenne = 0;
            if (voitures.Count()==0)
            {
                return 0;
            }
            else
            {
                foreach(var voiture in voitures)
                {
                    somme += voiture.Prix_achat;
                }
                moyenne = somme / voitures.Count();
                return moyenne;
            }


        }
    }
}
