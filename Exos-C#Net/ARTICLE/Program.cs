using System;

namespace ARTICLE
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Article art1 = new Article("Peter Pan", 9.99, 5);
            Article art2 = new Article("Mulan", 19.99, 1);
            Article art3 = new Article("Roi Lion", 15.99, 3);

            art1.Afficher();
            art2.Afficher();
            art3.Afficher();

            art1.Retirer(2);
            art2.Ajouter(6);
            art3.Retirer(1);

            art1.Afficher();
            art2.Afficher();
            art3.Afficher();


            Console.WriteLine("Saisir le nom de l'article : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Saisir le prix de l'article :");
            string prix = Console.ReadLine();
            Console.WriteLine("Saisir la quantité de l'article :");
            string quantite = Console.ReadLine();
            Article art4 = new Article(nom, Convert.ToDouble(prix), Convert.ToDouble(quantite));
            art4.Afficher();
            Console.ReadKey();
        }
    }
}
