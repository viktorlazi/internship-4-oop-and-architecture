using Game.Data.Global;
namespace Game.Data.Models.Entity.NpcClass
{
    public class Goblin:Npc
    {      
        public Goblin(){
            Hp = DefaultStartValues.GoblinHp;
            Damage = DefaultStartValues.GoblinDmg;
            DisplayColor=DefaultStartValues.GoblinColor;
            MaxHp = Hp;
            Xp = DefaultStartValues.GoblinXp;
        }
        public override string ToString()
        {
            return "Goblin";
        }
    }
}
