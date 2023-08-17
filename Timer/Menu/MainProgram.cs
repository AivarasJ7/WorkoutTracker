﻿namespace Project1
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
                Console.WriteLine("2. Workout Tracker");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Timer.Countdown(5);
                        break;
                    case "2":
                        MenuMethods.WorkoutMenu();
                        break;
                    case "3":
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