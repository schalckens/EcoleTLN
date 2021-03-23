﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class EtudiantRegulier : Etudiant
    {
        private double noteMoyenne;

        public EtudiantRegulier(int matricule,string nom,int anneeArrivee,string section, double noteMoyenne) : base(matricule,nom,anneeArrivee,section)
        {
            this.noteMoyenne = noteMoyenne;
        }
        public override string ToString()
        {
            return base.ToString() + "\n Moyenne : " + noteMoyenne ;
        }
        public double NoteMoyenne { get => noteMoyenne; }
    }
}
