namespace zadanie5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 6];
            Random random = new Random();

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 6; col++) 
                {
                    array[row, col] = random.Next(100);
                }
            }
            for (int row = 0;row < 5; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    Console.Write($"{array[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Liczby parzyste: ");

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    if ((array[row, col] % 2 == 0) && array[row, col] != 0)
                    {
                        Console.Write($"{array[row, col]} ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
