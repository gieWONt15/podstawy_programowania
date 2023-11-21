internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                if (i + j == 11 | i == j | (i >= 4 & i <= 7 & j >= 4 & j <= 7))
                {
                    Console.Write(" * ");
                }
                else
                {
                    Console.Write("   ");
                }
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}