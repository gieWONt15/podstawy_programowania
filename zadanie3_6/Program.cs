namespace zadanie3_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę wyrazów ciągu Fibonacciego: ");
        int max = Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 1, suma = 0;

        for (int i = 0; i < max; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
            suma += b;
            Console.WriteLine(b);
        }
        Console.WriteLine($"Suma wynosi: {suma}");
        Console.ReadLine();
    }
}