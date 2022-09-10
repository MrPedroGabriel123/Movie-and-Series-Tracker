using System.Text.Json;

namespace SeriesTracker;

internal static class Track
{
    public static void Main()
    {
        // user instantiation 
        var userList = HandleList();

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
            Console.WriteLine("3) Exit");
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
                            var name = Console.ReadLine();
                            var userExists = userList.Exists(x => x.Name == name);
                            if (userExists)
                            {
                                Console.WriteLine("User already exists");
                                Console.ReadKey();
                                break;
                            }

                            var user = new User
                            {
                                Name = name
                            };

                            userList.Add(user);
                            HandleList(userList);
                            // Gather more information

                            Console.WriteLine($"{user.Name} created");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        case 2:
                            if (!userList.Any())
                            {
                                Console.Write("There are non accounts created");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                            Console.WriteLine("Which of the accounts you want to delete?");
                            Console.WriteLine(
                                $"Users ({userList.Count}): {string.Join(", ", userList.Select(x => x.Name))}");
                            var userInput = Console.ReadLine();

                            var userObj = userList.FirstOrDefault(x => x.Name == userInput);

                            if (userObj is null)
                            {
                                Console.WriteLine("User not found");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                            userList.Remove(userObj);
                            HandleList(userList);

                            Console.Clear();
                            break;
                    }

                    break;

                case 2:
                    Console.Write("Which profile do you want to enter");
                    Console.WriteLine($"Users ({userList.Count}): {string.Join(", ", userList.Select(x => x.Name))}");
                    var userChoice = Console.ReadLine();
                    var userobj2 = userList.FirstOrDefault(x => x.Name == userChoice);
                    if (userobj2 is null)
                    {
                        Console.WriteLine("User not found");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                    Console.Clear();
                    Console.WriteLine($"Welcome {userChoice}");
                    Console.ReadKey();
                    Console.WriteLine("Would you like to add or remove a film from your list?");
                    Console.WriteLine("1) Add a film");
                    Console.WriteLine("2) Remove a film");
                    Console.WriteLine("3) Return to main menu");
                    var choice2 = "Enter choice".PromptInt(minValue: 1, maxValue: 3);
                    switch (choice2)
                    {
                        case 1:
                        {
                            
                            Console.WriteLine("What film would you like to add?");
                            var show = Console.ReadLine();
                            var showExists = userobj2.Shows.Exists(x => x.Name == show);
                            if (showExists)
                            {
                                Console.WriteLine("Show already exists");
                                Console.ReadKey();
                                break;
                            }
                            var shows = new Shows
                            {
                                Name = show
                            };
                            userobj2.Shows.Add(shows);
                            HandleList(userList);
                            Console.WriteLine($"{shows.Name} added");
                            Console.ReadKey();
                            Console.Clear();

                           
                            
                            

                            break;
                        }
                    }

                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }

//other stuff 
    private static List<User> HandleList(List<User>? userList = null)
    {
        if (userList == null)
        {
            userList = new List<User>();
            if (!File.Exists("accounts.json")) return userList;
            var file = File.ReadAllText("accounts.json");
            return JsonSerializer.Deserialize<List<User>>(file) ?? userList;
        }


        var json = JsonSerializer.Serialize(userList, new JsonSerializerOptions {WriteIndented = true});
        File.WriteAllText("accounts.json", json);
        return userList;
    }
}