using System;
using Game.Domain.GameCycle;

namespace Game.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("- Please make sure console is appropriate size. -");
            System.Console.ReadLine();
            Start.WelcomeScreen();
            
            while(!End.GameEnded){
                Rest.Screen();
                Walk.Screen();
                Fight.Screen();
            }

            End.Screen();

            Console.ReadLine();
        }
    }
}
