using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Contact
    {
        private int matricule;
        private string nom;
        private int anneeArrivee;

        public Contact(int matricule, string nom, int anneeArrivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArrivee = anneeArrivee;
        }

        public override string ToString()
        {
            return "\n Matricule : " + matricule + "\n Nom : " + nom + "\n Année : " + anneeArrivee;
        }

        public int Matricule { get => matricule; }
        public string Nom { get => nom; }
        public int AnneeArrivee { get => anneeArrivee; }
    }
}
