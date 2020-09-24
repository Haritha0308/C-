using ListeChainee;
using Societe;
using System;

namespace SocieteEnumeration
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("\tListe des employés par énumération");
            foreach(var t in maListe)
            {
                Console.WriteLine(t.Objet);
            }
        }
    }
}
