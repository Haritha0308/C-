using System;

namespace Personnes
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("DA COSTA", "Jean-Baptiste", 21);
            Personne p2 = new Personne("CALIANASSOUNDARAM", "Jennifer", 24);
            Personne p3 = new Personne("RIGAUD", "Louis", 21);


            Console.WriteLine($"Il y a {p3.Combien()} personnes");
            p1.Dispose();
            Console.WriteLine($"Il y a {p3.Combien()} personnes");
        }
    }
}
