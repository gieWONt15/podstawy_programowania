namespace zadanie7_9;

class Program
{
    static void Main(string[] args)
    {
        double[] doubles = new double[6];
        Random random = new Random();
        for (int i = 0; i < doubles.Length; i++)
        {
            doubles[i] = random.Next(100);
        }
        Console.WriteLine("Wylosowane liczby");
        for (int i = 0; i < doubles.Length; i++)
        {
            Console.Write($"{doubles[i]} ");
        }
        Console.WriteLine($"\n\nŚrednia liczb wynosi: {Average(doubles)}");
        Console.ReadKey();
    }

    static double Average(double[] array)
    {
        double avv = 0;
        for (int i = 0; i < array.Length; i++)
        {
            avv += array[i];
        }
        avv /= 6;
        return avv;
    }
}

