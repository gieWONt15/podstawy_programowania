namespace zadanie6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imię i nazwisko\n");
            string name = Console.ReadLine();
            Console.WriteLine($"Stan zmiennej po podaniu imienia i nazwiska {name}\nPodaj drugie imię\n");
            string name2 = Console.ReadLine();
            // wstawienie drugiego imienia pomiędzy imię i nazwisko
            name = name.Insert(name.IndexOf(" ") + 1, name2 + " ");
            name = name.Remove(0, name.IndexOf(" ") + 1);
            Console.WriteLine($"Stan zmiennej po dodaniu drugiego imienia {name}\nStan zmiennej po usunięciu pierwszego imienia: {name}");
            name = name.Substring(0, 1) + name.Substring(name.IndexOf(" ") + 1, 1);
            Console.WriteLine($"Stan zmiennej po utworzeniu imicjałów: {name}");

            Console.ReadLine();
        }
    }
}
