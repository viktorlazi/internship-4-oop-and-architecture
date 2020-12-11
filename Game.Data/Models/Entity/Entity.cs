using System;
using System.Collections.Generic;
namespace Game.Data.Models.Entity
{
    public class Entity
    {      
        public int Hp {get;set;}
        public int MaxHp{get;set;} // dodat u buducnosti nedamisesad, triba bit "HP: Hp/MaxHp"
        public int Damage {get;set;}        
        public int Xp {get;set;}
        public int XpToNextLevel {get;set;}        
        public int Level {get;set;}
        
        public bool Stunned{get;set;} = false;

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
        public virtual int Hit(Entity enemy){
            var amount = Damage + RandomizeDamage();
            enemy.GetHit(amount);
            return amount;
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

        public void GrantXp(int xp){
            Xp += xp;
            this.LevelUp();
        }
        public bool LevelUp(){
            if(Xp >= XpToNextLevel){
                Level++;
                return true;
            }
            return false;
        }
        public bool IsAlive(){
            return Hp > 0;
        }
        public override string ToString(){
            return "Entity";
        }
    }
}
