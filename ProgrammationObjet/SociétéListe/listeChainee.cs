using System;
using System.Collections.Generic;
using System.Text;

namespace ListeChainee
{   
    class Element
    {
        public object Objet { get; set; }
        public Element Suivant { get; set; }

        public Element(object objet)
        {
            Objet = objet;
        }
    }
    class Liste
    {
        public Element Debut;
        public int NBElement { get; }
        public Liste(Element debut, int nbelement)
        {
            Debut = debut;
            NBElement = nbelement;
        }
        
        public InsererDebut()
        {

        }
    }
}
