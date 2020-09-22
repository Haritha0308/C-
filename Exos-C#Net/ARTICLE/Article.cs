using System;
using System.Collections.Generic;
using System.Text;

namespace ARTICLE
{
    public struct Article
    {
        private string _nom;
        private double _prix;
        private double _quantite;

        public Article(string nom, double prix, double quantite)
        {
            _nom = nom;
            _prix = prix;
            _quantite = quantite;
        }

        public void Afficher()
        {
            Console.WriteLine($"Livre :\n\tNom : {this._nom} \n\tPrix : {this._prix}\n\tQuantité : {this._quantite} \n");
        }

        public void Ajouter(double newquantite)
        {
            _quantite += newquantite;
        }

        public void Retirer(double newquantite)
        {
            _quantite -= newquantite;
        }
    }
}
