using System;
using Game.Data.Global;
namespace Game.Data.Models.Entity.NpcClass
{
    public class Brute:Npc
    {      
        public Brute(){
            Hp = DefaultStartValues.BruteHp;
            Damage =DefaultStartValues.BruteDmg;
            DisplayColor=DefaultStartValues.BruteColor;
            MaxHp = Hp;
            Xp = DefaultStartValues.BruteXp;
        }
        public override int Hit(Entity enemy){
            var random = new Random();
            int randomInt = random.Next(1,100);

            if(randomInt < DefaultStartValues.BruteSlamChance){
                var amount = (int)(enemy.MaxHp * DefaultStartValues.BruteSlamDmg/100);
                enemy.GetHit(amount);
                System.Console.WriteLine($"Brute slams! Taking {DefaultStartValues.BruteSlamDmg}% of your hp.");
                return amount;
            }else{
                return base.Hit(enemy);
            }
        }

        public override string ToString()
        {
            return "Brute";
        }

    }
}
