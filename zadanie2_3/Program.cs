namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Podaj a");
            a = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = System.Convert.ToInt32(Console.ReadLine());

            if (a > c && a < b || a < c && a > b)
            {
                Console.WriteLine("Liczba środkowa to: " + a);
            }
            else if (b > a && b < c || b > c && b < a)
            {
                Console.WriteLine("Liczba środkowa to: " + b);
            }
            else if (c > a && c < b || c > b && c < a)
            {
                Console.WriteLine("Liczba środkowa to: " + c);
            }
        }
    }
}