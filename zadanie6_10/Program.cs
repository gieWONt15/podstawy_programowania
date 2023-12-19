namespace zadanie6_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 5 tekstów");
            string[] texts = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Podaj tekst {i + 1}: ");
                texts[i] = Console.ReadLine();
            }
            string longest = texts[0];
            for (int i = 0; i < 5; i++)
            {
                if (texts[i].Length > longest.Length)
                {
                    longest = texts[i];
                }
            }
            Console.WriteLine($"Najdłuższy tekst to: {longest}");
        }
    }
}
