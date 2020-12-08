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
            int i = 17;
            while(true){
                Console.Clear();
                MoveAround.Down(ref i, ref DungeonData.Visual);
                DisplayText.PrintDungeon(i);
                Console.ReadLine();

            }
        }
    }
}
