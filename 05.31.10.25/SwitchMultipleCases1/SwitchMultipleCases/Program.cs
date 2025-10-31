namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta väärtus");
            string input = Console.ReadLine();
            switch (input)
            {
                //sisestad konsooli väärtuse
                //loeb sisestatud väärtuse stringina
                //tuleb kasutada switchi
                //esimeses cases on väärtused "Intro to C#", "Variables",
                //"Data Types" ja vastuseks Basic
                case "Intro to C#" or "Variables" or "Data Types":
                    Console.WriteLine("Basic");
                    break;
                //teises cases on väärtused "OOP", "Classes"
                //"Objects" ja vastuseks intermediate
                case "OOP" or "Classes" or "Objects":
                    Console.WriteLine("Intermediate");
                    break;
                //kolmandas cases on väärtused "Asynchronus Programming, "LINQ",
                //"Delegates" ja vastuseks Advanced
                case "Asynchronus Programming" or "LINQ" or "Delegates":
                    Console.WriteLine("Advanced");
                    break;
                default:
                    Console.WriteLine("Unknown course");
                    break;
            }
        }
    }
}
