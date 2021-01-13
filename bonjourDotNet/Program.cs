using System;

namespace bonjourDotNet
{
    class MainClass
    {
        private const int V = 5;

        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le manoir de la peur");
            Console.WriteLine("Vous arrivé devant le manoir");
            Console.WriteLine("Voulez vous allez a l'EST ou a 'OUEST?");
            string response = Console.ReadLine();
            if(response == "EST")
            {
                Console.WriteLine("Vous etes tomber dans un ravin !! pas de chance");
            }
            else if(response == "OUEST")
            {
                Console.WriteLine("Vous avez trouver deux entrer en face de vous");
                Console.WriteLine("La fenetre ou la porte ??");
            }
            else
            {
                while (response != "EST")
                {
                    Console.WriteLine("EST ou OUEST ??");
                    response = Console.ReadLine();
                }
            }
           
        }
    }
}
