namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współczynnik a różny od zera: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik b różny od zera: ");
            double b = double.Parse(Console.ReadLine());    
            Console.WriteLine("Podaj współczynnik c różny od zera: ");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            
            if (delta > 0) 
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Pierwiastki tego trójmianu kwadratowego to: ");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (delta == 0) 
            {
                double x = -b / (2 * a);
                Console.WriteLine("Trójmian kwadratowy ma jeden pierwiastek podwójny: ");
                Console.WriteLine("x = " + x);
            }
            else
            {
                Console.WriteLine("Trójmian kwadratowy nie ma pierwiastków rzeczywistych.");
            }
        }
    }
}