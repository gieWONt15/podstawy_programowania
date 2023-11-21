namespace zadanie3_7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Podaj wykładnik b: ");
        int b = int.Parse(Console.ReadLine());

        int wynik = Potega(a, b);
        Console.WriteLine($"{a} ^ {b} = {wynik}");
        Console.ReadLine();
    }

    static int Potega(int a, int b)
    {
        int wynik = 1;
        int i = 0;

        while (i < b)
        {
            wynik *= a;
            i++;
        }

        return wynik;
    }
}

