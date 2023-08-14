namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Console Menu App!");
                Console.WriteLine("1. Option 1");
                Console.WriteLine("2. Option 2");
                Console.WriteLine("3. Option 3");
                Console.WriteLine("4. Exit");
                Console.Write("Please select an option: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            MenuMethods.Option1();
                            break;
                        case 2:
                            MenuMethods.Option2();
                            break;
                        case 3:
                            MenuMethods.Option3(); ;
                            break;
                        case 4:
                            exit = true;
                            Console.WriteLine("Exiting the program.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }

                    if (!exit)
                    {
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}