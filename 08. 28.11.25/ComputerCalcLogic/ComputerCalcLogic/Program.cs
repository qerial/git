namespace ComputerCalcLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui palju on 3 + 8 / (4-2) * 4 = ?");

            double calcualtion1 = 3 + (8 / ((4 - 2) * 4));
            double calculation2 = 3 + 8 / 4 - 2 * 4;
            double calculation3 = (3 + 8) / (4 - 2) * 4;
            double calculation4 = ((3.0 + 8.0)) / (4.0 - 2.0) * 4.0;

            Console.WriteLine("= " + calcualtion1);
            Console.WriteLine("3 + 8 / 4 - 2 * 4 = " + calculation2);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calculation3);
            Console.WriteLine("((3.0 + 8.0)) / (4.0 - 2.0) * 4.0 = " + calculation4);
        }
    }
}

