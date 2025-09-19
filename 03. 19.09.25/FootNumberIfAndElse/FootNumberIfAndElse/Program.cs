namespace FootNumberIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teha jalanumbri suurusest üks if ja else harjutus.
            //Esimene tingimus on jalanumbri 30 - 33 (siin on tekst roheline),
            //teine jalanumbri 34 - 38 (siin on tagataust valge),
            //kolmas jalanumbri 39 - 44 (siin on tekst sinine ja tagataust kollane),
            //neljas jalanumbri 45 - 48 (siin teeb aruvti häält beep)
            //Kindlasti tuleb ära lahendada olukord,
            //kus kasutatakse mõnda teist jalanumbrit.
            Console.WriteLine("Sisesta jalanumber!");

            string foot = Console.ReadLine();
            int footNumber = int.Parse(foot);

            if (footNumber >= 30 && footNumber <= 33)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Jalanumber on vahemikus 30 kuni 33.");
            }
            else if (footNumber >= 34 && footNumber <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Jalanumber on vahemikus 34 kuni 38.");
            }
            else if (footNumber >= 39 && footNumber <= 44)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Jalanumber on vahemikus 39 kuni 44.");
            }
            else if (footNumber >= 45 && footNumber <= 48)
            {
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.WriteLine("Jalanumber on vahemikus 45 kuni 48.");
            }
            else
            {
                Console.WriteLine("Sinu jalanumber on väga suur või väike");
            }
        }
    }
}
