using System;
using System.Collections.Generic;
using System.Text;

namespace Personnes
{
    class Personne : IDisposable
    {
        private string _nom;
        private string _prenom;
        private int _age;

        private static int compteur = 0;

        public Personne(string nom, string prenom, int age)
        {
            _nom = nom;
            _prenom = prenom;
            _age = age;
            compteur++;
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom : {this._nom}, Prénom : {this._prenom}, Âge : {this._age}");
        }

        public int Combien()
        {
            return compteur;
        }

        //Méthode à ajouter pour gérer le nombre d'instances
        public void Dispose()
        {
            compteur--;
        }
    }
}
