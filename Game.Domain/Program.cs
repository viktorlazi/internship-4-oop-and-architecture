using System;
using Game.Data;
using Game.Data.Global;
using Game.Domain.GameCycle;

namespace Game.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Start.GenerateEnemies();
            for(int i = 0; i< 10;i++){
                System.Console.WriteLine(DungeonData.Entities[i].ToString());

            }

            Console.ReadLine();
        }
    }
}
