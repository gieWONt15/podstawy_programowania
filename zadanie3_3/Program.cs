namespace zadanie3_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę: ");
        int max = Convert.ToInt32(Console.ReadLine());

        int suma = 0;
        int iterator = 0;
        while (suma <= max)
        {
            iterator++;
            suma += iterator;
        }
        Console.WriteLine("Potrzeba " + iterator + " iteracji");
        Console.ReadLine();
    }
}

