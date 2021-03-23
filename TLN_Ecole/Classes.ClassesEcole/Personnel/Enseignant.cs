using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Enseignant
    {
        private string section;

        public override string ToString()
        {
            return base.ToString() + "\n Section" + section;
        }
    }
}
