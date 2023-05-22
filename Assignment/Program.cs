namespace Assignment
{

    public static class ArrayReplicator
    {
        
        public static int[] ReplicateArray(int[] original)
        {
            int size = original.Length;
            int[] copyArray = new int[size];
            // LINQ -> map
            for (int i = 0; i < size; ++i)
            {
                copyArray[i] = original[i];
            }
            return copyArray;
        }

        
        public static int AskForNumber(string text)
        {
            Console.Write(text);
            string userInput = Console.ReadLine()!; // Needs work -> try/catch + loop or Int.TryParse + loop
            int number = Convert.ToInt32(userInput);
            return number;
        }

        
        public static int AskForNumber(string text, int min, int max)
        {
            int userInput = AskForNumber(text);
            // While the user input is outside the expected range
            while (userInput < min || userInput > max)
            {
                userInput = AskForNumber("Your previous input is not valid, try again.");
            }
            return userInput;
        }
    }

    static class Program
    {
        static void Main()
        {
            const int Min = 0;
            const int Max = 10;
            const int PrintOffset = 4;

            int size = ArrayReplicator.AskForNumber("Enter the array size: ", Min, Max);
            int[] original = new int[size];

            // Fill the original array with user specified integers
            for (int item = 0; item < size; ++item)
            {
                original[item] = ArrayReplicator.AskForNumber("Enter a number: ");
            }

            int[] copy = ArrayReplicator.ReplicateArray(original);
            // Verify original and replicated array are the same
            for (int index = 0; index < size; ++index)
                Console.WriteLine($"Original {original[index],-PrintOffset}  {copy[index],4} Copy");
        }
    }
}
