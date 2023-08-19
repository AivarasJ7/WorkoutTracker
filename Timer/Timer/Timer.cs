namespace Project1
{
    public class Timer
    {
        public static void Countdown(int minutes)
        {
            Console.WriteLine("Starting 5-minute countdown...");

            for (int i = 5 * 60; i > 0; i--)
            {
                TimeSpan timeRemaining = TimeSpan.FromSeconds(i);
                Console.WriteLine($"Time remaining: {timeRemaining.Minutes:D2}:{timeRemaining.Seconds:D2}");
                Thread.Sleep(1000); // Wait for 1 second
            }

            Console.WriteLine("Countdown complete!");
        }
    }
}
