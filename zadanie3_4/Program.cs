namespace zadanie3_4;

class Program
{
    static void Main(string[] args)
    {
        double mojePi = 0;
        for (int i = 0; i <= 100; i++)
        {
            mojePi += Math.Pow(-1, i) / (2 * i + 1);
        }
        Console.WriteLine(mojePi * 4);
        Console.ReadLine();
    }
}

