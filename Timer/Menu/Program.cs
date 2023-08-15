namespace Menu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. 5-Minute Countdown");
                Console.WriteLine("2. Option 2");
                Console.WriteLine("3. Option 3");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Timer.Countdown(5); // neveikia need fix
                        break;
                    case "2":
                        Console.WriteLine("You selected Option 2.");
                        break;
                    case "3":
                        Console.WriteLine("You selected Option 3.");
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
    }
}