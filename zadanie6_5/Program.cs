namespace zadanie6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę osób, dla których chcesz przechowywać dane: ");
            
            int n = int.Parse(Console.ReadLine());
            bool pseudo = false;
            int z = 0;
            string[,] array = new string[n, 2];
            while (z < n)
            {
                Console.Write("\nPodaj pseudonim osoby nr " + (z + 1) + ": ");
                array[z, 0] = Console.ReadLine();
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i, 0] == array[z, 0] && i != z)
                    {
                        Console.WriteLine("Podany pseudonim już istnieje.\n");
                        break;
                    }
                }
                Console.Write("\rPodaj numer telefonu dla osoby " + (z + 1) + ": ");
                array[z, 1] = Console.ReadLine();
                z++;
            }
            Console.WriteLine("\nPodaj pseudonim osoby, której numer telefonu chcesz znaleźć: ");
            string pseudonim = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (pseudonim == array[i, 0])
                {
                    Console.WriteLine("\nNumer telefonu osoby " + pseudonim + " to: " + array[i, 1]);
                    break;
                }
                else if (i == n - 1)
                {
                    Console.WriteLine("\nNie znaleziono osoby o podanym pseudonimie.");
                }
            }
            Console.ReadKey();
        }
    }
}
