namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha if ja else konsoolirakendus, kus " +
                "kontrollitakse stringi (sõne) abil värvi vastavust");

            Console.WriteLine("Värvide valikus on: red, blue, green ja white");

            Console.WriteLine("peab käsitlema juhust, kus vastaja ei sisesta " +
                "eelpool sisestatud värvi");

            Console.WriteLine("Sisesta värv");

            string color = Console.ReadLine();

            if (color == "red")
            {
                Console.WriteLine("see on punane värv");
            }
            else if (color == "blue")
            {
                Console.WriteLine("see on sinine värv");
            }
            else if (color == "green")
            {
                Console.WriteLine("see on roheline värv");
            }
            else if (color == "white")
            {
                Console.WriteLine("see on valge värv");
            }
            else
            {
                Console.WriteLine("Sisestasid suvalise värvi");
            }
        }
    }
}
