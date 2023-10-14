namespace zadanie2_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj wiek ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18 && age <= 30)
        {
            switch (age)
            {
                case 18:
                    Console.WriteLine("Jesteś pełnoletni, masz 18 lat.");
                    break;

                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                    Console.WriteLine("Jesteś w przedziale wiekowym 19-25 lat");
                    break;

                default:
                    Console.WriteLine("Masz ponad 25 lat, ale jeszcze przez 'trzydziestką'");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Jesteś poza przedziałem wiekowym 18-30");
        }
    }
}

