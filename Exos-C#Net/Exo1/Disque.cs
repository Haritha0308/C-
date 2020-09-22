using System;
using System.Collections.Generic;
using System.Text;

namespace Exo1
{
    class Disque : Article
    {
        protected string label;

        public Disque(string labelDisque, string designation, double prix): base(designation, prix)
        {
            label = labelDisque;
        }
        public void Ecouter()
        {
            Console.WriteLine("Désignation (Disque): \n\t" + this.label + "\n");
        }
    }
}
