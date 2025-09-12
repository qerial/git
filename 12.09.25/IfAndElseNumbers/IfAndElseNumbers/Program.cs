namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");
            //konsoolis on ainult string andmetüüp 

            //defineerime ära muutuja nimega number
            string number = Console.ReadLine();
            //konverteerime muutuja number ära numberConvertetiks
            //int numberConverted = Convert.ToInt32(number);
            
            //toimub kontroll, et kas muutujal on väärtus ja kas see on int andmetüüp
            if (int.TryParse(number, out int numberConverted))
            {
                Console.WriteLine("Sisestasid enda vanuse: " + number);
            }
            //kui ei sisestatud numbri väärtust, siis on teade: Ei sisestanud vanust
            else
            {
                Console.WriteLine("Ei sisestanud vanust");
            }
        }
    }
}
