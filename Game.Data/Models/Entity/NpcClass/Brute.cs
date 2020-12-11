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
        
        public override int Attack(){
            return 0;
        }

        public override string ToString()
        {
            return "Brute";
        }

    }
}
