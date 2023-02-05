using AM.ApplicationCore.Domain;
Plane pl = new Plane();
{
    pl.Capacity = 707;
    pl.ManualFactureDate = DateTime.Now;
    pl.PlaneId = 3;
    pl.PlaneType = PlaneType.Boing;
}
Console.WriteLine(pl);

Plane plane2 = new Plane()
{
    Capacity = 770,
    ManualFactureDate = DateTime.Now,
    PlaneId = 7,
    PlaneType = PlaneType.Airbus
};

Console.WriteLine(plane2);


/*III Le Polymorphisme*/
Passenger ps = new Passenger()
{
    BirthDate = DateTime.Now,
    PasseportNumber = 7777,
    EmailAddress = "test@esprit.tn",
    FirstName = "Ines",
    LastName = "Bennasr",
    TelNumber = 7777777
};
bool result = ps.CheckProfile("Ines", "Bennasr");

if (result)
{
    Console.WriteLine("Profile matches");
}
else
{
    Console.WriteLine("Profile does not match");
}

Console.WriteLine(ps.CheckProfile("Ines", "Bennasr", "test@esprit.tn"));
bool result1 = ps.CheckProfile("Ines", "Bennasr");

if (result1)
{
    Console.WriteLine("Profile matches( 2 param )");
}
else
{
    Console.WriteLine("Profile does not match( 2 param )");
}

bool result2 = ps.CheckProfile("Ines", "Bennasr", "test@esprit.tn");

if (result2)
{
    Console.WriteLine("Profile matches (3 parameters)");
}
else
{
    Console.WriteLine("Profile does not match (3 parameters)");
}

Passenger psg = new Passenger();
psg.PassengerType();


Staff st = new Staff();
Traveller tr = new Traveller();
st.PassengerType();
tr.PassengerType();

