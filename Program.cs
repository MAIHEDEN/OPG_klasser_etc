
using OPG_klasser_etc;

Crew crew1 = new Crew() //nu har vi oprettet en ny crewklasse
{
    Id = 1,
    Name = "Henry Morgan",
    Role = Role.Captain,
    DoB = new DateTime(1635, 1, 2),
    Schedule = new Schedule
    {
        Start = new DateTime(2021, 10, 30),
        End = new DateTime(2021, 11, 30)
    }
};

Passenger passenger1 = new Passenger() //vi instiantierer et nyt object med navnet passenger1 og propper data i med det samme
{
    Id = 1000,
    Name = "Tom Hanks",
    Cabin = 106,
    Origin = "Liverpool",
    Destination = "New York",
    DoB = new DateTime(1956, 7, 9),
    Ticket = Ticket.FirstClass

};

List<Person> persons = new List<Person>();
persons.Add(passenger1 as Person);//Disse er to måder at caste på
persons.Add((Person)crew1);//Disse er to måder at caste på

//foreach (var Person in persons)
//{   if (Person.GetType() == typeof(Passenger))
//    { 
//    Passenger p = (Passenger)Person; //nu har vi s´castet, så vi kan hive fat i personens egenskaber også - og ikke kun Passengeren har
//        Console.WriteLine($"" + "Type: Passenger\t Name: {p.Name}\t Cabin: {p.Cabin}");
//    }
//    else if (Person.GetType() == typeof(Crew))
//    {
//        Crew c = (Crew)Person;  //Vi instantierer ikke noget nyt objekt her, vi peger bare p åvores date)
//        Console.WriteLine($"Type: {GetType}");
//    }
//    Console.WriteLine(Person.Name + " " + Person.GetType());
//}
passenger1.Ticket(Ticket.Stowaways);

Console.WriteLine();
Console.ReadKey();