namespace zadanie6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] t1 = { "KlAB-2021-12-25-klej", "FaZXXX-2022-11-23-farba", "TaBEWYT-2023-01-13-tapeta" };
            string t2;
            string t3 = "";

            for (int i = 0; i < 3; i++)
            {
                t2 = t1[i].Substring(t1[i].IndexOf("-") + 1, 10);
                t3 = string.Concat(t2.Substring(8, 2), "-", t2.Substring(5, 2), "-", t2.Substring(0, 4));
                Console.Write($"{t1[i]} -> {t3}\n");
            }
            Console.ReadKey();
        }
    }
}
