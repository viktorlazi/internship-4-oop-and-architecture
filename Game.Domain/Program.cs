using System;
using Game.Data;
using Game.Data.Global;
using Game.Domain.GameCycle;
using Game.Domain.Helper;

namespace Game.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerData.Player1 = Start.ChooseYourDestiny();
            Start.GenerateEnemies();
            while(!End.GameEnded){
                Console.Clear();
                Rest.Screen();
                Walk.Screen();
                Fight.Screen();
            }
        }
    }
}
