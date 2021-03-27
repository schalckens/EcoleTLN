using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Personnel : Contact
    {
        protected string nomLaboratoire;
        protected double salaire;

        public Personnel(int matricule,string nom, int anneeArrivee,string nomLaboratoire, double salaire) : base(matricule,nom,anneeArrivee)
        {
            this.nomLaboratoire = nomLaboratoire;
            this.salaire = salaire;
        }

        public override string ToString()
        {
            return base.ToString() + "\n\t Laboratoire : " + nomLaboratoire + "\n\t Salaire : " + salaire;
        }
    }
}
