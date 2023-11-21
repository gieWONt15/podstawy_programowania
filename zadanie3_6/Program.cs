namespace zadanie3_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę wyrazów ciągu Fibonacciego: ");
        int max = Convert.ToInt32(Console.ReadLine());
        int n, f1, f2, suma = 0;

        if (max == 0)
        {
            Console.WriteLine(0);
        }
        else if (max == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            f1 = 1; f2 = 0;
            for (int i = 2; i <= max; i++)
            {
                suma = f1 + f2;
                f2 = f1;
                f1 = suma;
            }
        }

        Console.WriteLine($"Suma wynosi: {suma}");
        Console.ReadLine();
    }
}