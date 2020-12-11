using System;
using Game.Domain.GameCycle;

namespace Game.Presentation
{
    class Program
    {
        /*
            "Svako čudovište ima nekom kvazi-random metodom generirani HP i Damage, te koliko
            vrijedi Experiencea ako se porazi"
             - ovo san prominia tako da HP, Damage, Exp  imaju default vrijednosti ali 
                se mijenjaju levelom, a damage ima i random komponentu
        */
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("- Please make sure console is in fullscreen. -");
            System.Console.ReadLine();
            Start.WelcomeScreen();
                        
            while(!End.GameEnded){
                Rest.Screen();
                Walk.Screen();
                Fight.Screen();
                Console.Clear();
            }
            End.Screen();
            Console.ReadLine();
        }
    }
}
