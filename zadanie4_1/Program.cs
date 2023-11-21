namespace zadanie4_1;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;

        for (int i = 0; i <= 10; i++)
        {
            for (int j = 0; j <= 5; j++)
            {
                for (int k = 0; k <= 2; k++)
                {
                    if ((i + (j * 2) + (k * 5)) == 10)
                    {
                        x++;
                        Console.WriteLine($"Kombinacja: {i} jednozłotówek, {j} dwuzłotówek, {k} pięciozłotówek");
                    }
                }
            }
        }
        Console.WriteLine($"Liczba kombinacji: {x}");
        Console.ReadLine();
    }
}

