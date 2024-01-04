namespace zadanie7_5;

class Program
{
    static void Main(string[] args)
    {
        wywolanieMetod();
        Console.ReadKey();
    }

    static double obliczPole(double promien)
    {
        return Math.PI * promien * promien;
    }

    static double obliczPole(double a, double b)
    {
        return a * b;
    }

    static double wynikDzielenia(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            throw new Exception("Dzielenie przez 0");
        }
    }

    static int wynikDzielenia(int a, int b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            throw new Exception("Dzielenie przez 0");
        }
    }
    static void wywolanieMetod()
    {
        Console.WriteLine($"Pole koła o promieniu 5 = {obliczPole(5.0)}");
        Console.WriteLine($"Pole prostokąta o bokach 7 i 4 = {obliczPole(7.0, 4.0)}");
        Console.WriteLine($"Wynik dzielenia zmiennoprzecinkowego 12 przez 5 = {wynikDzielenia(12.0, 5.0)}");
        Console.WriteLine($"Wynik dzielenia stałoprzecinkowego 12 przez 5 = {wynikDzielenia(12, 5)}");
    }
}

