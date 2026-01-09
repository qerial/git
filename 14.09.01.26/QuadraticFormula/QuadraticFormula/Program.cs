using System.ComponentModel.Design.Serialization;
using System.Threading.Channels;

namespace QuadraticFormula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruutvõrrand!");

            //ax2 + bx + c 

            //sisesta a, b ja c väärtus
            //kasutaja peab saama sisestada neid väärtuseid
            int a, b, c;  // Declaration of integer variables a, b, and c for quadratic equation coefficients
            double d, x1, x2;  // Declaration of double variables d, x1, and x2 for discriminant and roots
            Console.Write("\n\n");  // Printing new lines
            Console.Write("Calculate root of Quadratic Equation :\n");  // Displaying the purpose of the program
            Console.Write("----------------------------------------");  // Displaying a separator
            Console.Write("\n\n");

            Console.Write("sisesta a väärtus: ");  // Prompting user to input the value of coefficient a
            a = Convert.ToInt32(Console.ReadLine());  // Reading the input value of coefficient a from the user
            Console.Write("sisesta b väärtus: ");  // Prompting user to input the value of coefficient b
            b = Convert.ToInt32(Console.ReadLine());  // Reading the input value of coefficient b from the user
            Console.Write("sisesta c väärtus: ");  // Prompting user to input the value of coefficient c
            c = Convert.ToInt32(Console.ReadLine());  // Reading the input value of coefficient c from the user

            d = b * b - 4 * a * c; //Calculating the discriminant

            if (d == 0)  // Checking if the discriminant is equal to 0
            {
                Console.Write("Both roots are equal.\n");  // Printing a message if both roots are equal
                x1 = -b / (2.0 * a);  // Calculating the root when discriminant is zero
                x2 = x1;  // Assigning the same root to x2
                Console.Write("First Root Root1= {0}\n", x1);  // Printing the root when discriminant is zero
                Console.Write("Second Root Root2= {0}\n", x2);  // Printing the root when discriminant is zero
            }
            else if (d > 0)  // Checking if the discriminant is greater than 0
            {
                Console.Write("Both roots are real and different.\n");  // Printing a message if roots are real and different

                x1 = (-b + Math.Sqrt(d)) / (2 * a);  // Calculating the first root
                x2 = (-b - Math.Sqrt(d)) / (2 * a);  // Calculating the second root

                Console.Write("First Root Root1= {0}\n", x1);  // Printing the first root
                Console.Write("Second Root Root2= {0}\n", x2);  // Printing the second root
            }
            else
            {
                Console.Write("Roots are imaginary;\nNo Solution. \n\n");  // Printing a message if roots are imaginary
            }
        }
    }
}
