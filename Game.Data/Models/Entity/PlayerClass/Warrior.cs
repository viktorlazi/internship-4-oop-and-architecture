using Game.Data.Global;
namespace Game.Data.Models.Entity.PlayerClass
{
    public class Warrior:Player
    {      
        public Warrior(){
            Hp=DefaultStartValues.WarriorHp;
        }

        public override int Attack(){
            return 0;
        }
        int RageAttack(){
            return 0;
        }

        public static string PrintPowers(){
            return "Power of warrior is the power of strenght and ferocity.\n" +
                "\t-Extra HP, but less damage\n" +
                "\t-Special ability: Charge, double damage on cost of 15% HP";
                
        }
        
    }
}
