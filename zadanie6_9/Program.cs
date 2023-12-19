namespace zadanie6_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst");
            string tekst = Console.ReadLine();
            Console.WriteLine("Wypisywanie liter:");
            for (int i = 0; i < tekst.Length; i++)
            {
                Console.Write(tekst[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
