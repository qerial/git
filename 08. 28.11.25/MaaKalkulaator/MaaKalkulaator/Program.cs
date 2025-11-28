namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Meil on münt, mille diameeter on 25,75 mm
            //Arvutada välja Maa ümbermõõt ja mitu münti
            //Mahub järjestikku ümber Maa
            //Arvutuses tohib kasutada ainult mündi diameetrit ja Maa raadiust
            int MaaRaadius = 637100000;
            double MündiRaadius = 25.75;
            double maaümbermõõt = 2 * Math.PI * MaaRaadius;
            Console.WriteLine("Maa ümbermõõt " + maaümbermõõt + "mm" );
            double Mündiümbermõõt = 2 * Math.PI * MündiRaadius;
            Console.WriteLine("Mündi ümbermõõt on " + Mündiümbermõõt + "mm");
            double MündidÜmbermaa = maaümbermõõt / Mündiümbermõõt;
            Console.WriteLine("Maa ümber mahub " + MündidÜmbermaa + " Münti");


        }
    }
}
