using System;
namespace zd7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array:");
            PrintArray(arr);

            Shuffle(arr);

            Console.WriteLine("\nShuffled array:");
            PrintArray(arr);

            Console.ReadLine();
        }

        static void Shuffle<T>(T[] array)
        {
            var random = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        static void PrintArray<T>(T[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}

