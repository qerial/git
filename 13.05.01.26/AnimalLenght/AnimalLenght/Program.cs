namespace AnimalLenght
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //1. masiivi tegemine
            string[] animalName = { "Koer", "Kass", "Jänes", "Sipelgas", "Lendorav" };
            //2. programm peab aru saama sõna pikkusest
            int longerName = animalName[0].Length;
            string longerNameString = animalName[0];
            //3. for loop tuelb teha, et saaks nimede pikkust omavahel võrrelda
            //for loopi sees tuleks kasutada if-i
            for (int i = 0; i < animalName.Length; i++)
            {
                if (longerName < animalName[i].Length)
                {
                    longerName = animalName[i].Length;
                    longerNameString = animalName[i];
                }

                int animalLenght = AnimalLenght(animalName[i]);
                Console.WriteLine(animalName[i] + " = ");
                Console.WriteLine(animalLenght);
                Console.WriteLine();
            }
            Console.WriteLine("Pikim nimi oli {0} ja mille nime pikkus oli: {1}", longerNameString, longerName);
        }

        static int AnimalLenght(string animalName)
        {
            return animalName.Length;
        }
    }
}
