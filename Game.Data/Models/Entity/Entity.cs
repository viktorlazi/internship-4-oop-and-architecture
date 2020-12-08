using System;
namespace Game.Data.Models.Entity
{
    public class Entity
    {      
        public string Name {get;set;}
        public int Hp {get;set;}
        public int Damage {get;set;}
        public bool isAlive{get;set;} = true;

        public ConsoleColor DisplayColor{get;set;}
        public virtual int Attack(){
            return 0;
        }

        public override string ToString(){
            return "Entity";
        }
    }
}
