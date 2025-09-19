namespace Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Brackets!");

            Console.WriteLine("Kui palju on 3 + 8 / (4 - 2) * 4 = ?");

            //arvuti arvutab: jagamine ja korrutamine on samal tasemel, aga jagamine 
            //oli seekord eespool. Alguses jagati 8 sulgudes oleva väärtusega, mis
            //tähendas 8 jagatud 2. Järgnevalt korrutati see tulemus 4-ga ja saadi 16.
            //Peale seda 16 liideti 3-ga ja saadi vastuseks 19.
            double calculation1 = 3 + 8 / (4 - 2) * 4;
            //antud juhul ei aksepteeri komakohaga numbrit e teisendab selle täisarvuks
            double calculation2 = (3 + 8) / (4 - 2) * 4;
            double calculation3 = 3.0 + 8.0 / ((4.0 - 2.0) * 4.0);


            Console.WriteLine("Vastus " + calculation1);
            Console.WriteLine("Vastus " + calculation2);
            Console.WriteLine("Vastus " + calculation3);
        }
    }
}
