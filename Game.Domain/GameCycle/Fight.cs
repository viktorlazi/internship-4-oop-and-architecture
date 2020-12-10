using System.Collections.Generic;
using System;
using Game.Domain.Helper;
using Game.Data.Models.Entity;
using Game.Data.Global;
using Game;
namespace Game.Domain.GameCycle{
    public static class Fight{
        public static void Screen(){
            Npc opponent = DungeonData.Npcs[0];
            Console.Clear();
            while(true){
                if(ChooseAttacker()){
                    Attack(opponent);
                }else{
                    Defend(opponent);
                }

                if(!opponent.IsAlive()){
                    WinFight();
                }
                if(!PlayerData.Player1.IsAlive()){
                    LoseFight();
                }
                UserInput.EnterToContinue();
            }
            

        }
        static void GameHeader(Npc enemy){
            DisplayText.DashWall();
            System.Console.Write("You: "); DisplayText.ColorLine(PlayerData.Player1.ToString(), PlayerData.Player1.DisplayColor, ConsoleColor.DarkGray); 
            DisplayText.PlayerStats(PlayerData.Player1);
            DisplayText.DashWall();
            System.Console.Write("Enemy: "); DisplayText.ColorLine(enemy.ToString(), enemy.DisplayColor, ConsoleColor.DarkGray); 
            DisplayText.EnemyStats(enemy);
            System.Console.WriteLine();
            DisplayText.DashWall();
            DisplayText.DashWall();
        }

        static bool ChooseAttacker(){
            while(true){
                Console.Clear();
                GameHeader(DungeonData.Npcs[0]);
                var playerStrat = UserInput.Strategy();
                var npcStrat = Npc.Strategy();

                System.Console.Write("Enemy played: ");

                if(playerStrat == Data.Enum.Strategy.DirectAttack){
                    switch(npcStrat){
                        case Data.Enum.Strategy.DirectAttack: DisplayText.ColorLine("The same as you", ConsoleColor.Gray); break;
                        case Data.Enum.Strategy.SideAttack: DisplayText.ColorLine("Side Attack", ConsoleColor.Green); return true;
                        case Data.Enum.Strategy.CounterAttack: DisplayText.ColorLine("Counter Attack", ConsoleColor.Red); return false;
                    }
                }else if(playerStrat == Data.Enum.Strategy.SideAttack){
                    switch(npcStrat){
                        case Data.Enum.Strategy.DirectAttack: DisplayText.ColorLine("Direct Attack", ConsoleColor.Red); return false;
                        case Data.Enum.Strategy.SideAttack: DisplayText.ColorLine("The same as you", ConsoleColor.Gray); break;
                        case Data.Enum.Strategy.CounterAttack: DisplayText.ColorLine("Counter Attack", ConsoleColor.Green); return true;
                    }
                }else if(playerStrat == Data.Enum.Strategy.CounterAttack){
                    switch(npcStrat){
                        case Data.Enum.Strategy.DirectAttack: DisplayText.ColorLine("Direct Attack", ConsoleColor.Green); return true;
                        case Data.Enum.Strategy.SideAttack: DisplayText.ColorLine("Side Attack", ConsoleColor.Red); return false;
                        case Data.Enum.Strategy.CounterAttack: DisplayText.ColorLine("The same as you", ConsoleColor.Gray); break;
                    }
                }
                System.Console.WriteLine("Try again");
                UserInput.EnterToContinue();
               
            }
        }
        static void Attack(Npc npc){
            DisplayText.ColorLine("You outplayed your enemy!", ConsoleColor.Yellow);
            DisplayText.ColorLine(
                "You crush your enemy with " + npc.GetHit(PlayerData.Player1.Hit()) + " damage.", ConsoleColor.Green
            );
        }
        static void Defend(Npc npc){
            DisplayText.ColorLine("You got outplayed.", ConsoleColor.Yellow);
            DisplayText.ColorLine(
                npc.ToString() + " hits you with " + PlayerData.Player1.GetHit(npc.Hit()) + " damage.", ConsoleColor.Red
            );
        }       
        static void WinFight(){

        }
        static void LoseFight(){

        }

    }
}