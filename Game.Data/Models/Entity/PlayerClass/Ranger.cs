using Game.Data.Global;
using System;
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
            MaxHp = Hp;
        }

        public int CriticalChance {get;set;} 
        public int StunChance {get;set;}

        public bool StunAttack(){
            var random = new Random();
            int randomInt = random.Next(0, 100);
            if(randomInt < StunChance){
                return true;
            }else{
                return false;
            }
        }
        public int CriticalAttack(){
            var random = new Random();
            int randomInt = random.Next(0, 100);
            if(randomInt < CriticalChance){
                System.Console.WriteLine("Critical Attack!"); 
                return Damage;
            }else{
                return 0;
            }
        }
        public override int Hit(Entity enemy){
            var baseDmg = base.Hit(enemy);
            var criticalDmg = CriticalAttack();
            if(StunAttack()){
                System.Console.WriteLine("You stunned your enemy!");
                enemy.Stunned = true;
            }
            if(criticalDmg != 0){
                enemy.GetHit(criticalDmg);
                return baseDmg+criticalDmg;
            }else{
                return baseDmg;
            }
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
