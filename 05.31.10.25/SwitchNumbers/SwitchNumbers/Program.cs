namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //peab saama sisestada numbrit ja muudab selle int andmetüübiks
            int number = Convert.ToInt32((string) Console.ReadLine());
            //tuleb teha switch, kus on esimene case 10, teine on 20 ja kolmas on 30
            //kindlasti tukeb ja default lõppu teha
            switch (number)
            {
            case 10:
                Console.WriteLine("Esimene switch!");
                break;
            
            case 20:
                Console.WriteLine("Teine switch!");
                break;

            case 30:
                Console.WriteLine("Kolmas switch!");
                break;
            default:
                Console.WriteLine("ERROR! switchi pole tuvastatud");
                break ;

            }
        }
    }
}
