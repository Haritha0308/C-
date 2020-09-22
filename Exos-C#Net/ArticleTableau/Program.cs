using System;

namespace ArticleTableau
{
    class Program
    {
        static void Main(string[] args)
        {

            Article art1 = new Article("Peter Pan", 9.99, 5, ArticleType.loisir);
            Article art2 = new Article("Mulan", 19.99, 1, ArticleType.habillement);
            Article art3 = new Article("Roi Lion", 15.99, 3, ArticleType.loisir);

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
            Console.WriteLine("Saisir le type de l'article :");
            string type = Console.ReadLine();
            ArticleType typeParse = (ArticleType)Enum.Parse(typeof(ArticleType), type);
            Article art4 = new Article(nom, Convert.ToDouble(prix), Convert.ToDouble(quantite), typeParse);
            art4.Afficher();

            Article[] tabArticle = new Article[] { art1, art2, art3, art4 };
            foreach (Article article in tabArticle)
            {
                article.Afficher();
                article.Ajouter(3);
                Console.WriteLine("\nListe des articles après ajout des quantités");
                article.Afficher();
            }
            foreach (Article article in tabArticle)
            {
                article.Retirer(1);
                Console.WriteLine("\nListe des articles après retrait des quantités");
                article.Afficher();
            }


        }
    }
}
