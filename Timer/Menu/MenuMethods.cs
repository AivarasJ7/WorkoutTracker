namespace Project1
{
    public class MenuMethods
    {
        public static void WorkoutMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Workout Tracker Menu:");
                Console.WriteLine("1. Legs and Shoulders Day");
                Console.WriteLine("2. Pull Day");
                Console.WriteLine("3. Push Day");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Select a workout day or option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        EnterWorkoutData("LegsShoulders.txt");
                        break;
                    case "2":
                        EnterWorkoutData("PullDay.txt");
                        break;
                    case "3":
                        EnterWorkoutData("PushDay.txt");
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        public static void EnterWorkoutData(string fileName)
        {
            Console.WriteLine($"Enter exercise name:");
            string exercise = Console.ReadLine();

            Console.WriteLine($"Enter weight, reps, and sets (e.g., 39.4(12) 39.4(10.5) 39.4(9.5)):");
            string data = Console.ReadLine();

            using (StreamWriter writer = File.AppendText(fileName))
            {
                writer.WriteLine($"{exercise}|{data}");
            }

            Console.WriteLine("Workout data added successfully!");
        }

        public static void LoadWorkoutDay()
        {
            Console.WriteLine("Choose a workout day to load:");
            Console.WriteLine("1. Legs and Shoulders Day");
            Console.WriteLine("2. Pull Day");
            Console.WriteLine("3. Push Day");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();
            string fileName = "";

            switch (input)
            {
                case "1":
                    fileName = "LegsShoulders.txt";
                    break;
                case "2":
                    fileName = "PullDay.txt";
                    break;
                case "3":
                    fileName = "PushDay.txt";
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid workout day.");
                    return;
            }

            if (File.Exists(fileName))
            {
                Console.WriteLine($"Workout Data for {fileName}:");
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Workout day file not found.");
            }
        }
    }
}
