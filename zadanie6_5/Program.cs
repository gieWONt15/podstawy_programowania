namespace zadanie6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę osób, dla których chcesz przechowywać dane: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, 2];

            Console.ReadKey();
        }
    }
}
