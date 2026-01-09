namespace Ruut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ruudu suurus!");
            //teha for loopiga ruut
            int size, ümbermõõt, pindala; // Define the size of the square

            size = int.Parse(Console.ReadLine());

            if (size == 0)
            {
                Console.WriteLine("ERROR! pole sisestanud suurust");
            }

            else if (size < 0)
            {
                Console.WriteLine("pole võimalik teha kuju kus on arvud miinustes.");
            }
            pindala = size * size;
            ümbermõõt = 4 * size;

            Console.WriteLine("Ümbermõõt on " + ümbermõõt);
            Console.WriteLine("Pindala on " + pindala);
            Console.WriteLine("\n");

            for (int i = 0; i < size; i++) // Outer loop for rows
            {
                for (int j = 0; j < size; j++) // Inner loop for columns
                {
                    Console.Write("* "); // Print a star and a space
                }
                Console.WriteLine(); // Move to the next line after each row
                {

                }
            }
        }
    }
}