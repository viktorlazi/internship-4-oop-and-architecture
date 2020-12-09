using System;
using System.Collections.Generic;
using Game.Data.Global;
namespace Game.Data.Models.Entity
{
    public class Player : Entity
    {      
        public int XpToNextLevel {get;set;}
        public Player(){
            Xp = 0;
            Level = 1;
            XpToNextLevel = DefaultStartValues.XpForLevel[2];
        }

        public bool LevelUp(){
            if(Xp >= XpToNextLevel){
                Level++;
                return true;
            }
            return false;
        }
        public int Position{get;set;} = 16;
    }
}
