using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG_klasser_etc
{
    enum Ticket { FirstClass, SecondClass, Economy, Stowaways }
    internal class Passenger : Person
    {
        public Ticket Ticket { get; set; }
        public int Cabin { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
    }

    public void ChangeTicket(Ticket newticket); 
    {
        if (Ticket == newTicket)
        {
        Console.WriteLine("Vi degraderer ikke til Stowaway-klassen.);
        }
        if (newTicket == Ticket.Stowaway)

        else Ticket = newTicket;
    }
}
