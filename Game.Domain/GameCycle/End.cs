using System.Collections.Generic;
using Game.Domain.Helper;
using Game.Data.Global;

namespace Game.Domain.GameCycle{
    public static class End{        
        public static bool GameEnded{get;set;} = false;      
        public static bool Won{get;set;}  
        public static void Screen(){
            if(Won){
                System.Console.WriteLine("You win!");
            }else{
                System.Console.WriteLine("You lost!");
                System.Console.WriteLine("Try again?");
                if(UserInput.AreYouSure()){
                    DungeonData.Npcs.Clear();
                    DungeonData.ResetVisual();
                    GameEnded = false;
                }
            }
        }
    }
}