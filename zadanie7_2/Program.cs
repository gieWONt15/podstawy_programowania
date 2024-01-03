namespace zadanie7_2;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine($"Suma liczb od 1 do {i}: {SumUp(i)}");
        }
    }

    static int SumUp(int num)
    {
        int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += i;
        }
        return sum;
    }
}
