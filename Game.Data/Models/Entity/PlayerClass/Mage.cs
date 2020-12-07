
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

        public static string PrintPowers(){
            return "Power of mage is the power of energies.\n" +
                "\t-Less HP, but more damage\n" +
                "\t-Uses mana for spells\n" +
                "\t-Special ability: Ressurect, can rise back from the dead once";
        }
    }
    
}
