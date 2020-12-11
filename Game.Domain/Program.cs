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
            GameCycle.Start.GenerateEnemies();
            Console.ReadLine();
        }
    }
}
