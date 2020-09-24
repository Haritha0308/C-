using System;
using System.Collections.Generic;
using System.Text;

namespace Societe
{
    public class Chef : Employe
    {
        public string Service { get; set; }

        public Chef(string nom, string prenom, int age, double salaire, string service) : base(nom, prenom, age, salaire)
        {
            Service = service;
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
