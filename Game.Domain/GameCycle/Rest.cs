using System.Collections.Generic;
using Game.Domain.Helper;
using Game.Data.Global;

namespace Game.Domain.GameCycle{
    public static class Rest{
        public static void Screen(){
            DisplayText.DashWall();
            DisplayText.PlayerStats((PlayerData.Player1));
            DisplayText.DashWall();

            System.Console.WriteLine("Your enemies: ");
            DisplayText.EnemiesInOrder(DungeonData.Npcs);
            
            UserInput.EnterToContinue();
        }
    }
}