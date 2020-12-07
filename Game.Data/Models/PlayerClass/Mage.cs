
namespace Game.Data.Models.PlayerClass
{
    public class Mage:Player
    {      
        public Mage(){
            
        }
        public int Mana {get;set;}
        public bool Has2Lifes {get;set;} = true;
        public override double Attack(){
            return 0;
        }
    }
}
