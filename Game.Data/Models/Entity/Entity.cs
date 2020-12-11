using System;
using System.Collections.Generic;
namespace Game.Data.Models.Entity
{
    public class Entity
    {      
        public int Hp {get;set;}
        public int Damage {get;set;}
        
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
        public int Hit(){
            return Damage + RandomizeDamage();
        }
        public int GetHit(int dmg){
            Hp-=dmg;
            return dmg;
        }

        public int RandomizeDamage(){
            var random = new Random();
            int randomAttack = random.Next(-1, 2);
            return randomAttack;
        }

        public virtual bool IsAlive(){
            return Hp > 0;
        }
        public override string ToString(){
            return "Entity";
        }
    }
}
