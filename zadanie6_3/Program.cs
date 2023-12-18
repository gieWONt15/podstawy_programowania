namespace zadanie6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst zawierający wielokrotnie występujące spacje");
            string tekst = Console.ReadLine();

            for (int i = 0; i < tekst.Length-1; i++)
            {
                if (tekst[i] == ' ' && tekst[i + 1] == ' ')
                {
                    tekst = tekst.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(tekst);

            Console.ReadKey();
        }
    }
}
