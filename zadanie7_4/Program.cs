namespace zadanie7_4;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        for (int i = 0; i <= 48; i += 3)
        {
            stopwatch.Start();
            Console.WriteLine($"Fibonacci[{i}]={Fibonacci(i)} Liczba wywołań: {counter} Czas wykonania (mm-ss-ms): {stopwatch.Elapsed.Minutes}-{stopwatch.Elapsed.Seconds}-{stopwatch.Elapsed.Milliseconds}");
        }
        Console.ReadKey();
    }

    static long counter = 0;
    static long Fibonacci(int num)
    {
        counter++;
        if (num == 0)
        {
            return 0;
        }
        else if (num == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}

