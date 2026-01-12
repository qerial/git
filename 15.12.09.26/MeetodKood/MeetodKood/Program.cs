using System.ComponentModel.Design;
using System.Drawing;

namespace MeetodKood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali millist meetodit tahad, 1-4.");

            string nr = Console.ReadLine();
            int number = int.Parse(nr);
            if (number == 1)
            ForLoop();
            else if (number == 2)
            WhileLoop();
            else if (number == 3)
            AddTwoNumbers();
            else if (number == 4)
            AskAge();
            else
                Console.WriteLine("Liiga suur või väike number!");
            {

            }
        }
            
        static void ForLoop()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Hommik1");
            }

            Console.WriteLine("\n");
        }

        static void WhileLoop()
        {
            int j = 1;
            while (j < 4)
            {
                Console.WriteLine("Hommik2");
                j++;
            }
            Console.WriteLine("\n");
        }

        static void AddTwoNumbers()
        {
            int a, b, liitmine;

            Console.WriteLine("Esimene arv:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Teine arv:");
            b = int.Parse(Console.ReadLine());

            liitmine = a + b;

            Console.WriteLine("Vastus on " + liitmine);
        }

        static void AskAge()
        {
            Console.WriteLine("Kui vana sa oled?");
            int vanus = int.Parse(Console.ReadLine());
            int x = (Console.WindowWidth) / 2;
            int y = Console.WindowHeight / 2;
            Console.WriteLine("Sa oled " + vanus);
        }
    }
}