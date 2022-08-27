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
        ///Menu code
    }
}
