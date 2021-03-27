using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Secretaire : Personnel
    {
        public Secretaire(int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire) : base(matricule, nom, anneeArrivee, nomLaboratoire, salaire) { }
        public override string ToString()
        {
            return "\n Secretaire : " + base.ToString() + "\n";
        }
    }
}
