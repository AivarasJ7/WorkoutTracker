using System.Text.RegularExpressions;

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

            if (string.IsNullOrWhiteSpace(exercise))
            {
                Console.WriteLine("Exercise name cannot be empty.");
                return;
            }

            if (!Regex.IsMatch(data, @"^(\d+(\.\d+)?)\(\d+\)(\s+\d+(\.\d+)?)?\s*"))
            {
                Console.WriteLine("Invalid data format. Please use the correct format.");
                return;
            }

            using (StreamWriter writer = File.AppendText(fileName))
            {
                writer.WriteLine($"{exercise}|{data}");
            }

            Console.WriteLine("Workout data added successfully!");
        }

        public static void ClearWorkoutDay(string fileName)
        {
            Console.WriteLine($"Clearing workout data for {fileName}. Are you sure? (Y/N)");
            string confirm = Console.ReadLine();

            if (!confirm.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Operation canceled.");
                return;
            }

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine($"Workout data for {fileName} has been cleared.");
            }
            else
            {
                Console.WriteLine($"Workout day file {fileName} not found.");
            }
        }

        public static void LoadWorkoutDay(string fileName)
        {
            Console.WriteLine($"Workout Data for {fileName}:");

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lines.Length == 0)
                {
                    Console.WriteLine("No workout data available.");
                    return;
                }

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length != 2)
                    {
                        Console.WriteLine("Invalid data format in workout file.");
                        return;
                    }

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
