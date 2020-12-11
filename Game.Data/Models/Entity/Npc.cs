using System;
using Game.Data.Global;
using Game.Data.Models.Entity.NpcClass;
using System.Collections.Generic;
namespace Game.Data.Models.Entity
{
    public class Npc : Entity
    {  
           
        public override List<Tuple<string, ConsoleColor, string>> Stats(){
            List<Tuple<string, ConsoleColor, string>> baseStats = base.Stats();
            baseStats.Remove(new Tuple<string, ConsoleColor, string>("Xp", ConsoleColor.White, Xp.ToString() + "/" + XpToNextLevel.ToString()));
            return baseStats;            
        }
    
        public static Npc RandomSpawn(){
            var random = new Random();
            int randomNumber = random.Next(0,100);

            var i = 0; 
            foreach(var probability in DefaultStartValues.SpawnChances){
                if(randomNumber >= i && randomNumber < probability.Value + i){
                    return Spawn(probability.Key);
                }
                i+=probability.Value;
            }
            return new Npc();
        }

        public static Npc Spawn(Enum.Npc type){
            switch(type){
                case Enum.Npc.Goblin:
                    return new Goblin();
                case Enum.Npc.Brute:
                    return new Brute();
                case Enum.Npc.Witch:
                    return new Witch();
                default:
                    return new Goblin();                
            }   
        }
        public static Enum.Strategy Strategy(){
            var random = new Random();
            int randomAttack = random.Next(0, 3);
            return (Enum.Strategy)randomAttack;
        }
        public override string ToString()
        {
            return "Npc";
        }
        
    }
}
