namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esimenee koondtulemuse puhul on number vahemikus
            //0-100
            //teisel puhul 101 kuni 200 ja
            //kolmanda puhul 201 kuni 300
            //kasuta switchi

            Console.WriteLine("Hello, World!");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {




                case >= 0 and <= 100:
                    Console.WriteLine("number on 0 kuni 100");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("number on 101 kuni 200");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("number on 201 kuni 300");
                    break;

                default:
                    Console.WriteLine("Number ei ole vahemikus 0-300");
                    break;


            }
        }
    }
}
