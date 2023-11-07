namespace zadanie3_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę do której będą sumowane ");
        int max = Convert.ToInt32(Console.ReadLine());
        
        int iterator = 1;
        int suma = 0;
        while (iterator <= max)
        {
            suma += iterator;
            iterator++;
        }
        Console.WriteLine("Suma: " + suma);
        Console.ReadLine();
    }
}