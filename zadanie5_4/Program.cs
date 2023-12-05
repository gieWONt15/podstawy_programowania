namespace zadanie5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random random = new Random();

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    array[row, col] = random.Next(10);
                }
            }
            Console.WriteLine("Wygenerowana tablica 5x5");
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write(array[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(array.ToString());

            int mainDiagonalSum = 0;
            for (int i = 0; i < 5; i++)
            {
                mainDiagonalSum += array[i, i];
            }
            int secondDiagonalSum = 0;
            for (int i = 0; i < 5; i++)
            {
                secondDiagonalSum += array[i, 4 - i];
            }

            Console.WriteLine($"Suma elementów na głównej przekątnej: {mainDiagonalSum}");
            Console.WriteLine($"Suma elementów na drugiej przekątnej: {secondDiagonalSum}");
        }
    }
}
