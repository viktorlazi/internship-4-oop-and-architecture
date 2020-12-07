using Game.Data.Global;
namespace Game.Data.Models.Entity.NpcClass
{
    public class Witch:Npc
    {      
        public Witch(){
            Hp = DefaultStartValues.WitchHp;
        }
        
        public override int Attack(){
            return 0;
        }
    }
}
