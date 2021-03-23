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

        public Boolean EstEtudiant(Contact contact) { return contact is Etudiant; }

        public int NbContacts() { return this.contacts.Count; }

        public double MoyenneEtudiantRegulier()  
        {
            double som = 0;
            foreach (Contact contact in contacts.Values)
            {
                if (contact is EtudiantRegulier unContact)
                {
                    // on caste l'objet contact de la classe Contact
                    // en objet de la classe EtudiantRegulier
                    //som += ((EtudiantRegulier)contact).NoteMoyenne;
                    som += unContact.NoteMoyenne;

                }
            }
            return som;
        }

        public void AjouterContact(Contact contact) { this.contacts.Add(contact.Matricule,contact); }
        public void AjouterContact(Dictionary<Int32, Contact> contact) { this.contacts.Concat(contact); }
        public int NbEtudiants() 
        {
            int a = 0;
            foreach (Contact contact in contacts.Values)
            {
                if (contact is Etudiant)
                {
                    a++;
                }
            }
            return a;
        }
        public Boolean ExisteContact(int matricule) { return this.contacts.ContainsKey(matricule); }
        public Boolean ExisteContact(Contact contact) { return this.contacts.ContainsKey(contact.Matricule); }



        public string Nom { get => nom;}
        public int AnneeCreation { get => anneeCreation;}
    }
}
