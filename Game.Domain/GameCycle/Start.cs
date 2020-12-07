using Game.Domain.Helper;
using System;

namespace Game.Domain.GameCycle{
    public static class Start{
        public static void WelcomeScreen(){
            Console.Clear();
            DisplayText.DashWall();
            System.Console.WriteLine("\tDungeon Crawler");
            DisplayText.DashWall();
            System.Console.WriteLine();

            DisplayText.ColorLine(
                "You are stuck in a dungeon, my friend...\n" +
                "The only way out is obstructed by 10 monsters!\n" +
                "You will need to kill them all to get back home.",
                ConsoleColor.DarkCyan
            );

            UserInput.EnterToContinue();

            DisplayText.ColorLine(
                "I can give you one power of your choosing to \n" +
                "help you in your mission.",
                ConsoleColor.DarkGreen
            );

            UserInput.EnterToContinue();

            System.Console.WriteLine("Warrior");
            DisplayText.ColorLine(
                Game.Data.Models.Entity.PlayerClass.Warrior.PrintPowers(),
                ConsoleColor.Red
            );

            System.Console.WriteLine("Mage");
            DisplayText.ColorLine(
                Game.Data.Models.Entity.PlayerClass.Mage.PrintPowers(),
                ConsoleColor.Blue
            );

            System.Console.WriteLine("Ranger");
            DisplayText.ColorLine(
                Game.Data.Models.Entity.PlayerClass.Ranger.PrintPowers(),
                ConsoleColor.Yellow
            );

        }
        public static void PromptPlayer(){
            
        }
    }
}