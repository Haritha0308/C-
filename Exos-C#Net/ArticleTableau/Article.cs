using System;
using System.Collections.Generic;
using System.Text;


namespace ArticleTableau
{
    public struct Article
    {
        private string _nom;
        private double _prix;
        private double _quantite;
        private ArticleType _type;
        

        public Article(string nom, double prix, double quantite, ArticleType type)
        {
            _nom = nom;
            _prix = prix;
            _quantite = quantite;
            _type = type;
        }

        public void Afficher()
        {
            Console.WriteLine($"Livre :\n\tNom : {this._nom} \n\tPrix : {this._prix}\n\tQuantité : {this._quantite} \n\tType : {this._type}");
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
