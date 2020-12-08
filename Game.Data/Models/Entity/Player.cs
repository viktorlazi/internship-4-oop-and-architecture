using System;
using System.Collections.Generic;
namespace Game.Data.Models.Entity
{
    public class Player : Entity
    {      
        public static int Xp {get;set;} = 0;
        public static int Level {get;set;} = 1;
        

        public virtual List<Tuple<string, ConsoleColor, int>> Stats(){
            return new List<Tuple<string, ConsoleColor, int>>(){
                new Tuple<string, ConsoleColor, int>("Xp", ConsoleColor.White, Xp),
                new Tuple<string, ConsoleColor, int>("Level", ConsoleColor.White, Level)

            };
        }
    }
}
