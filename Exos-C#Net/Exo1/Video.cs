using System;
using System.Collections.Generic;
using System.Text;

namespace Exo1
{
    class Video : Article
    {
        protected string durée;


        public Video(string temps, string designation, double price) : base(designation, price)
        {
            durée = temps;
        }
        public void Afficher()
        {
            Console.WriteLine("Durée (Video): \n\t" + this.durée + "\n");
        }
    }
}
