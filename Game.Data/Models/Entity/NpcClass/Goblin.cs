using Game.Data.Global;
namespace Game.Data.Models.Entity.NpcClass
{
    public class Goblin:Npc
    {      
        public Goblin(){
            Hp = DefaultStartValues.GoblinHp;
            Damage = DefaultStartValues.GoblinDmg;
            DisplayColor=DefaultStartValues.GoblinColor;
        }
        
        public override int Attack(){
            return 0;
        }

        public override string ToString()
        {
            return "Goblin";
        }
    }
}
