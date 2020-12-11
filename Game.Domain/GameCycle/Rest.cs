using System.Collections.Generic;
using Game.Domain.Helper;
using System;
using Game.Data.Global;
using Game.Data.Models.Entity;

namespace Game.Domain.GameCycle{
    public static class Rest{
        public static void Screen(){

            do{
                Console.Clear();
                DisplayText.DashWall();
                DisplayText.PlayerStats((PlayerData.Player1));
                DisplayText.DashWall();

                System.Console.WriteLine("Your enemies: ");
                DisplayText.EnemiesInOrder(DungeonData.Npcs);
                DisplayText.DashWall();
                
                DisplayText.ColorLine("1. Continue fighting", ConsoleColor.Yellow);
                DisplayText.ColorLine("2. Turn xp to health", ConsoleColor.Green);
                DisplayText.ColorLine("3. See last fight log", ConsoleColor.White);
            }while(!GetChoice());
            
            UserInput.EnterToContinue();
        }
        
        static bool GetChoice(){
            int.TryParse(Console.ReadLine(), out var res);
            switch(res){
                case 1: 
                    return true;                
                case 2: 
                    XpToHealth(PlayerData.Player1);
                    return false;
                case 3: 
                    return false;
                default: 
                    return false;
            }
        }

        static void XpToHealth(Player player){
            Console.Clear();
            System.Console.Write("Xp: "); System.Console.WriteLine(player.Xp + "/" + player.XpToNextLevel);
            if(player.Xp >= player.XpToNextLevel/2){
                System.Console.WriteLine("Are you sure? You will lose " + (int)player.XpToNextLevel/2 + "xp");
                if(UserInput.AreYouSure()){
                    System.Console.WriteLine("Ok");
                    player.Xp -= (int)player.XpToNextLevel/2;
                }else{
                    System.Console.WriteLine("Going back");
                }
            }else{
                System.Console.WriteLine("You don't have enough xp, you need atleast 50%");
            }
            UserInput.EnterToContinue();
        }

    }
}