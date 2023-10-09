namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;
            Console.WriteLine("Podaj liczbę nr 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr 3");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num2 > num3 && num2 > num1) 
            {
                max = num2;
            } 
            else
            {
                max = num3;
            }
            Console.WriteLine(max + " jest największą liczbą z podanych.");
        }
    }
}
