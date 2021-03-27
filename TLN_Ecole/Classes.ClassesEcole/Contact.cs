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
            this.anneeArrivee = AnneeArrivee;
        }

        public override string ToString()
        {
            return "\n\t Matricule : " + this.matricule + "\n\t Nom : " + this.nom + "\n\t Année : " + this.AnneeArrivee;
        }

        public int Matricule { get => matricule; }
        public string Nom { get => nom; }
        public int AnneeArrivee 
        { 
            get => anneeArrivee; 
            set 
            { 
                if ( DateTime.Now.Year >= value)
                {
                    this.anneeArrivee = value;
                }
                else
                {
                    throw new Exception("Annee d'arrivée non valide.");
                }
            } 
        }
    }
}
