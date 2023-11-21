namespace zadanie4_6;

class Program
{
    static void Main(string[] args)
    {
        int liczba = 1;

        while (liczba <= 10000)
        {
            int sum = 0;
            int j = 1;

            while (j <= liczba /2)
            {
                if (liczba % j == 0)
                {
                    sum += j;
                }
                j++;
            }
            if (sum == liczba)
            {
                Console.WriteLine(liczba);
            }
            liczba++;
        }
        Console.ReadLine();
    }
}

