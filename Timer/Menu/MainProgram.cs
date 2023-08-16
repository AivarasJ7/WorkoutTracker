namespace Project1
{
    internal class MainProgram
    {
        public static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. 5-Minute Countdown");
                Console.WriteLine("2. New File");
                Console.WriteLine("3. Load File");
                Console.WriteLine("4. Edit File");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Timer.Countdown(5);
                        break;
                    case "2":
                        MenuMethods.NewFile();
                        break;
                    case "3":
                        MenuMethods.LoadFile();
                        break;
                    case "4":
                        MenuMethods.EditFile();
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