namespace zadanie7_8;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10] { 4, 2, 1, 0, 5, 6, 7, 3, 9, 8, };
        Console.WriteLine($"Najmniejszy element to: {FindElement(array)}");

        Console.ReadKey();
    }

    static int FindElement(int[] array)
    {
        if (array.Length==0 || array == null)
        {
            throw new Exception("Tablica jest pusta");
        }
        int min = array[0];
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i]<min)
            {
                min = array[i];
            }
        }
        return min;
    }
}

