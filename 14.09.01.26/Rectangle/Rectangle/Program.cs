using System.Data;
using System.Drawing;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size1, size2, pindala, ümbermõõt;

            Console.WriteLine("Sisesta pikkus");
            size1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta laius");
            size2 = int.Parse(Console.ReadLine());

            pindala = (size1 * size2);
            ümbermõõt = (size1 * 2 + size2 * 2);
            Console.WriteLine("Ristküliku ümbermõõt on " + ümbermõõt);
            Console.WriteLine("Ristküliku pindala on " + pindala);
            Console.WriteLine("\n");

            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

