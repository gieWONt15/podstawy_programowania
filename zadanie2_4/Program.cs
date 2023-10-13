namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, tmp;
            Console.WriteLine("Podaj a");
            a = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = System.Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            if (b > c)
            {
                tmp = b;
                b = c;
                c = tmp;
            }
            if (a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }

            Console.WriteLine(a + "\t" + b + "\t" + c);
        }
    }
}