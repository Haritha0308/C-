using System;
using System.Collections.Generic;
using System.Text;

namespace Exo1
{
    class Livre : Article
    {
        protected string isbn;
        protected int nbPages;



        public Livre(string identification, int page, string designation, double price) : base(designation, price)
        {
            isbn = identification;
            nbPages = page;
        }
    }
}
