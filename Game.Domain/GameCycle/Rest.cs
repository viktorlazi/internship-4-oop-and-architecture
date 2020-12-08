using System.Collections.Generic;
using Game.Domain.Helper;
using Game.Data.Global;

namespace Game.Domain.GameCycle{
    public static class Rest{
        public static void Screen(){
            DisplayText.PlayerStats((PlayerData.Player));
            DisplayText.DashWall();

            System.Console.WriteLine("Your eneies:");
            DisplayText.EnemiesInOrder(DungeonData.Npcs);
            

            UserInput.EnterToContinue();
        }
    }
}