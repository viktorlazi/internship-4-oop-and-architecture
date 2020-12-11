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
            System.Console.WriteLine(
                DungeonData.Visual.IndexOf('X')
            );
            Console.ReadLine();
        }
    }
}
