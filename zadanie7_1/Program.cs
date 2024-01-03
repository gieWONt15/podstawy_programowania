namespace zadanie7_1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj gęstość zaludnienia A: (osoby/km^2");
        double vol1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj gęstośc zaludnienia B: (osoby/km^2)");
        double vol2 = double.Parse(Console.ReadLine());

        double srednia = average(vol1, vol2);

        Console.WriteLine($"Średnia gęsttość zaludnienia: {srednia} osoby/km^2");
        Console.ReadLine();
    }

    static double average(double vol1, double vol2)
    {
        return 2 / ((1 / vol1) + (1 / vol2));
    }
}
