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
        public virtual void RegenerateAfterFight(){
            Hp+=(int)(MaxHp*0.25);
        }
        public void GrantXp(int xp){
            Xp += Xp;
            this.LevelUp();
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
