using System;
using Game.Domain.GameCycle;

namespace Game.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
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
