using System;
using System.Collections.Generic;
using System.Text;

namespace Exo1
{
    class Poche : Livre
    {
        private string categorie;

        public Poche(string identification, int page, string cat, string designation, double price) : base(identification, page, designation, price)
        {
            cat = categorie;
        }


    }
}
