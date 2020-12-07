using System.Collections.Generic;

namespace Game.Data.Models.Entity
{
    public static class EveryEntity
    {      
        public static List<Entity> List{get;set;}
        
        public static void ChangeHp(int amount){
            foreach(var entity in List){
                entity.Hp += amount;
            }
        }
    }
}
