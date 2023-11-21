namespace zadanie4_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wprowadź liczbę wierszy (od 9 do 15 nieparzystą)");
        int x = int.Parse(Console.ReadLine());
        while (x < 9 | x > 15 | x % 2 == 0)
        {
            Console.WriteLine("Podaj poprawną liczbę nieparzystą w zakresie od 9 do 15");
            x = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= x; j++)
            {
                if (j >= 2 & j <= x - 1 & i >= 2 & i <= x - 1 & ((x - 1) / 2 != i - 1) & ((x - 1) / 2 != j - 1))
                {
                    Console.Write("   ");
                }
                else
                {
                    Console.Write(" * ");
                }
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

