using System.Collections.Generic;
using System;
namespace Game.Data.Global
{
    public static class DefaultStartValues
    {      
        public static int WarriorHp {get;set;}= 125;
        public static int WarriorDmg {get;set;}= 5;

        public static int RangerHp {get;set;}= 100;
        public static int RangerDmg {get;set;}= 7;
        public static int RangerCritDmg {get;set;}= RangerDmg+4;
        public static int RangerCritChance {get;set;}= 30;
        public static int RangerStunChance {get;set;}= 10;
        
        public static int MageHp {get;set;}= 75;
        public static int MageDmg {get;set;}= 10;
        public static int MageMana {get;set;}= 130;

        public static int GoblinHp {get;set;}= 35;
        public static int GoblinDmg {get;set;}= 4;
        public static int GoblinXp {get;set;}= 15;

        public static int WitchHp {get;set;}= 60;
        public static int WitchDmg {get;set;}= 7;
        public static int WitchXp {get;set;}= 80;
        public static int WitchDjumbusChance{get;set;} = 8;

        public static int BruteHp {get;set;}= 80;
        public static int BruteDmg {get;set;}= 7;
        public static int BruteSlamChance {get;set;}= 20;
        public static int BruteSlamDmg {get;set;}= 20;
        public static int BruteXp {get;set;}= 45;


        // summ must be equal to 100
        public static int GoblinSpawnChance {get;set;}= 65; //per cent
        public static int WitchSpawnChance {get;set;}= 25;
        public static int BruteSpawnChance {get;set;}= 10;
        
        public static Dictionary<Enum.Npc, int> SpawnChances {get;set;}= new Dictionary<Enum.Npc, int>(){
            {Enum.Npc.Goblin, GoblinSpawnChance},
            {Enum.Npc.Brute, BruteSpawnChance},
            {Enum.Npc.Witch, WitchSpawnChance} 
        };
        

        public static ConsoleColor GoblinColor {get;} = ConsoleColor.Green;
        public static ConsoleColor BruteColor {get;} = ConsoleColor.Magenta;
        public static ConsoleColor WitchColor {get;} = ConsoleColor.DarkYellow;

        public static ConsoleColor WarriorColor {get;} = ConsoleColor.Red;
        public static ConsoleColor RangerColor {get;} = ConsoleColor.Yellow;
        public static ConsoleColor MageColor {get;} = ConsoleColor.Blue;



        public static List<int> XpForLevel = new List<int>(){
            0,0,100,300,1000
        };



    }
}
