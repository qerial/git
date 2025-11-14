namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            //loeme kasutaja sisendit ja teisendame selle float tüübiks
            int a,b;
            double choice;           
            //konsool kirjutab kasutajale, et vali tehe: +, -, *, /

            //konsool kirjutab , et sisesta teine number ja teisendame selle floati tüübiks

            //teeme switch lausega tehte valiku

            float FirstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("1.Liitmine");
            Console.WriteLine("2.Lahutamine");
            Console.WriteLine("3.Korrutamine");
            Console.WriteLine("4.Jagamine");
            Console.WriteLine("Vali number 1-4");
            string operation = Console.ReadLine();

            Console.WriteLine("sisesta teine number");
            float secondNumber = float.Parse(Console.ReadLine());


            switch (operation)
            {
                case "1":
                float result1 = FirstNumber + secondNumber;
                Console.WriteLine(result1);
                    break;
                case "2":
                float result2 = FirstNumber - secondNumber;
                    Console.WriteLine(result2);
                break;
                case "3":
                float result3 = FirstNumber * secondNumber;
                    Console.WriteLine(result3);
                break;
                case "4":
                float result4 = FirstNumber / secondNumber;
                    Console.WriteLine(result4);
                break;
            }









        }
    }
}
