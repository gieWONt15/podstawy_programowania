using System.Collections;

namespace zadanie6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string liczbaBinarna;
            int liczbaDziesietna = 0;

            Console.WriteLine("Podaj liczbę binarną max 8 znaków: ");
            liczbaBinarna = Console.ReadLine();
            if (liczbaBinarna.Length > 8)
            {
                Console.WriteLine("Podana liczba jest za długa");
                Console.ReadKey();
                return;
            }
            else
            {
                for (int i = liczbaBinarna.Length - 1; i >= 0; i--)
                {
                    if (liczbaBinarna[i] == '1')
                    {
                        liczbaDziesietna += (int)Math.Pow(2, liczbaBinarna.Length - 1 - i);
                    }
                    
                }
                Console.WriteLine("Liczba dziesiętna to: " + liczbaDziesietna);
            }

            Console.ReadKey();
        }
    }
}
