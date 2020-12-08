using Game.Data;
using Game.Data.Models.Entity;
using System.Collections.Generic;
using System;

namespace Game.Data.Global
{
    public static class DungeonData
    {      
        public static List<Entity> Entities = new List<Entity>();
        public static List<Npc> Npcs = new List<Npc>();
        
        public static string AllEntitiesToString(){
            var result = "";
            foreach(var e in Entities){
                result += e.ToString();
                result += " - ";
            }
            return result;
        }

    }
}
