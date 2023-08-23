namespace Menu.Tests
{
    [TestClass]
    public class MenuMethodsTests
    {
        [TestMethod]
        public void EnterWorkoutData_ValidInput_Success()
        {
            // Arrange
            using (StringReader reader = new StringReader("ExerciseName\n39.4(12)"))
            {
                Console.SetIn(reader);

                // Act
                Project1.MenuMethods.EnterWorkoutData("LegsShoulders.txt");

                // Assert
                string[] lines = File.ReadAllLines("LegsShoulders.txt");
                Assert.AreEqual(1, lines.Length);
                Assert.AreEqual("ExerciseName|39.4(12)", lines[0]);
            }
        }

        [TestMethod]
        public void EnterWorkoutData_InvalidDataFormat_Failure()
        {
            // Arrange
            using (StringReader reader = new StringReader("ExerciseName\nInvalidDataFormat"))
            {
                Console.SetIn(reader);

                // Act
                Project1.MenuMethods.EnterWorkoutData("PullDay.txt");

                // Assert
                string[] lines = File.ReadAllLines("PullDay.txt");
                Assert.AreEqual(0, lines.Length);
            }
        }

        [TestMethod]
        public void LoadWorkoutDay_FileExists_DisplayData()
        {
            // Arrange
            using (StreamWriter writer = File.AppendText("PushDay.txt"))
            {
                writer.WriteLine("Exercise1|39.4(10)");
                writer.WriteLine("Exercise2|50(8)");
            }

            using (StringWriter consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);

                // Act
                Project1.MenuMethods.LoadWorkoutDay("PushDay.txt");

                // Assert
                string expectedOutput = "Exercise1|39.4(10)" + Environment.NewLine +
                                        "Exercise2|50(8)" + Environment.NewLine;
                Assert.AreEqual(expectedOutput, consoleOutput.ToString());
            }
        }
    }
}