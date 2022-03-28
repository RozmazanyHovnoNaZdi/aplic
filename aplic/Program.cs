Dictionary<string, int> slovnik = new Dictionary<string, int>();
slovnik.Add("STR", 10);
slovnik.Add("DEX", 10);
slovnik.Add("INT", 10);

Console.WriteLine("Zadej jméno své postavy:");
Console.ReadLine();
int potreba = (30);

while (true)
{
    Console.WriteLine("Potřebuješ srát na " + potreba + "%");
    Console.WriteLine("Chceš se vysrat nebo jít na quest? (V/Q)");
    string odpoved = Console.ReadLine();
    Random HVN = new Random();
    int pica = HVN.Next(0, 100);
    if (pica < potreba )
    {
        Console.WriteLine("Umrel jsi pico");
        System.Environment.Exit(0);
    }
     


    Random rnd = new Random();
    int cas = rnd.Next(5, 20);
    if (odpoved == "V")
    {
        Console.WriteLine("Vysral ses, potřbuješ srát na " + (potreba -= 10) + "%");
    }
    if (odpoved == "Q")
    {
        
        Console.WriteLine("Vydal ses na quest, čekej " + cas + "s");
        Thread.Sleep(cas * 1000);
    }

    if (cas >= 5 && cas <= 10)
    {
        Console.WriteLine("Nevysral ses, tvoje potreba: " + (potreba += 10) + "%");
        Console.WriteLine("Tvoje síla:" + (slovnik["STR"] += 10));
        Console.WriteLine("Tvoje dexterita:" + (slovnik["DEX"] += 10));
        Console.WriteLine("Tvoje inteligence:" + (slovnik["INT"] += 10));
    }

     if (cas >= 11 && cas <= 15)
    {
        Console.WriteLine("Nevysral ses, tvoje potreba: " + (potreba += 15) + "%");
        Console.WriteLine("Tvoje síla:" + (slovnik["STR"] += 15));
        Console.WriteLine("Tvoje dexterita:" + (slovnik["DEX"] += 15));
        Console.WriteLine("Tvoje inteligence:" + (slovnik["INT"] += 15));
    }
     if (cas >= 16 && cas >= 20)
    {
        Console.WriteLine("Nevysral ses, tvoje potreba: " + (potreba += 20) + "%");
        Console.WriteLine("Tvoje síla:" + (slovnik["STR"] += 20));
        Console.WriteLine("Tvoje dexterita:" + (slovnik["DEX"] += 20));
        Console.WriteLine("Tvoje inteligence:" + (slovnik["INT"] += 20));
    }

}







