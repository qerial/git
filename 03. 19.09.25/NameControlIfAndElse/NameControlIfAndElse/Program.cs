namespace NameControlIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi!");
            //Sisesta nimi
            //kasuta if ja else
            //kui nimi on sisestatud, siis kuvab sinu sisestatud nime
            //Tagataust peab olema roheline ja tekst kollast värvi
            //Kui nime ei sisestata, siis tekst on roheline ja tagataust valge
            //ning lisaks sellele teeb kolm korda beep iga kahe sekundi järel
            string name = Console.ReadLine();

            //! tähendab eitust e ei võrdu
            if (name != "")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Sinu nimi on " + name);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Nime ei sisestatud");

                Console.Beep();
                Thread.Sleep(2000);
                Console.Beep();
                Thread.Sleep(2000);
                Console.Beep();
                Thread.Sleep(2000);
            }
        }
    }
}
