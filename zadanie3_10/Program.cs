namespace zadanie3_10;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int wylosowanaLiczba = rand.Next(1, 1001);
        int zgadywanaLiczba;
        int liczbaProb = 0;
        bool odgadniete = false;

        Console.WriteLine("Witaj w grze Zgadywanka!");
        Console.WriteLine("Spróbuj odgadnąć losową liczbę z przedziału od 1 do 1000.");

        do
        {
            Console.Write("Podaj swoją próbę: ");
            zgadywanaLiczba = int.Parse(Console.ReadLine());
            liczbaProb++;

            if (zgadywanaLiczba < wylosowanaLiczba)
            {
                Console.WriteLine("Podana liczba jest za mała. Spróbuj jeszcze raz.");
            }
            else if (zgadywanaLiczba > wylosowanaLiczba)
            {
                Console.WriteLine("Podana liczba jest za duża. Spróbuj jeszcze raz.");
            }
            else
            {
                odgadniete = true;
                Console.WriteLine($"Brawo! Odgadłeś liczbę {wylosowanaLiczba} w {liczbaProb} próbach.");
            }
        } while (!odgadniete);
        Console.ReadLine();
    }
}

