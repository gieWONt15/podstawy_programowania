namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę nr 1: ");
            int int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr 2: ");
            int int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr 3: ");
            int int3 = int.Parse(Console.ReadLine());
            string statement = " jest największą liczbą z podanego zestawu.";

            if (int1>int2)
            {
                if (int3>int1)
                {
                    Console.WriteLine("Liczba " + int3 + statement);
                } 
                else
                {
                    Console.WriteLine("Liczba " + int1 + statement);
                }
            }
            else
            {
                if(int3>int2) 
                {
                    Console.WriteLine("Liczba " + int3 + statement);
                }
                else
                {
                    Console.WriteLine("Liczba " + int2 + statement);
                }
            }
        }
    }
}