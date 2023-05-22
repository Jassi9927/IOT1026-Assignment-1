using System;

namespace Assignment
{
    public static class ArrayReplicator
    {
        public static int[] ReplicateArray(int[] original)
        {
            int size = original.Length;
            int[] copyArray = new int[size];
            for (int i = 0; i < size; ++i)
            {
                copyArray[i] = original[i];
            }
            return copyArray;
        }

        public static int AskForNumber(string text)
        {
            Console.Write(text);
            string userInput = Console.ReadLine();
            int number;
            while (!int.TryParse(userInput, out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write(text);
                userInput = Console.ReadLine();
            }
            return number;
        }

        public static int AskForNumber(string text, int min, int max)
        {
            int userInput = AskForNumber(text);
            while (userInput < min || userInput > max)
            {
                Console.WriteLine($"Input must be between {min} and {max}. Please try again.");
                userInput = AskForNumber(text);
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

            for (int item = 0; item < size; ++item)
            {
                original[item] = ArrayReplicator.AskForNumber("Enter a number: ");
            }

            int[] copy = ArrayReplicator.ReplicateArray(original);

            for (int index = 0; index < size; ++index)
            {
                Console.WriteLine($"Original {original[index],-PrintOffset}  {copy[index],4} Copy");
            }
        }
    }
}
