using System;
using System.Collections.Generic;
using Classes.ClassesEcole;


namespace EcoleTLN
{
    class Program
    {
        static void Main()
        {
            Ecole ecoleTLN = new Ecole("écoleTLN",1980);
            Console.WriteLine("---- Ajout d'une collection de contacts ----");
            ecoleTLN.AjouterContact(CreerContacts());
            Console.WriteLine("Parmi les {0} personnes de l'{1}, {2} sont des étudiants",ecoleTLN.NbContacts(),ecoleTLN.Nom,ecoleTLN.NbEtudiants());
            Console.WriteLine("Ils sont à l'école depuis en moyenne {0} ans.", ecoleTLN.AncienneteMoyenne());
            Console.WriteLine("----  Affichage Tous ----");
            Console.WriteLine(ecoleTLN.AfficheTous());
            Console.WriteLine("Moyenne des étudiants réguliers = {0}",ecoleTLN.MoyenneEtudiantRegulier());
            Console.WriteLine("---- Ajout d'un contact ----");
            Contact contact = new Contact(1444, "Valentine Schalckens", 2020);
            ecoleTLN.AjouterContact(contact);
            Console.WriteLine("---- Vérifications ----");
            Console.WriteLine("Nb contacts : {0}",ecoleTLN.NbContacts());
            List<int> a = new List<int> {1200, 9999, 1444, 2222};
            foreach( int b in a)
            {
                if(ecoleTLN.ExisteContact(b))
                {
                    Console.WriteLine("{0} existe.", b);
                }
                else
                {
                    Console.WriteLine("{0} n'existe pas", b);
                }
            }
            Console.WriteLine("---- Fin du Programme ----");
            Console.ReadKey();
        }

        public static Dictionary<Int32,Contact> CreerContacts()
        {
            Dictionary<Int32, Contact> contacts = new Dictionary<int, Contact>();
            contacts.Add(1200,new EtudiantRegulier(1200, "Gaston peutimide", 2013, "Système de Communication", 6.0));
            contacts.Add(1204, new EtudiantRegulier(1204, "Yvan Rattrapeur", 2011, "Système de Communication", 2.5));
            contacts.Add(1345, new EtudiantEchange(1345, "Björn Borgue", 2012, "Informatique", "KTH"));
            contacts.Add(1114, new Enseignant(1114, "Mathieu Matheu", 1998, "Mathématiques Extrêmement Pures (LMEP)",10000, "Physique"));
            contacts.Add(1409, new Secretaire(1409, "Sophie Scribona", 2005, "Machine à Taper (LMT)", 5000));
            return contacts;
        }
    }
}
