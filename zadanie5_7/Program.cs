namespace zadanie5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random random = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(10);
            }
            Console.WriteLine("Tablica wejściowa: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine("\nTablica wynikowa: ");

            int n = nums.Length;
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 1; i < n; i++)
                {
                    if (nums[i - 1] > nums[i])
                    {
                        int temp = nums[i - 1];
                        nums[i - 1] = nums[i];
                        nums[i] = temp;

                        swapped = true;
                    }
                }
                n--;
            } while (swapped);

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
