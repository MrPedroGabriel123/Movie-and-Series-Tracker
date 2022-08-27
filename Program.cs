namespace Tracker;

internal static class Track
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Welcome to Movie Time, Here you can track of everything you see or have seen!");
        Console.ReadKey();
        ///Here there should be a reset on screen using Console.Clear();
        Console.Clear();
        
        /////Menu below
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Movie Time = Active Sub");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("1) Create a new Profile (Up to 4) ");
        Console.WriteLine("2) Choose what profile you want to enter");
        Console.WriteLine("3) Enter your profile");
        var userFirstChoice = "Enter choice".PromptInt(minValue: 1, maxValue: 3);
        ///Menu code up

        ///Second menu for each Choice
        switch (userFirstChoice)
        {
            ///Account managemnt
            case 1:
                Console.Clear();
                Console.WriteLine("1) Create a new profile");
                Console.WriteLine("2) Delete a Profile");
                var userSecondChoice = "Enter choice".PromptInt(minValue: 1, maxValue: 2);
                if (userSecondChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("What will be name of account number 1");
                   var Account1 = Console.ReadLine();
                    Console.WriteLine($"Welcome {Account1}");
                }
                break;
               
        }
      
        
    }
}
    