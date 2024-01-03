namespace zadanie7_3;

class Program
{
    static void Main(string[] args)
    {
        
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"2^{i} = {Power(i)}");
        }

        Console.WriteLine();

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{i}! = {Factorial(i)}");
        }
        Console.ReadLine();
    }

    static long Power(long num)
    {
        if (num==0)
        {
            return 1;
        }
        else
        {
            return (long)Math.Pow(2, num);
        }
    }

    static long Factorial(long num)
    {
        if (num==0 || num==1)
        {
            return 1;
        }
        else
        {
            return num * Factorial(num - 1);
        }
    }
}

