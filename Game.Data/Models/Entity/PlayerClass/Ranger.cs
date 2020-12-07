
namespace Game.Data.Models.Entity.PlayerClass
{
    public class Ranger:Player
    {      
        public Ranger(){

        }
        public double CriticalChance {get;set;} 
        public double StunChance {get;set;}

        public override int Attack(){
            return 0;
        }

        bool StunAttack(){
            return false;
        }
        bool CriticalAttack(){
            return false;
        }
        
    }
}
