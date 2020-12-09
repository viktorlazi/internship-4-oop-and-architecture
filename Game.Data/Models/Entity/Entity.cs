using System;
using System.Collections.Generic;
namespace Game.Data.Models.Entity
{
    public class Entity
    {      
        public string Name {get;set;}
        public int Hp {get;set;}
        public int Damage {get;set;}
        public bool isAlive{get;set;} = true;
        
        public int Xp {get;set;}
        
        public int Level {get;set;}
        

        public ConsoleColor DisplayColor{get;set;}
        public virtual int Attack(){
            return 0;
        }
        public virtual List<Tuple<string, ConsoleColor, int>> Stats(){
            return new List<Tuple<string, ConsoleColor, int>>(){
                new Tuple<string, ConsoleColor, int>("Xp", ConsoleColor.White, Xp),
                new Tuple<string, ConsoleColor, int>("Level", ConsoleColor.White, Level),
                new Tuple<string, ConsoleColor, int>("Hp", ConsoleColor.Red, Hp),
                new Tuple<string, ConsoleColor, int>("Damage", ConsoleColor.Yellow, Damage)
            };
        }
        public override string ToString(){
            return "Entity";
        }
    }
}
