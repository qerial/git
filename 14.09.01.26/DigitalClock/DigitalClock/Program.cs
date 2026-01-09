namespace DigitalClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Digital Clock";
            Console.CursorVisible = false;

            //while (true)
            //{
            //    Console.Clear();
            //    Console.Writeline("Digital Clock\n")
            //    Console.Writeline(DateTime.Now.ToString("HH:mm:ss"))
            //    Thread.Sleep(1000);
            //}

            //tsükkel
            //while (true)
            {
                //tingimus on tõene, mis jätkab tsüklit
                //Console.Clear();
                //Muutuja, millel on arvutiaeg
                //string time = DateTime.Now.ToString("HH:mm:ss");
                //teeb stringi kust arvuti võtab praeguse aja ja 
                //mis formaadis ta peab selle printima

                //int x = (Console.WindowWidth - time.Length) / 2;
                //muudab windowi laiust
                //int y = Console.WindowHeight / 2;
                //muudab windowi kõrgust

                //Console.SetCursorPosition(x, y);
                //kella numbrite näitamise koht
                //Console.Write(time);
                //prindib aja ekraanile

                //Thread.Sleep(1000);
                //kui kiiresti ta refreshib(ootab ühe sekundi)
            }

            //for loopiga teha digitaalne kell
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                Thread.Sleep(1000); // wait 1 second
            }
        }
    }
}
