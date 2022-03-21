Dictionary<string, int> slovnik = new Dictionary<string, int>();
slovnik.Add("STR", 10);
slovnik.Add("DEX", 10);
slovnik.Add("INT", 10);

Console.WriteLine("Zadej jméno své postavy:");
Console.ReadLine();

Random rnd = new Random();
int cas = rnd.Next(5, 20);
if (cas => 5 && cas =< 10)
{
    Console.WriteLine("Tvoje síla:" + (slovnik["STR"] + 10));
    Console.WriteLine("Tvoje dexterita:" + (slovnik["DEX"] + 10));
    Console.WriteLine("Tvoje inteligence:" + (slovnik["INT"] + 10));
}


int potreba = (100);
Console.WriteLine("Potřebuješ srát na " + potreba + "%");
Console.WriteLine("Chceš se vysrat nebo jít na quest? (V/Q)");
Console.ReadLine();

string odpoved = Console.ReadLine();
if (odpoved == "V")
{
        Console.WriteLine("Vysral ses, potřbuješ srát na " + (potreba - 10));
}
else if (odpoved == "Q")
{
    Console.WriteLine("Vydal ses na quest, čekej" + rnd );
    
}