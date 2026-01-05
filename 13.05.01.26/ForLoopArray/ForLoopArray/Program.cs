namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //vaja teha string array H, e , l, l, o
            //kasutada for loopi
            string[] array = { "H", "e", "l", "l", "o" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //kasutage nüüd foreach-i
            Console.WriteLine("Hello, World!");
            string[] array2 = { "H","e", "l", "l", "o" };
            foreach (string i in array2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
