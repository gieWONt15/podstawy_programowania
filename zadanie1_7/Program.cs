namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wiek: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Jesteś pełnoletni");
            }
            else
            {
                Console.WriteLine("Jesteś niepełnoletni");
            }
        }
    }
}