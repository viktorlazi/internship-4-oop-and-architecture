using System.Collections.Generic;
using System;
using Game.Domain.Helper;
using Game.Data.Models.Entity;
using Game.Data.Global;
namespace Game.Domain.GameCycle{
    public static class Fight{
        public static void Screen(){
            Console.Clear();

            while(true){
                Console.Clear();
                GameHeader(DungeonData.Npcs[0]);
                if(ChooseAttacker()){
                    Attack();
                }else{
                    Defend();
                }
            }

        }

        static void GameHeader(Npc enemy){
            DisplayText.DashWall();
            System.Console.WriteLine("You:");
            DisplayText.PlayerStats(PlayerData.Player1);
            DisplayText.DashWall();
            System.Console.WriteLine("Enemy:");
            DisplayText.EnemyStats(enemy);
            System.Console.WriteLine();
            DisplayText.DashWall();
            DisplayText.DashWall();
        }

        static bool ChooseAttacker(){
            Console.ReadLine();
            return true;
        }

        static void Attack(){
            
        }
        static void Defend(){

        }
    }
}