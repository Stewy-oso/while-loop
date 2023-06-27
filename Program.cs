namespace for_loop;

class Program
{
    static void Main(string[] args)
    {
        ///Appearance.
        Console.Title = "Other Loop";
        Console.ForegroundColor = ConsoleColor.Red;
        
        Random numberGen = new Random();

        int roll = 0;
        int attempts = 0;

        Console.WriteLine("Press any key to roll the dice.");

        while(roll != 6)
        {
            Console.ReadKey();
            roll = numberGen.Next(1, 7);
            Console.WriteLine("You rolled: " + roll);
            attempts++;
        }

        Console.WriteLine("It took you " + attempts + " attempts to roll a six.");

        Console.ReadKey();
    }
}
