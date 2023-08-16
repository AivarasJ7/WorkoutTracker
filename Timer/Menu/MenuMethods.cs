namespace Project1
{
    public class MenuMethods
    {
        public static void NewFile()
        {
            Console.WriteLine("Enter text and press Ctrl+Z followed by Enter to save:");

            string content = Console.ReadLine();

            Console.WriteLine("Enter a filename:");
            string fileName = Console.ReadLine();

            File.WriteAllText(fileName, content);

            Console.WriteLine("File saved successfully!");
        }

        public static void LoadFile()
        {
            Console.WriteLine("Enter the filename to load:");

            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine("File content:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        public static void EditFile()
        {
            Console.WriteLine("Enter the filename to edit:");

            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine("File content:");
                Console.WriteLine(content);

                Console.WriteLine("Enter new text and press Ctrl+Z followed by Enter to save:");

                string newContent = Console.ReadLine();

                File.WriteAllText(fileName, newContent);

                Console.WriteLine("File edited and saved successfully!");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
