namespace Timer
{
    public class TimerMethod
    {
        public static void Countdown(int minutes)
        {
            int countdownSeconds = minutes * 60;

            while (countdownSeconds > 0)
            {
                Console.Clear();
                Console.WriteLine($"Time remaining: {TimeSpan.FromSeconds(countdownSeconds):mm\\:ss}");
                Thread.Sleep(1000); // Wait for 1 second
                countdownSeconds--;
            }

            Console.Clear();
        }
    }
}
