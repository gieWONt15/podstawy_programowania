namespace zadanie3_8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę, której wartość bezwzględna zawiera się w przedziale 2 < |x| < 3");
        double x;
        do
        {

            x = double.Parse(Console.ReadLine());
        } while (Math.Abs(x) < 2 || Math.Abs(x) > 3);
        Console.WriteLine($"Podano poprawną liczbę!");
        Console.ReadKey();
    }
}

