public class Tamagochi
{
    Shop shop = new Shop();
    int hunger = 0;
    int boredom = 0;

    // int money = 0;

    // int fruit = 0;

    // string Tårta;
    List<string> words = new() {"cheeeese"};
    bool isAlive = true;

    Random generator  = new Random();

    public string name;

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words || Money: {shop.money}Kr || Food: {shop.fruit}");
    }

    public void Feed()
    {
        if (shop.fruit <= 0)
        {
            Console.WriteLine("Du har ingen mat kvar!");
            Console.WriteLine("Köp mer i affären");
            Console.ReadLine();
            Tick();
        }
        else if (shop.fruit >= 0)
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

    private void ReduceBoredom()
    {
        boredom -= 10;
        shop.money += 10;

    }
        public void Tick()
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
    public void TeachWord(string word)
    {
        words.Add (word);
       ReduceBoredom();
        return;
    }
    public void Hello()
    {
        int wordNr = generator.Next(words.Count);
        Console.WriteLine($" {name} says: {words[wordNr]}");
        ReduceBoredom();
    }
    public void BuyFruit()
    {
        if (shop.money <= 0)
        {
            Tick();
            Console.WriteLine("Du har tyvärr för lite pengar!");
            Console.WriteLine("Skaffa mer pengar genom att leka med din tamagochi");
            Console.ReadLine();
        }
        else if (shop.money >= 0)
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







