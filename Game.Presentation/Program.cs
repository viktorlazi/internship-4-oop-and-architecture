using System;
using Game.Domain.GameCycle;

namespace Game.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            while(!End.GameEnded){
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
}
