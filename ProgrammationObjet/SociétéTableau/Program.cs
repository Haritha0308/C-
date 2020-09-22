using System;

namespace SociétéTableau
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employe e1 = new Employe("ROCHER", "Oriane", 42, 1350);
            Employe e2 = new Employe("RENAUD", "Thierry", 33, 1550);
            Employe e3 = new Employe("BOSSE", "Antoinette", 27, 1450);
            Employe e4 = new Employe("QUINN", "Patrick", 32, 1570);
            Employe e5 = new Employe("LAVALLEE", "Samuel", 29, 1450);
            Chef c1 = new Chef("LEMELIN", "Armand", 45, 1835, "Logistique");
            Chef c2 = new Chef("MIGNEAU", "Mallory", 44, 1840, "Informatique");
            Directeur d1 = new Directeur("HARQUIN", "Noémie", 53, 2100, "Direction", "Happy Bear Investment");

            Personne[] PersonneSociete = new Personne[] { e1, e2, e3, e4, e5, c1, c2, d1 };
            Console.WriteLine("Liste des Employés de la Société");
            for (int i = 0; i < PersonneSociete.Length; i++)
            {
                PersonneSociete[i].Afficher();
            }

            PersonneSociete[1]++;
            c2.Salaire = 1900;
            c1.Service = "RH";

            Console.WriteLine("\nNouvelle liste des Employés de la Société");
            foreach (Personne personne in PersonneSociete)
            {
                personne.Afficher();
            }

        }
    }
}
