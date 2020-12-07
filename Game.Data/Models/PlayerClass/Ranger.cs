
namespace Game.Data.Models.PlayerClass
{
    public class Ranger:Player
    {      
        public Ranger(){

        }
        public double CriticalChance {get;set;} 
        public double StunChance {get;set;}

        public override double Attack(){
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
