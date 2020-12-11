using Game.Data.Global;
using System.Collections.Generic;
namespace Game.Data.Models.Entity.PlayerClass
{
    public class Warrior:Player
    {      
        public Warrior(){
            Hp=DefaultStartValues.WarriorHp;
            Damage = DefaultStartValues.WarriorDmg;
            DisplayColor=DefaultStartValues.WarriorColor;
            MaxHp = Hp;
        }

        public int Charge(Entity enemy){
            Hp-=(int)(MaxHp*0.1);
            var dmg = 3*Damage + RandomizeDamage();
            enemy.GetHit(dmg);
            return dmg;
        }

        public static string PrintPowers(){
            return "Power of warrior is the power of strenght and ferocity.\n" +
                "\t-Extra HP, but less damage\n" +
                "\t-Special ability: Charge, double damage on cost of 10% HP";                
        }       

        public override string ToString()
        {
            return "Warrior";
        }
    }
}
