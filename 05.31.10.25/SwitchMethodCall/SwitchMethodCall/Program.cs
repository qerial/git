namespace SwitchMethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sisesta sõiduki tüüp!");
            //teha switch rakendus,
            //kus kasutaja sisestab sõiduki tüübi (coupe või truck)
            string input = Console.ReadLine();
            //ja programm kutsub vastava meetodi (CarCoupe või Truck)
            switch (input)
            {
                case "Car Coupe":
                    //meetodi kutse Car Coupe

                    CarCoupe();     
                    break;

                case "Truck":
                    Truck();
                    //meetodi kutse Truck

                    break;

                default:
                    Console.WriteLine("Unknown vehicle type. ");
                    break;
            } 
        }


        static void CarCoupe()
        {
            Console.WriteLine("This is a coupe car. ");
        }
        static void Truck()
        {
            Console.WriteLine("This is a truck. ");
            
        }
    }
}
