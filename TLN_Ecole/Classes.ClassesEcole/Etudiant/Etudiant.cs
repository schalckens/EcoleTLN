using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Etudiant : Contact
    {
        protected string section;

        public Etudiant(int matricule,string nom, int anneeArrivee,string section) : base(matricule,nom,anneeArrivee)
        {
            this.section = section;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Section : " + section;
        }
    }
}
