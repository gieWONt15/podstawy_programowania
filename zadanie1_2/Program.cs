namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            double num2 = double.Parse(Console.ReadLine());

            double avg = (num1 + num2) / 2;
            Console.WriteLine("Średnia tych liczb to: " +  avg);
        }
    }
}