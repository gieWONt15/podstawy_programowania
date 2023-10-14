namespace zadanie2_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę od 1 do 999");
        int num = Convert.ToInt32(Console.ReadLine());

        int setki = num / 100;
        num -= setki * 100;
        int dziesiatki = num / 10;
        num -= dziesiatki * 10;

        int jednosci = num;

        int sumaCyfr = setki + dziesiatki + jednosci;

        if (sumaCyfr % 3 == 0)
        {
            Console.WriteLine("Liczba jest podzielna przez 3.");
        }
        else
        {
            Console.WriteLine("Liczba nie jest podzielna przez 3.");
        }
    }
}

