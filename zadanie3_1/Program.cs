namespace zadanie3_1;

class Program
{
    static void Main(string[] args)
    {
        int suma = 0;
        int iterator = 0;
        while (suma <= 100)
        {
            Console.WriteLine("Podaj liczbę");
            suma += Convert.ToInt32(Console.ReadLine());
            iterator++;
        }
        Console.WriteLine("Ilość liczb dodanych: " + iterator);
        Console.ReadLine();
    }
}

