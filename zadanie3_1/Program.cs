namespace zadanie3_1;

class Program
{
    static void Main(string[] args)
    {
        int suma = 0;
        int iterator = 0;
        while (suma <= 100)
        {
            iterator++;
            suma += iterator;
        }
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Ilość liczb dodanych: " + iterator);
    }
}

