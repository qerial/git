namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk");

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i <= n)
            {
                Console.WriteLine();
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }
                i++;
            


            //otsida internetist while koodiga kolmnurga kujundeid e tegemis viise
            //kui kood on leitud, siis kirjutada see siia alla 
            //teha vooskeem
            }
            Console.ReadKey();
        }
    }
}
