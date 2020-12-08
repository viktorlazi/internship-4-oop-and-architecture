using System;
using Game.Domain.GameCycle;

namespace Game.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Start.WelcomeScreen();
            
            while(!Rest.GameEnded){
                Rest.Screen();
                Fight.Screen();
            }

            End.Screen();

            Console.ReadLine();
        }
    }
}
