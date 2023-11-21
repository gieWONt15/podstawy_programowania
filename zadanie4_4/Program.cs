namespace zadanie4_4;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 100; i++)
        {
            bool isPrime1 = true;
            bool isPrime2 = true;

            for (int j = 2; j <= Math.Sqrt(i) || j <= Math.Sqrt(i + 2); j++)
            {
                if (i % j == 0 && j <= Math.Sqrt(i))
                {
                    isPrime1 = false;
                }
                if ((i + 2) % j == 0 && j <=Math.Sqrt(i + 2))
                {
                    isPrime2 = false;
                }

                if (!isPrime1 && !isPrime2)
                {
                    break;
                }
            }
            if (isPrime1 && isPrime2)
            {
                Console.WriteLine($"({i}, {i + 2})");
            }
        }
        Console.ReadLine();
    }
}

