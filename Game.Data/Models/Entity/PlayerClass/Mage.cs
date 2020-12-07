
namespace Game.Data.Models.Entity.PlayerClass
{
    public class Mage:Player
    {      
        public Mage(){
            
        }
        public int Mana {get;set;}
        public bool Has2Lifes {get;set;} = true;
        public override int Attack(){
            return 0;
        }
    }
}
