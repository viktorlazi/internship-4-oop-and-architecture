using Game.Data.Global;
namespace Game.Data.Models.Entity.NpcClass
{
    public class Brute:Npc
    {      
        public Brute(){
            Hp = DefaultStartValues.BruteHp;
            Damage =DefaultStartValues.BruteDmg;
        }
        
        public override int Attack(){
            return 0;
        }

    }
}
