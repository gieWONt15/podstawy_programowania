using System.Globalization;

namespace zadanie5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica = new int[11, 11];
            for (int i = 0; i <= 10; i++) 
            {
                for (int j = 0; j <= 10; j++)
                {
                    tablica[i, j] = i * j - j * j;
                }
            }

            int minValue = tablica[0, 0];
            int maxValue = tablica[1, 0];

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (tablica[i, j] < minValue)
                    {
                        minValue = tablica[i, j];
                    }
                    if (tablica[i, j] > maxValue)
                    {
                        maxValue = tablica[i, j];
                    }
                }
            }
            Console.WriteLine("Tablica: ");
            for (int row = 0; row < 11; row++)
            {
                for (int col = 0; col < 11; col++)
                {
                    Console.Write($"{tablica[row, col]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Najmniejszy element to: " + minValue);
            Console.WriteLine("Największy element to: " + maxValue);
        }
    }
}
