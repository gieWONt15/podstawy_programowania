namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę całkowitą dodatnią");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wybierz operację arytmetyczną: +, -, *, /, ^, %");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę całkowitą dodatnią");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double wynik;
            switch (operation)
            {
                case '+':
                    wynik = num1 + num2;
                    Console.WriteLine("Wynik dodawania: " + wynik);
                    break;

                case '-':
                    wynik = num1 - num2;
                    Console.WriteLine("Wynik odejmowania: " + wynik);
                    break;

                case '*':
                    wynik = num1 * num2;
                    Console.WriteLine("Wynik mnożenia: " + wynik);
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        wynik = num1 / num2;
                        Console.WriteLine("Wynik dzielenia: " + wynik);
                    }
                    else
                    {
                        Console.WriteLine("Nie dzielimy przez zero");
                    }
                    break;

                case '^':
                    wynik = Math.Pow(num1, num2);
                    Console.WriteLine("Wynik potęgowania: " + wynik);
                    break;

                case '%':
                    wynik = num1 % num2;
                    Console.WriteLine("Wynik dzielenia modulo: " + wynik);
                    break;

                default:
                    Console.WriteLine("Nie ma takiej operacji arytmetycznej");
                    break;
            }
        }
    }
}