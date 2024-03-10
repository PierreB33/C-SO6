using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD5_6;

namespace TD3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercice 1 
            Point origineRectangle = new Point(0, 0);
            Rectangle rectangle = new Rectangle(5, 3, origineRectangle);
            Console.WriteLine("Aire du rectangle : " + rectangle.CalculerAire());
            Console.WriteLine("Périmètre du rectangle : " + rectangle.CalculerPerimetre());

            Point origineCercle = new Point(0, 0);
            Cercle cercle = new Cercle(4, origineCercle);
            Console.WriteLine("Aire du cercle : " + cercle.CalculerAire());
            Console.WriteLine("Périmètre du cercle : " + cercle.CalculerPerimetre());

            Console.ReadLine();
            */

            /* Exercice 2 
            Salarié salarie1 = new Salarié("Dupont", "Jean", "jean.dupont@gmail.com", "12 rue Duluc", 3000, 1);
            Salarié salarie2 = new Salarié("Durand", "Marie", "marie.durand@gmail.com", "3 Avenue des girouettes ", 3500, 2);
            Salarié salarie3 = new Salarié("Martin", "Pierre", "pierre.martin@gmail.com", "789 boulevard Saint-Michel", 3200, 3);

            List<Salarié> listeSalariés = new List<Salarié>();
            listeSalariés.Add(salarie1);
            listeSalariés.Add(salarie2);
            listeSalariés.Add(salarie3);

            listeSalariés.Sort();

            foreach (Salarié salarié in listeSalariés)
            {
                Console.WriteLine(salarié);
                Console.WriteLine();
            }
            */


            /*Exercice 3 

            Entreprise entreprise = new Entreprise("Nom", "Adresse");

            double moyenneSalaires = entreprise.Moyenne(entreprise.Salariés);
            Console.WriteLine("La moyenne des salaires est : " + moyenneSalaires);

            Console.ReadLine();
            */

            /*Exercice 4

            Entreprise entreprise = new Entreprise("Ma société", "1, rue de l'entreprise");
            Console.WriteLine($"Identification de l'entreprise : {entreprise.Identification(entreprise.Nom_Entreprise)}");
            Console.ReadLine();
            */

            /*Exercice 5.1*/
            static bool Compare2Objets(TD5_6.IConvertible obj1, TD5_6.IConvertible obj2)
            {
                bool test = false;
                if (obj1.Convert()==obj2.Convert())
                { test = true; }
                return test;
            }

            static TD5_6.IConvertible ChercherMinTab(TD5_6.IConvertible[] tab)
            {
                TD5_6.IConvertible minimum = tab[0];
                foreach (var objet in tab)
                {
                    if(objet.Convert() < minimum.Convert())
                    {
                        minimum = objet;
                    }  
                }
                return minimum;
            }
            

        }
    }
}
