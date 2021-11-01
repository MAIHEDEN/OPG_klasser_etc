using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG_klasser_etc
{
    public enum Role {Captain , Helmsman, Pilot, Sailor, Cook, Gunner}
    internal class Crew : Person
    {
        public Role Role { get; set; }
        public Schedule Schedule { get; set; }
    
    }

    internal class Schedule 
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

}
