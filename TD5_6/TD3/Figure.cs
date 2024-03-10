using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD3
{
    public abstract class Figure
    {
        protected double aire;
        protected double perimetre;
        protected Point origine;

        public abstract double CalculerAire();
        public abstract double CalculerPerimetre();
    }
    

}
