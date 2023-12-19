namespace zadanie6_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszy tekst");
            string text1 = Console.ReadLine();
            Console.WriteLine("Podaj drugi tekst");
            string text2 = Console.ReadLine();

            if (text1.Length != text2.Length)
            {
                Console.WriteLine("Teksty nie są tej samej długości");
                return;
            }
            string result = "";
            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i] == text2[i])
                {
                    result += text1[i];
                }
                else
                {
                    result += "?";
                }
            }
            Console.WriteLine($"\nWynik porównania to: {result}");
        }
    }
}
