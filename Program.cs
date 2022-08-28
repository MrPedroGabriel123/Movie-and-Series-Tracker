namespace SeriesTracker;

internal static class Track
{
    public static void Main()
    {
        // user instantiation 
        var userList = new List<User>();
        var user = new User();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Welcome to Movie Time, Here you can track of everything you see or have seen!");
        Console.ReadKey();
        // Here there should be a reset on screen using Console.Clear();
        Console.Clear();

        // Menu below
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Movie Time = Active Sub");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1) Create a new Profile (Up to 4) ");
            Console.WriteLine("2) Choose what profile you want to enter");
            Console.WriteLine("3) Enter your profile");
            var choice = "Enter choice".PromptInt(minValue: 1, maxValue: 3);
            // Menu code up

            // Second menu for each Choice
            switch (choice)
            {
                // Account management
                case 1:
                    Console.Clear();
                    Console.WriteLine("1) Create a new profile");
                    Console.WriteLine("2) Delete a Profile");
                    choice = "Enter choice".PromptInt(minValue: 1, maxValue: 2);
                    switch (choice)
                    {
                        case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("What will be name of account");

                            // Check if the user already exists.

                            var userInput = Console.ReadLine();
                            
                            user.Name = userInput;

                            userList.Add(user);
                            // Gather more information

                            Console.WriteLine($"{userInput} created");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        case 2:
                            Console.WriteLine("Which of the accounts you want to delete?");
                            
                            foreach (var userInput in userList)
                            {
                                Console.WriteLine($"{userList}");
                            }
                            break;
                    }

                    // Needs a better place for this code...

                    // Once you've done everything with the account you could populate it into the list.
                     // userList.Add(user);
                    //  Fetching the user
                     // var fetchedUser =
                      //  userList.FirstOrDefault(x => x.Name == "John"); // Replace "John" with accepted input
                    // This will throw null reference exception since we never populated "Game of Thrones" into John.
                      // Console.WriteLine(fetchedUser.Shows.FirstOrDefault(x => x.Name == "Game of Thrones"));

                    break;
            }
        }
    }
}
