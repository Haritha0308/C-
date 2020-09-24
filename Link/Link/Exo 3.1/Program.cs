using System;
using System.Collections.Generic;
using System.Linq;

namespace Exo_3._1
{
    class Program
    {
        public static bool IsPrime(int value)
        {
            if (value == 1)
            {
                return false;
            }
            if (value == 2)
            {
                return true;
            }

            var limit = Math.Ceiling(Math.Sqrt(value));

            for (int i = 2; i <= limit; ++i)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            List<int> listeEntiers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14 };
            List<int> listeEntiersPremiers =
                (from unEntier in listeEntiers
                 where IsPrime(unEntier)
                 select unEntier).ToList();
            Console.WriteLine("Liste de nombres premiers:\t");
            foreach (int value in listeEntiersPremiers)
            {
                Console.Write(" || " + value +" || ");
            }
        }
    }
}
