namespace zadanie6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst");
            string tekst = Console.ReadLine();
            int words = 0;
            for (int i = 0; i < tekst.Length-1; i++)
            {
                if (tekst[i] == ' ')
                {
                    words++;
                }
            }
            words++;
            Console.WriteLine("Ilość słów: " + words);

            Console.ReadKey();
        }
    }
}
