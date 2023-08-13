namespace Project1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting 5-minute countdown...");
            TimerMethod.Countdown(5);
            Console.WriteLine("Countdown complete!");
        }
    }
}
