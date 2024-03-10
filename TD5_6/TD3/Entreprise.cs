using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD3;

namespace TD5_6
{
    internal class Entreprise : IMoyenne<List<Salarié>>, IIdentifiable<string>
    {
        private string nom_entreprise;
        private string adresse;
        private List<Salarié> salariés;

        public Entreprise(string nom_entreprise, string adresse)
        {
            this.nom_entreprise = nom_entreprise;
            this.adresse = adresse;
            salariés = new List<Salarié>();
        }

        public string Nom_Entreprise
        {
            get { return nom_entreprise; }
            set { nom_entreprise = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public List<Salarié> Salariés
        {
            get { return salariés; }
            set { salariés = value; }
        }

        public void AddSalarié(Salarié salarié_ajouté)
        {
            salariés.Add(salarié_ajouté);
            salarié_ajouté.Num_Salarié = salariés.Count;
        }

        public void RemoveSalarié(Salarié salarié)
        {
            salariés.Remove(salarié);
        }


        public void AfficherSalariés()
        {
            Console.WriteLine("Liste des salariés :");
            foreach (Salarié salarié in salariés)
            {
                Console.WriteLine(salarié.ToString() + "\n");
            }
        }
        public Salarié CreerUnSalarié()
        {
            Console.WriteLine("Veuillez entrer le nom du salarié : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Veuillez entrer le prénom du salarié : ");
            string prenom = Console.ReadLine();
            Console.WriteLine("Veuillez entrer l'email du salarié : ");
            string email = Console.ReadLine();
            Console.WriteLine("Veuillez entrer l'adresse du salarié : ");
            string adresse = Console.ReadLine();
            Console.WriteLine("Veuillez entrer le salaire du salarié : ");
            int num_salarié = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Veuillez entrer le numéro du salarié : ");
            double salaire = Convert.ToDouble(Console.ReadLine());
            return new Salarié(nom, prenom, email, adresse, salaire,num_salarié);
        }
        public void Interface()
        {
            Console.WriteLine("--- INTERFACE ENTREPRISE ---");
            Console.WriteLine("\nQue souhaitez-vous faire ?\n \n1)Interface salarié \n2)Interface prestataire \n3)Quitter");
            int choix = Convert.ToInt32(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    InterfaceSalarié();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Choix invalide");
                    break;
            }
        }

        public void InterfaceSalarié()
        {
            Console.WriteLine("--- INTERFACE SALARIÉ ---");
            Console.WriteLine("\nQue souhaitez-vous faire ?\n \n1)Recruter un salarié \n2)Licencier un salarié \n3)Modifier les informations d'un salarié \n4)Afficher la liste des salariés \n5)Sauvgarder la liste de salariés dans un fichier csv \n6)Quitter");
            int choix = Convert.ToInt32(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    AddSalarié(CreerUnSalarié());
                    Interface();
                    break;
                case 2:
                    AfficherSalariés();
                    Console.WriteLine("\nVeuillez entrer le numéro du salarié à licencier : ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    bool found = false;
                    for (int i = 0; i < salariés.Count; i++)
                    {
                        Console.WriteLine(salariés[i].Num_Salarié);
                        if (num == salariés[i].Num_Salarié)
                        {
                            Console.WriteLine("Le salarié " + salariés[i].Nom + " " + salariés[i].Prenom + " a été licencié");
                            RemoveSalarié(salariés[i]);
                            found = true;
                        }
                    }
                    if (found = !true)
                    {
                        Console.WriteLine("Salarié non trouvé");
                    }
                    Console.WriteLine();
                    InterfaceSalarié();
                    break;
                case 3:
                    ModifierSalarié();
                    Console.WriteLine();
                    InterfaceSalarié();
                    break;
                case 4:
                    AfficherSalariés();
                    Console.WriteLine();
                    InterfaceSalarié();
                    break;
                case 5:
                    CreerFichierSalariés("salaries.csv");
                    Console.WriteLine();
                    InterfaceSalarié();
                    break;
                case 6:
                    Interface();
                    break;
                default:
                    Console.WriteLine("Choix invalide");
                    InterfaceSalarié();
                    break;
            }
        }

        public void ModifierSalarié()
        {
            Console.WriteLine("Veuillez entrer le numéro du salarié à modifier : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que souhaitez -vous modifier ? \n1)nom \n2)prénom  \n3)email \n4)adresse \n5)salaire");
            int choix = Convert.ToInt32(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    Console.WriteLine("Veuillez entrer le nouveau nom : ");
                    salariés[num - 1].Nom = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Veuillez entrer le nouveau prénom : ");
                    salariés[num - 1].Prenom = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Veuillez entrer le nouvel email : ");
                    salariés[num - 1].Email = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Veuillez entrer la nouvelle adresse : ");
                    salariés[num - 1].Adresse = Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Veuillez entrer le nouveau salaire : ");
                    salariés[num - 1].Salaire = Convert.ToDouble(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Choix invalide");
                    break;
            }
        }

        public void ListeSalariés(string filepath)
        {
            var lines = File.ReadAllLines(filepath);
            for (int i = 0; i < lines.Count(); i++)
            {
                var values = lines[i].Split(',');
                Salarié new_salarié = new Salarié(values[0], values[1], values[2], values[3], Convert.ToDouble(values[4]), Convert.ToInt32(values[5]));
                AddSalarié(new_salarié);
            }
        }
        public void CreerFichierSalariés(string filepath)
        {
            List<string> lignes = new List<string>();
            foreach (Salarié salarié in salariés)
            {
                lignes.Add(salarié.Nom + "," + salarié.Prenom + "," + salarié.Email + "," + salarié.Adresse + "," + salarié.Salaire + "," + salarié.Num_Salarié);
            }
            File.WriteAllLines(filepath, lignes);
        }
        public double Moyenne(List<Salarié> salariés)
        {
            double somme = 0;
            double moyenne = 0;
            foreach(var salarié in salariés)
            {
                somme += salarié.Salaire; 
            }
            moyenne = somme / salariés.Count;
            return moyenne;
        }
        public string Identification(string cle)
        {
            return "Entreprise" + cle.ToString();
        }

    }
}
