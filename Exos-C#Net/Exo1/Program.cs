using System;

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Article art1 = new Article("Peter Pan", 15.99);
            Livre livre1 = new Livre("Livre pour enfant", 12, "Imagaire", 8.99);
            Disque disque1 = new Disque("Comme un homme - Mulan", "Disney", 11.99);
            Video vid1 = new Video("6:42:51", "Chopin - Concerto pour Piano n°2", 16.99);
            vid1.Afficher();
            vid1.Acheter();
            disque1.Ecouter();
            Poche poch1 = new Poche("La Fée Clochette", 16, "Mon Histoire Du Soir", "Livre pour enfants", 2.99);
            poch1.Acheter();

        }
    }
}
