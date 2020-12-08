using System;
using Game.Data.Models.Entity;
using Game.Data.Models.Entity.PlayerClass;
using System.Collections.Generic;
namespace Game.Domain.Helper{
    public static class DisplayText{
        public static void Color(string text, ConsoleColor color){
            Console.ForegroundColor = color;
            System.Console.Write(text);
            Console.ResetColor();
        }
        public static void ColorLine(string text, ConsoleColor color){
            Console.ForegroundColor = color;
            System.Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void Color(string text, ConsoleColor color, ConsoleColor backColor){
            Console.ForegroundColor = color;
            Console.BackgroundColor = backColor;
            System.Console.Write(text);
            Console.ResetColor();
        }
        public static void ColorLine(string text, ConsoleColor color, ConsoleColor backColor){
            Console.ForegroundColor = color;
            Console.BackgroundColor = backColor;
            System.Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void DashWall(){
            // 32 ih je
            System.Console.WriteLine("--------------------------------");
        }
        public static void DashWall(ConsoleColor color){
            Console.ForegroundColor = color;
            System.Console.WriteLine("--------------------------------");
            Console.ResetColor();
        }
        public static void DashWall(ConsoleColor color, ConsoleColor backColor){
            Console.ForegroundColor = color;
            Console.BackgroundColor = backColor;
            System.Console.WriteLine("--------------------------------");
            Console.ResetColor();
        }


        public static void PlayerStats(Player player){
            foreach(var stat in player.Stats()){
                System.Console.Write("\t");
                DisplayText.Color(stat.Item1, stat.Item2);
                System.Console.Write(" - ");
                DisplayText.ColorLine(stat.Item3.ToString(), stat.Item2);
            }
        }

        public static void EnemiesInOrder(List<Npc> enemies){
            foreach(var enemy in enemies){
                System.Console.Write(" -> ");
                Color(enemy.ToString(), enemy.DisplayColor);
            }
        }

    }
}