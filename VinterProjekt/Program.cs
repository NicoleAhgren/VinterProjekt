
Tamagochi tama = new();
string input;

Console.WriteLine("Välj ett namn till din tamagochi");
tama.name = Console.ReadLine();

while (tama.GetAlive() == true)
{
    tama.PrintStats();

    Console.WriteLine($"Vad göra med {tama.name}");
    Console.WriteLine("1. Mata den");
    Console.WriteLine("2. Hälsa på den");
    Console.WriteLine("3. Lära den ett nytt ord");
    Console.WriteLine("4. Ingenting");
    input = Console.ReadLine();
    if (input == "3")
    {
        Console.WriteLine($"Vad vill lära din {tama.name} för ord?");
        tama.TeachWord(Console.ReadLine());
        Console.WriteLine($"{tama.name} kan ett nytt ord nu!");
        tama.Tick();
        Console.ReadLine();
        
    }
    else if (input == "2")
    {
        tama.Hello();
        tama.Tick();
        Console.ReadLine();
    }
    else if (input == "1")
    {
        Console.WriteLine($"Du gav {tama.name} en bit pizza");
        tama.Feed();
        tama.Tick();
        Console.ReadLine();
    }
    else if (input == "4")
    {
        tama.Tick();
    }
    else
    {
        Console.WriteLine("Nej du kan inte skriva så.");
        Console.ReadLine();
    }
    Console.Clear();
}

Console.WriteLine($"{tama.name} är nu död...");
Console.ReadLine();