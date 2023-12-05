namespace zadanie5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy: ");
            int n = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    isValidInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidołowy format danych. Podaj liczbę całkowitą.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Podana wartość jest zbyt duża lub zbyt mała.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Wystąpił nieoczekiwany błąd.");
                }
            };

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Podaj wartość dla elementu {i}: ");
                isValidInput = false;
                
                while (!isValidInput)
                {
                    try
                    {
                        array[i] = int.Parse(Console.ReadLine());
                        isValidInput = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nieprawidołowy format danych. Podaj liczbę całkowitą.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Podana wartość jest zbyt duża lub zbyt mała.");
                    }
                    catch (Exception) 
                    {
                        Console.WriteLine("Wystąpił nieoczekiwany błąd.");
                    }
                }
            }

            Console.WriteLine("Zawartość tablicy:");
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine($"Element {i}: {array[i]}");
            }
            Console.ReadKey();
        }
    }
}
