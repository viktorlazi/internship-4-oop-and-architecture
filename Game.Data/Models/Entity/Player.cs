using System;
using System.Collections.Generic;
using Game.Data.Global;
namespace Game.Data.Models.Entity
{
    public class Player : Entity
    {   
        public Player(){
            Xp = 0;
            Level = 1;
            XpToNextLevel = DefaultStartValues.XpForLevel[2];
        }
        public virtual void RegenerateAfterFight(){
            Hp+=(int)(MaxHp*0.25);
            if(Hp > MaxHp){
                Hp = MaxHp;
            }
        }
        public int Position{get;set;} = 16;
    }
}
