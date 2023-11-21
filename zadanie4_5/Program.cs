namespace zadanie4_5;

class Program
{
    static void Main(string[] args)
    {
        int liczba = 100;

        do
        {
            do
            {
                if (liczba % 2 == 0 || liczba % 3 != 0 || liczba % 7 != 0)
                {
                    liczba++;
                    continue;
                }
                Console.WriteLine("Liczba {0} jest nieparzysta i jest podzielna przez 3 i 7 ", liczba);
                liczba++;
            } while (liczba <= 200);
        } while (liczba <= 200);
        Console.ReadLine();
    }
}

