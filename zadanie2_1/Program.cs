namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result1 = Math.Pow(Math.Sqrt(2), Math.Sqrt(3));
            double result2 = Math.Pow(Math.Sqrt(3), Math.Sqrt(2));
            if (result1 > result2) 
            {
                Console.WriteLine("Liczbą większą jest pierwiastek z dwóch do potęgi pierwiastek z trzech");
            }
            else if (result1 < result2)
            {
                Console.WriteLine("Liczbą większą jest pierwiastek z trzech do potęgi pierwiastek z dwóch");
            }
            else
            {
                Console.WriteLine("Obie liczby są takie same");
            }
        }
    }
}