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
                if (contact is Etudiant) 
                {
                    if (contact is EtudiantRegulier)
                    {
                        a += "\n Etudiant Régulier : " + contact.ToString() + "\n";
                    }
                    else if (contact is EtudiantEchange)
                    {
                        a += "\n Etudiant Echange : " + contact.ToString() + "\n";
                    }
                    else
                    {
                        a += "\n Etudiant : " + contact.ToString() + "\n";
                    }
                }
                else if (contact is Personnel) 
                {
                    if (contact is Enseignant)
                    {
                        a += "\n Enseignant : " + contact.ToString() + "\n";
                    }
                    else if (contact is Secretaire)
                    {
                        a += "\n Secretaire: " + contact.ToString() + "\n";
                    }
                    else
                    {
                        a += "\n Personnel : " + contact.ToString() + "\n";
                    }
                }
                else 
                {
                    a += "\n Contact : " + contact.ToString() + "\n"; 
                }
            } 
            return a;
        }

        public double AncienneteMoyenne() 
        {
            double somme = 0;
            foreach(Contact contact in contacts.Values)
            {
                somme += (DateTime.Now.Year-contact.AnneeArrivee);
            }
            double moyenne = somme / contacts.Count;
            return moyenne;
        }

        public Boolean EstEtudiant(Contact contact) { return contact is Etudiant; }

        public int NbContacts() { return this.contacts.Count; }

        public double MoyenneEtudiantRegulier()  
        {
            double som = 0;
            int cpt = 0;
            foreach (Contact contact in contacts.Values)
            {
                if (contact is EtudiantRegulier unContact)
                {
                    // on caste l'objet contact de la classe Contact
                    // en objet de la classe EtudiantRegulier
                    //som += ((EtudiantRegulier)contact).NoteMoyenne;
                    som += unContact.NoteMoyenne;
                    cpt++;

                }
            }
            return som/cpt;
        }

        public void AjouterContact(Contact contact) { this.contacts.Add(contact.Matricule,contact); }
        public void AjouterContact(Dictionary<Int32, Contact> contacts2) 
        { 
            //Méthode 1 ligne
            //this.contacts = this.contacts.Select(x => x ).Concat(contact.Select(x => x)).ToDictionary(contacts,contact);
            //
            //Méthode 2 
            foreach(Contact contact in contacts2.Values)
            {
                this.AjouterContact(contact);
            }
        }
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
