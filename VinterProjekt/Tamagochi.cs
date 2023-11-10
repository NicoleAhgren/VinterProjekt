public class Tamagochi
{
    int hunger = 0;
    int boredom = 0;
    List<string> words = new() {"cheeeese"};
    bool isAlive = true;

    Random generator  = new Random();

    public string name;

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");
    }

    public void Feed()
    {
        hunger -= 10;
        Console.WriteLine($"Hunger = {hunger}" );
    }
    public bool GetAlive()
        {
            return isAlive;
        }

    private void ReduceBoredom()
    {
        boredom -= 10;
    }
        public void Tick()
    {
        boredom += generator.Next(5);
        hunger += generator.Next(7);
        if (boredom >= 100 || hunger >= 100)
        {
            isAlive = false;
        }
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
}







