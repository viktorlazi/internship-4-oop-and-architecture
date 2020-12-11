using Game.Data.Global;
namespace Game.Data.Models.Entity.NpcClass
{
    public class Witch:Npc
    {      
        public Witch(){
            Hp = DefaultStartValues.WitchHp;
            Damage = DefaultStartValues.WitchDmg;
            DisplayColor=DefaultStartValues.WitchColor;
            MaxHp = Hp;
            Xp = DefaultStartValues.WitchXp;
        }
        
        public override int Attack(){
            return 0;
        }

        public override string ToString()
        {
            return "Witch";
        }
    }
}
