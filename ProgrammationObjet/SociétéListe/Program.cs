using ListeChainee;
using System;

namespace Societe

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

            Liste maListe = new Liste();
            maListe.InsererDebut(e1);
            maListe.InsererDebut(e2);
            maListe.InsererDebut(e3);
            maListe.InsererDebut(e4);
            maListe.InsererDebut(e5);
            maListe.InsererDebut(c1);
            maListe.InsererDebut(c2);
            maListe.InsererDebut(d1);

            Console.WriteLine("\tListe avec insertions au début");
            maListe.Lister();
            maListe.Vider();

            maListe.InsererFin(e1);
            maListe.InsererFin(e2);
            maListe.InsererFin(e3);
            maListe.InsererFin(e4);
            maListe.InsererFin(e5);
            maListe.InsererFin(c1);
            maListe.InsererFin(c2);
            maListe.InsererFin(d1);

            Console.WriteLine("\n\tListe avec insertions par la fin");
            maListe.Lister();

            Console.WriteLine("\n\tSecond élément");
            Console.WriteLine(maListe[1].Objet);
        }
    }
}
