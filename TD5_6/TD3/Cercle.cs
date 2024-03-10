using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TD3
{
    public class Cercle : Figure
    {
        private double rayon;

        public Cercle(double rayon,Point origine)
        {
            this.rayon = rayon;
            this.origine = origine;
        }
        public override double CalculerAire()
        {
            aire = Math.PI * rayon * rayon;
            return aire;
        }
        public override double CalculerPerimetre()
        {
            perimetre = 2 * Math.PI * rayon;
            return perimetre;
        }
    }
}
