namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub ring. Ringi raadius on 3 ühikut.
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt

            int roundRadius = 3; 
            int diameeter = roundRadius * 2;
            double SquareS = diameeter * diameeter;
            double SquareP = diameeter * 4;
                Console.WriteLine("Diameeter on " + diameeter);
                Console.WriteLine("Ruudu ümbermõõt on " + SquareS);
                Console.WriteLine("Ruudu pindala on " + SquareP);

            //arvutada ringi pindala ja ümbermõõt 
            double CircleC = 2 * Math.PI * roundRadius;

            Console.WriteLine("Ringi ümbermõõt on " + CircleC);

            double CircleS = Math.PI * (roundRadius * roundRadius);

            Console.WriteLine("Ringi Pindala on " + CircleS);


        }
    }
}
