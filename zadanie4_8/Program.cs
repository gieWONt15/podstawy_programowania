namespace zadanie4_8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę: ");
        int liczba = Convert.ToInt32(Console.ReadLine());

        double suma = 0;
        double liczba_nieparzysta = 0;

        double i = 1;
        double j = 1;

        do
        {
            do
            {
                if (j % 2 != 0)
                {
                    suma += j;
                    liczba_nieparzysta++;
                }
                j++;
            } while (j <= liczba);
            i++;
        } while (i <= liczba);

        double srednia = suma / liczba_nieparzysta;
        Console.WriteLine("Średnia arytmetyczna liczb nieparzystych to: " + srednia);
        Console.ReadLine();
    }
}

