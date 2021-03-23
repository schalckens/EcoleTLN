using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Ecole
    {
        private string nom;
        private int anneeCreation;
        private Dictionary<Int32, Contact> contacts;

        public Ecole(string nom, int anneeCreation)
        {
            this.nom = nom;
            this.anneeCreation = anneeCreation;
            this.contacts = new Dictionary<Int32, Contact>();
        }

        public string AfficheTous() 
        {
            string a = "";
            foreach( Contact contact in contacts.Values )
            {
                a += contact.ToString();
            } 
            return a;
        }

        public double AncienneteMoyenne() { }

        public Boolean EstEtudiant() { }

        public int NbContacts() { return 3; }

        public double MoyenneEtudiantRegulier() { }

        public void AjouterContact(Contact contact) { this.contacts.Add(contact.Matricule,contact); }

        public int NbEtudiants() { }

        public Boolean ExisteContact(Contact contact) { return this.contacts.ContainsKey(contact.Matricule); }



        public string Nom { get => nom;}
        public int AnneeCreation { get => anneeCreation;}
    }
}
