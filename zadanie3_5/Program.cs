namespace zadanie3_5;

class Program
{
    static void Main(string[] args)
    {
        double poczatkowaKwota = 10000.0;
        double oprocentowanieRoczne = 0.05;
        int liczbaMiesiecy = 12;
        double kwotaPoRoku = poczatkowaKwota;

        for (int miesiac = 1; miesiac <= liczbaMiesiecy; miesiac++)
        {
            double odsetkiMiesieczne = kwotaPoRoku * (oprocentowanieRoczne / 12);
            kwotaPoRoku += odsetkiMiesieczne;
        }

        double zysk = kwotaPoRoku - poczatkowaKwota;

        Console.WriteLine($"Kwota po roku wynosi: {kwotaPoRoku:C}");
        Console.WriteLine($"Zysk z odsetek wynosi: {zysk:C}");
        Console.ReadLine();
    }
}