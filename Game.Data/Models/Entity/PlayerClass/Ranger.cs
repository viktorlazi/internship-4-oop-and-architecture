using Game.Data.Global;
namespace Game.Data.Models.Entity.PlayerClass
{
    public class Ranger:Player
    {      
        public Ranger(){
            Hp=DefaultStartValues.RangerHp;
            Damage=DefaultStartValues.RangerDmg;
            CriticalChance=DefaultStartValues.RangerCritChance;
            StunChance=DefaultStartValues.RangerStunChance;      
            DisplayColor=DefaultStartValues.RangerColor; 
        }

        public double CriticalChance {get;set;} 
        public double StunChance {get;set;}

        bool StunAttack(){
            return false;
        }
        bool CriticalAttack(){
            Damage=DefaultStartValues.RangerCritDmg;
            return false;
        }
        
        public static string PrintPowers(){
            return "Power of ranger is power of the wild.\n" +
                "\t-Normal HP and damage\n" +
                "\t-Chance for a critical attack\n" +
                "\t-Chance to stun on attack\n";
        }

        public override string ToString()
        {
            return "Ranger";
        }
    }
}
