using System;
using Game.Data.Global;
using Game.Data.Models.Entity.NpcClass;
namespace Game.Data.Models.Entity
{
    public class Npc : Entity
    {      
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

        public override string ToString()
        {
            return "Npc";
        }
        
    }
}
