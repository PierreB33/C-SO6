using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD5_6
{
    internal class MaDate : IConvertible
    {
        private int jour;
        private int mois;
        private int annee;

        public MaDate(int jour,int mois,int annee)
        {
            this.jour = jour;
            this.mois = mois;
            this.annee = annee;
        }
        public int Convert()
        {
            int nombredejours = annee * 365 + mois * 30 + jour;
            return nombredejours;
        }
    }
}
