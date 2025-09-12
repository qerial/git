namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi");

            //siin on muutuja nimega name ja selle sisse saab lisada väärtust
            string name = Console.ReadLine();

            //if ja else kontrollib, kas name muutuja on tühi või mitte
            if (name != "")
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Sisestasid enda nime");
                Console.WriteLine(name);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR. Nime ei sisestatud");
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
        }
    }
}
