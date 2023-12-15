Tamagochi tama = new();
Shop shop = new Shop();
string input;

Console.WriteLine("Välj ett namn till din tamagochi");
tama.name = Console.ReadLine();

while (tama.GetAlive() == true) // En loop som gör så att tamagochin lever
{
tama.PrintStats(); // skriver ut hur mycket hunger och sånt den har

Console.WriteLine($"Vad göra med {tama.name}");
Console.WriteLine("1. Mata den");
Console.WriteLine("2. Hälsa på den");
Console.WriteLine("3. Lära den ett nytt ord");
Console.WriteLine("4. Köp mat");
Console.WriteLine("5. Ingenting");
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

    tama.Feed();
    Console.ReadLine();

}
else if (input == "4")
{
    Console.WriteLine("Skriv F för att köpa en frukt");
    string BuyFruit = Console.ReadLine();
    //Console.WriteLine("B. Banan 10kr");
    // Console.WriteLine("C. Tårta 20kr");

    if (BuyFruit.ToLower() == "f") // så man kan skriva både stort och litet F
    {  
 
        tama.BuyFruit(); // Den lägger till en frukt och minskar pengarna med 10kr
        
    }
    else 
    {
    Console.WriteLine("Nej du kan inte skriva så.");
    Console.ReadLine();
    }
}

else if (input == "5")
{
    tama.Tick();
}
else
{
    Console.WriteLine("Nej du kan inte skriva så.");
    Console.ReadLine();
}
Console.Clear(); // Det man skrivit innan försvinner
}

Console.WriteLine($"{tama.name} är nu död...");
Console.ReadLine();

// Lägga till så det finns två
// De kan fightas
// Man kan köpa saker i en butik... Typ mat som ger olika mycket hunger tillbaka
//