using Game.Data.Global;
namespace Game.Data.Models.Entity.NpcClass
{
    public class Goblin:Npc
    {      
        public Goblin(){
            Hp = DefaultStartValues.GoblinHp;
            Damage = DefaultStartValues.GoblinDmg;
        }
        
        public override  int Attack(){
            return 0;
        }
    }
}
