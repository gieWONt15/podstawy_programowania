namespace zadanie5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            Console.WriteLine("Tablia elementów");
            for (int i = 0;i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            double suma = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                suma += numbers[i];
            }
            Console.WriteLine($"Średnia wartość elementó tablicy: {suma/numbers.Length}");
            Console.ReadKey();
        }
    }
}
