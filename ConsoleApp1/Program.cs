namespace ProgramTestowy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> towar = new List<string>();

            towar.Add("xxx");

            towar.Add("yyy");

            towar.Add("zzz");

            towar.RemoveAt(0);

            towar.Insert(2, "www");

            Console.WriteLine(towar[1]);
            Console.ReadKey();
        }
    }
}