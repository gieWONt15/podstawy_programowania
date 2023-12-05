namespace zadanie5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            byte[] array = new byte[10];

            for (int i = 0; i < 10; i++) 
            {
                array[i] = (byte)rnd.Next(0, 255);
            };

            foreach(int item in array)
            {
                Console.Write(item + " ");
            };

            byte najmniejszy = array[0];
            int pozycja = 0;

            for (int i = 1; i < array.Length; i++) 
            {
                if (najmniejszy > array[i])
                {
                    najmniejszy = array[i];
                    pozycja = i+1;
                }
            }
            Console.WriteLine($"Najmniejszy element tablicy: {najmniejszy}");
            Console.WriteLine($"Pozycja najmniejszego elementu: {pozycja}");
            Console.ReadKey();
        }
    }
}
