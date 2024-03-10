using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3
{
    class Rectangle : Figure
    {
        double longueur;
        double largeur;

        public Rectangle(double longueur, double largeur, Point origine)
        {
            this.longueur = longueur;
            this.largeur = largeur;
            this.origine = origine;
        }

        public override double CalculerAire()
        {
            aire = longueur * largeur;
            return aire;

        }
        public override double CalculerPerimetre()
        {
            perimetre = 2*longueur + 2*largeur;
            return perimetre;

        }

    }
}
