namespace zadanie7_6;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {9, 0, 8, 1, 8, 2, 6, 3, 6, 4, 5};
        Console.WriteLine("Tablica przed sortowaniem");
        DisplayArray(numbers);

        BubbleSort(numbers);

        Console.WriteLine("\n\nTablica po sortowaniu");
        DisplayArray(numbers);
        Console.ReadKey();
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        do
        {
            swapped = false;

            for (int i = 1; i < n; i++)
            {
                if (array[i-1] > array[i])
                {
                    Swap(ref array[i-1], ref array[i]);
                }
                swapped = true;
            }
            n--;
        } while (swapped);

    }

    static void DisplayArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
    }
}

