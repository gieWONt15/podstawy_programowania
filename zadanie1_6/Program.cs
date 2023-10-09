namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            double result2;
            result2 = 6.2 / 0.31;
            result2 -= 5.0 / 6.0 * 0.9;
            result2 *= 0.2;
            result2 += 0.15;
            result2 /= 0.02;
            result2 *= result2 * result2;
            Console.WriteLine(result2);
        }
    }
}