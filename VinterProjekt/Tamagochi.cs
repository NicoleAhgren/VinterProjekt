public class Tamagochi
{
    Shop shop = new Shop();
    int hunger = 0;
    int boredom = 0;

    // int money = 0;

    // int fruit = 0;

    // string Tårta;
    List<string> words = new() {"cheeeese"}; // Den kan detta ord från början så den kan hälsa tillbaka
    bool isAlive = true;

    Random generator  = new Random();

    public string name;

    public void PrintStats() // Skriver ut detta högst upp på skärmen så man vet hur mycket man har av allt
    {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words || Money: {shop.money}Kr || Food: {shop.fruit}");
    }

    public void Feed() // Matar tamagochin
    {
        if (hunger < 0)
        {
            Console.WriteLine($"Du kan inte mata {name}. Den är mätt");
        }
        else if (shop.fruit <= 0) // Om man har mindre än 0 frukter så går det inte att mata
        {
            Console.WriteLine("Du har ingen mat kvar!");
            Console.WriteLine("Köp mer i affären");
            Console.ReadLine();
            Tick();
        }
        else if (shop.fruit >= 0) // Om man har mer än 0 frukter så ger man tamagochin en frukt och hungern minskar
        {
        Console.WriteLine($"Du gav {name} en frukt");
        hunger -= 10;
        shop.fruit -= 1;
        }
    }
    public bool GetAlive()
        {
            return isAlive;
        }

    private void ReduceBoredom() // När man leker med den ökar ens pengar och man minskar boredom
    { 
        if (boredom >= 0)
        {
        boredom -= 10;
        shop.money += 10;
        }
        else if (boredom <= 0)
        {
            boredom = 0;
        }

    }
        public void Tick() // Ökar hungern och boredom 
    {
        boredom += generator.Next(5);
        hunger += generator.Next(7);
        if (boredom >= 100 || hunger >= 100)
        {
            isAlive = false;
        }
    //     if (money <= 0)
    //     {

    //         //Du kan inte köpa mat
    //     }
    //     if (fruit <= 0)
    //     {
    //         //Du inte få mata din tama
    //     }
    }
    public void TeachWord(string word) // Man lär den ett nytt ord som sparas Och man minskar boredom
    {
        words.Add (word);
       ReduceBoredom();
        return;
    }
    public void Hello() // Man hälsar på den så den säger ett ord tillbaka och minskar boredom
    {
        int wordNr = generator.Next(words.Count);
        Console.WriteLine($" {name} says: {words[wordNr]}");
        ReduceBoredom();
    }
    public void BuyFruit() // MAn kan köpa frukt
    {
        if (shop.money <= 0) // om man har midre än 0 så går det inte
        {
            Tick();
            Console.WriteLine("Du har tyvärr för lite pengar!");
            Console.WriteLine("Skaffa mer pengar genom att leka med din tamagochi");
            Console.ReadLine();
        }
        else if (shop.money >= 0) //Om man har mer än 0 så kan man köpa en frukt och pengarna minskar med 10 
        {
        shop.money -= 10;
        shop.fruit += 1;
        Tick();
        }
    }

    // public void Fruit()
    // {
    //     money -= 10;
    //     fruit += 1;
    // }

//     public void Cake()
//     {
//         money -= 20;
//     }
}







