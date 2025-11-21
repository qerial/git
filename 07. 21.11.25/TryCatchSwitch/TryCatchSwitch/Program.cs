using System.Net.NetworkInformation;

namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesa number!");
            

            //tee switch, kus on ainult kaks casei
            //ja valikud on 1 ja 2 
            //default haru ei ole vajalik
            try
            {

                int nr = int.Parse(Console.ReadLine());

                switch (nr)
                {
                    case 1:
                        Console.WriteLine("Valisid 1 ");
                        break;
                    case 2:
                        Console.WriteLine("Valisid 2");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Palun sisesta number!");
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Sisestatud number on liiga suur või liiga väike!");
            }   
        }
    }
}
