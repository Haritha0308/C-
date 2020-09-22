using System;
using System.Collections.Generic;
using System.Text;

namespace SociétéTableau
{
    public class Directeur : Chef
    {
        public string Societe { get; set; }

        public Directeur(string nom, string prenom, int age, double salaire, string service, string societe):base(nom, prenom, age, salaire, service)
        {
            Societe = societe;
        }

        public override string ToString()
        {
            return $"Nom : {Nom}, Prenom : {Prenom}, Age : {Age}, Salaire : {Salaire}, Service : {Service}";
        }

        public new void Afficher()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
