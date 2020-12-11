using System.Collections.Generic;

namespace Game.Domain.GameCycle{
    public static class End{        
        public static bool GameEnded{get;set;} = false;      
        public static bool Won{get;set;}  
        public static void Screen(){
            if(Won){
                System.Console.WriteLine("You win!");
            }else{
                System.Console.WriteLine("You lost!");
            }
        }
    }
}