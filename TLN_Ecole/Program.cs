using System;
using System.Collections.Generic;
using Classes.ClassesEcole;

namespace EcoleTLN
{
    class Program
    {
        static void Main()
        {

        }

        public static Dictionary<Int32,Contact> CreerContacts()
        {
            Dictionary<Int32, Contact> contacts = new Dictionary<int, Contact>();

            return contacts;
        }


        //Ecole Bona = new Ecole("Bonaparte", 1920);
        //Contact contact = new Contact(1, "Bastien", 2000);
        //Bona.AjouterContact(contact);
        //    contact = new EtudiantRegulier(1200, "Gaston Peutimide", 2013, "SSC", 6);
        //Bona.AjouterContact(contact);
        //    contact = new EtudiantRegulier(1204, "Yvan Rattrapeur", 2011, "SSC", 2.5);
        //Bona.AjouterContact(contact);
        //    contact = new EtudiantEchange(1345, "Yvan Rattrapeur", 2011, "SSC", 2.5);
    }
}
