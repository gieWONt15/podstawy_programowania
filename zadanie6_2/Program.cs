namespace zadanie6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string t1 = "Cyryl Kwiecień\nul. Mokra 1/9\nTychy 43-100\n";
            string t2 = "";

            Console.WriteLine(t1);
            for (int i = 0; i < t1.Length; i++)
            {
                if (t1[i] != '\n')
                {
                    t2 += t1[i];
                }
                else
                {
                    t2 += " ";
                }
            }
            Console.WriteLine(t2);

            Console.ReadKey();
        }
    }
}
