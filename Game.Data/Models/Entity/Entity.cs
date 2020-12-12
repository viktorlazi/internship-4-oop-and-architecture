using System;
using System.Collections.Generic;
using Game.Data.Global;
namespace Game.Data.Models.Entity
{
    public class Entity
    {      
        public Entity(){
            Level = 1;
            XpToNextLevel = DefaultStartValues.XpForLevel[2];
        }
        public int Hp {get;set;}
        public int MaxHp{get;set;}
        public int Damage {get;set;}        
        public int Xp {get;set;}
        public int XpToNextLevel {get;set;}        
        public int Level {get;set;}
        
        public bool Stunned{get;set;} = false;

        public ConsoleColor DisplayColor{get;set;}
        public virtual int Attack(){
            return 0;
        }
        public virtual List<Tuple<string, ConsoleColor, string>> Stats(){
            return new List<Tuple<string, ConsoleColor, string>>(){
                new Tuple<string, ConsoleColor, string>("Xp", ConsoleColor.White, Xp.ToString() + "/" + XpToNextLevel.ToString()),
                new Tuple<string, ConsoleColor, string>("Level", ConsoleColor.White, Level.ToString()),
                new Tuple<string, ConsoleColor, string>("Hp", ConsoleColor.Red, Hp.ToString() + "/" + MaxHp.ToString()),
                new Tuple<string, ConsoleColor, string>("Damage", ConsoleColor.Yellow, Damage.ToString())
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
            int randomAttack = random.Next(-1 + (int)(-Damage*0.2), 1 + (int)(Damage*0.2));
            return randomAttack;
        }

        public bool GrantXp(int xp){
            Xp += xp;
            return LevelUp();
        }
        public bool LevelUp(){
            if(Xp >= XpToNextLevel){
                Level++;
                XpToNextLevel = DefaultStartValues.XpForLevel[Level+1];
                UpdateStatsForLevelUp();
                return true;
            }
            return false;
        }
        protected virtual void UpdateStatsForLevelUp(){
            MaxHp += (int)(MaxHp*0.2);
            Damage += (int)(Damage*0.2);
        }
        public bool IsAlive(){
            return Hp > 0;
        }
        
        public override string ToString(){
            return "Entity";
        }
    }
}
