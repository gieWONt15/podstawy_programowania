namespace zadanie5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 5];
            Random random = new Random();

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    array[row, col] = random.Next(10);
                }
            }
            Console.WriteLine("Tablica 3x5");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write($"{array[row, col]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Transpozycja tablica 5x3");
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
