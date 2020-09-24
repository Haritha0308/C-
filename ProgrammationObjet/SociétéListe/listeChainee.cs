using System;
using System.Collections.Generic;

namespace ListeChainee
{
    public class Element : IDisposable
    {
        public object Objet { get; set; }
        public Element Suivant { get; set; }

        public Element(object objet)
        {
            Objet = objet;
            Suivant = null;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

    public class Liste
    {
        public Element Debut;
        private int nbElement;
        public int NBElement => this.nbElement;
        public Liste()
        {
            this.Debut = null;
            this.nbElement = 0;
        }

        public Element this[int index]
        {
            get
            {
                if (index > nbElement)
                {
                    throw new Exception("out of limit");
                }
                Element actual = this.Debut;
                for ( int i = 0; i< index; i++)
                {
                    actual = actual.Suivant;
                }
                return actual;
            }
        }

        public void InsererDebut(object objet)
        {
            Element element = new Element(objet);

            if (this.Debut == null)
            {
                this.Debut = element;
                return;
            }

            Element temp = this.Debut;
            this.Debut = element;
            this.Debut.Suivant = temp;
            this.nbElement++;
        }
        public void InsererFin(object objet)
        {
            Element element = new Element(objet);
            if (this.Debut == null)
            {
                this.Debut = element;
                return;
            }

            Element actual = this.Debut;
            while (actual.Suivant != null)
            {
                actual = actual.Suivant;
            }

            // SUivant == null
            actual.Suivant = element;
            this.nbElement++;
        }

        public void Lister()
        {
            Element actual = this.Debut;
            if (actual == null)
            {
                Console.WriteLine("Liste chainée vide");
                return;
            }

            while (actual.Suivant != null)
            {
                Console.WriteLine(actual.Objet);
                actual = actual.Suivant;
            }

            Console.WriteLine(actual.Objet);
        }

        public void Vider()
        {
            List<Element> aVider = new List<Element>();

            Element actual = this.Debut;
            if (actual == null)
            {
                Console.WriteLine("Liste chainée vide");
                return;
            }

            while (actual.Suivant != null)
            {
                aVider.Add(actual);
                actual = actual.Suivant;
            }
            aVider.Add(actual);

            foreach (Element current in aVider)
            {
                current.Dispose();
            }

            this.Debut = null;
            this.nbElement = 0;
        }
    }
}
