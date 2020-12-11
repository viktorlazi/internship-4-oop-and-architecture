using System.Collections.Generic;
using System;
namespace Game.Data.Global
{
    public static class DefaultStartValues
    {      
        public static int WarriorHp {get;set;}= 75;
        public static int WarriorDmg {get;set;}= 6;

        public static int RangerHp {get;set;}= 100;
        public static int RangerDmg {get;set;}= 9;
        public static int RangerCritDmg {get;set;}= RangerDmg+4;
        public static int RangerCritChance {get;set;}= 30;
        public static int RangerStunChance {get;set;}= 10;
        
        public static int MageHp {get;set;}= 75;
        public static int MageDmg {get;set;}= 14;
        public static int MageMana {get;set;}= 130;

        public static int GoblinHp {get;set;}= 45;
        public static int GoblinDmg {get;set;}= 5;
        public static int GoblinXp {get;set;}= 15;

        public static int WitchHp {get;set;}= 55;
        public static int WitchDmg {get;set;}= 4;
        public static int WitchXp {get;set;}= 85;

        public static int BruteHp {get;set;}= 200;
        public static int BruteDmg {get;set;}= 13;
        public static int BruteSlamChance {get;set;}= 20;
        public static int BruteSlamDmg {get;set;}= 30;
        public static int BruteXp {get;set;}= 45;

        
        public static int GoblinSpawnChance {get;set;}= 75; //per cent
        public static int WitchSpawnChance {get;set;}= 5;
        public static int BruteSpawnChance {get;set;}= 20;
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
