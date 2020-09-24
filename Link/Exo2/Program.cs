using System;
using System.Collections.Generic;
using System.Linq;

namespace Exo2
{
    class Program
    {
        public static bool AnneeBissextile(int Annee)
        {
            return ((Annee & 3) == 0) && ((Annee % 100 != 0) || (Annee % 400 == 0));
        }

        public static int AnneeProchaine(int Annee)
        {
            for (int i = 0; i < 3; i++)
            {
                var AnneeSuivante = Annee + i;
                if (AnneeBissextile(AnneeSuivante))
                {
                    return AnneeSuivante;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("\tListe avec années bissextiles :");
            var Annee = new List<int> { 1995, 1996, 1999, 2001, 2002, 2003, 2004, 2005, 2006, 2010, 2016 };
            
           var listeAnneeBissextile =
                (from uneAnnee in Annee
                 where AnneeBissextile(uneAnnee)
                 select uneAnnee);

            if (listeAnneeBissextile.Count() == 0)
            {
                Console.WriteLine("Aucune année bissextile");
                var DernierElement = Annee.LastOrDefault();
                Console.WriteLine("Année bissextile suivante : " + AnneeProchaine(DernierElement));
            }
            else
            {
                foreach(var annee in listeAnneeBissextile.ToList())
                {
                    Console.Write(annee + " - ");
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n\tListe avec aucune année bissextile :");
            var Annee2 = new List<int> { 1995, 1999, 2001, 2002, 2003 };
            var listeAnneeBissextile2 =
                 (from uneAnnee in Annee2
                  where AnneeBissextile(uneAnnee)
                  select uneAnnee);

            if (listeAnneeBissextile2.Count() == 0)
            {
                Console.WriteLine("Aucune année bissextile");
                var DernierElement = Annee2.LastOrDefault();
                Console.WriteLine("Année bissextile suivante : " + AnneeProchaine(DernierElement));
            }
            else
            {
                foreach (var annee in listeAnneeBissextile2.ToList())
                {
                    Console.WriteLine(annee);
                }
            }
        }
    }
}
