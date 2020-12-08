using System;
using System.Collections.Generic;
namespace Game.Data.Models.Entity
{
    public class Player : Entity
    {      
        public int Xp {get;set;} = 0;
        public int Level {get;set;} = 1;

        public int Position{get;set;} = 16;
        

        public virtual List<Tuple<string, ConsoleColor, int>> Stats(){
            return new List<Tuple<string, ConsoleColor, int>>(){
                new Tuple<string, ConsoleColor, int>("Xp", ConsoleColor.White, Xp),
                new Tuple<string, ConsoleColor, int>("Level", ConsoleColor.White, Level),
                new Tuple<string, ConsoleColor, int>("Hp", ConsoleColor.Red, Hp),
                new Tuple<string, ConsoleColor, int>("Damage", ConsoleColor.Yellow, Damage)
            };
        }
    }
}
