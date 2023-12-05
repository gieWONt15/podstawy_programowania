namespace zadanie5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lotto = new int[6];
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                int randomNumber;
                do
                {
                    randomNumber = random.Next(1, 50);
                } while (Array.IndexOf(lotto, randomNumber) != -1);
                lotto[i] = randomNumber;
            }
            foreach (int i in lotto)
            {
                Console.Write(i + " ");
            }
        }
    }
}
