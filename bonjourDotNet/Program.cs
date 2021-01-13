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
                Console.WriteLine("Vous etes tomber dans un trou !! pas de chance");
            }
            else if(response == "OUEST")
            {
                Console.WriteLine("Vous avez trouver deux entrer en face de vous");
                Console.WriteLine("La fenetre ou la porte ??");
                response = Console.ReadLine();
                if(response == "porte")
                {
                    Console.WriteLine("Bonjour et bienvenue !! =D");
                }
                else
                {
                    Console.WriteLine("La fenetre est fermer !! Dommage...");
                    Console.WriteLine("Vous aurez plus de chance la prochaine fois !! ");                }
            }
            else
            {
                while (response != "EST")
                {
                    Console.WriteLine("Vous n'avez pas fait le bon choix");
                }
            }
           
        }
    }
}
