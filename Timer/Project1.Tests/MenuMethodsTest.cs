namespace Project1.Tests
{
    [TestClass]
    public class TimerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Mock the console output
                var expectedOutput = new StringWriter();
                Console.SetOut(expectedOutput);

                // Act
                var countdownTask = Task.Run(() => Timer.Countdown(5)); // Testing 5-minute countdown

                // Assert
                string expectedOutputString = "Starting 5-minute countdown..." + Environment.NewLine;
                for (int i = 5 * 60; i > 0; i--)
                {
                    TimeSpan timeRemaining = TimeSpan.FromSeconds(i);
                    expectedOutputString += $"Time remaining: {timeRemaining.Minutes:D2}:{timeRemaining.Seconds:D2}" + Environment.NewLine;
                }
                expectedOutputString += "Countdown complete!" + Environment.NewLine;

                Assert.AreEqual(expectedOutputString, sw.ToString());
            }
        }
    }
}