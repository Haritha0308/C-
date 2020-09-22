using System;
using System.Collections.Generic;
using System.Text;

namespace Exo1
{
    class Article
    {
        protected string designation;
        protected double prix;

        public Article(string design, double price)
        {
            designation = design;
            prix = price;
        }


        public void Acheter()
        {
            Console.WriteLine("Désignation (Article) : \n\t" + this.designation + "\n\tPrix :\t " + this.prix + "\n");
        }

    }
}
