namespace zadanie7_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Liczby bliźniacze w przedziale <200, 400>");
        for (int i = 200; i <= 400; i++)
        {
            if (CzyBliźniacze(i, i+2))
            {
                Console.WriteLine($"{i} i {i+2}");
            }
        }
        Console.ReadKey();
    }

    static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static bool CzyBliźniacze(int liczba1, int liczba2)
    {
        return CzyLiczbaPierwsza(liczba1) && CzyLiczbaPierwsza(liczba2);
    }
}

