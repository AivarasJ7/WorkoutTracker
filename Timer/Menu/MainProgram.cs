namespace Project1
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. 5-Minute Countdown");
                Console.WriteLine("2. Load Tracked info");
                Console.WriteLine("3. Add new Exercise");
                Console.WriteLine("4. Clear chosen day");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Timer.Countdown(5);
                        break;
                    case "2":
                        Console.WriteLine("Choose a workout day to load:");
                        Console.WriteLine("1. Legs and Shoulders Day");
                        Console.WriteLine("2. Pull Day");
                        Console.WriteLine("3. Push Day");
                        Console.Write("Select an option: ");

                        string loadInput = Console.ReadLine();
                        string loadFileName = "";

                        switch (loadInput)
                        {
                            case "1":
                                loadFileName = "LegsShoulders.txt";
                                break;
                            case "2":
                                loadFileName = "PullDay.txt";
                                break;
                            case "3":
                                loadFileName = "PushDay.txt";
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please select a valid workout day.");
                                continue;
                        }

                        MenuMethods.LoadWorkoutDay(loadFileName);
                        break;
                    case "3":
                        MenuMethods.WorkoutMenu();
                        break;
                    case "4":
                        Console.WriteLine("Choose a workout day to clear:");
                        Console.WriteLine("1. Legs and Shoulders Day");
                        Console.WriteLine("2. Pull Day");
                        Console.WriteLine("3. Push Day");
                        Console.Write("Select an option: ");

                        string clearInput = Console.ReadLine();
                        string clearFileName = "";

                        switch (clearInput)
                        {
                            case "1":
                                clearFileName = "LegsShoulders.txt";
                                break;
                            case "2":
                                clearFileName = "PullDay.txt";
                                break;
                            case "3":
                                clearFileName = "PushDay.txt";
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please select a valid workout day.");
                                continue;
                        }

                        MenuMethods.ClearWorkoutDay(clearFileName);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}