using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG_klasser_etc
{
    //public enum Role { Captain, Helmsman, Pilot, Sailor, Cook, Gunner }
    internal class Person //dette er vores baseclass
    {
        //Field( laves altid priuvate)
        //private int id;

        //Property (altid public)
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime DoB { get; set; }
        
    }
}
