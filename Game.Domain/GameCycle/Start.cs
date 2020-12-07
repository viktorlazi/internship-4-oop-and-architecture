using Game.Domain.Helper;
using Game.Data.Global;
using Game.Data.Models.Entity;
using Game.Data.Models.Entity.PlayerClass;
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
            Console.Clear();

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

            DisplayText.DashWall();

            PlayerData.Player = ChooseYourDestiny();
            
            Console.Clear();

            System.Console.WriteLine("Very well, " + PlayerData.Player);
            System.Console.WriteLine("I will stay here where it's safe.");
            System.Console.WriteLine("You go kill em!");

        }
        public static Player ChooseYourDestiny(){
            while(true){
                System.Console.WriteLine("Choose your destiny!");
                System.Console.Write("I would like to be a: ");
                var option = Console.ReadLine();

                switch(option){
                    case "warrior":
                        return new Warrior();
                    case "Warrior":
                        return new Warrior();
                    case "mage":
                        return new Mage();
                    case "Mage":
                        return new Mage();
                    case "ranger":
                        return new Ranger();
                    case "Ranger":
                        return new Ranger();
                }

                DisplayText.ColorLine(option + " is not a valid option", ConsoleColor.Magenta);
                System.Console.WriteLine();
            }
        }


    }
}