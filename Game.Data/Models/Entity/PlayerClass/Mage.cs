using Game.Data.Global;
using System;
using System.Collections.Generic;
namespace Game.Data.Models.Entity.PlayerClass
{
    public class Mage:Player
    {      
        public Mage(){
            Hp=DefaultStartValues.MageHp;
            Mana=DefaultStartValues.MageMana;
            Damage=DefaultStartValues.MageDmg;
            DisplayColor=DefaultStartValues.MageColor;
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
        public override string ToString()
        {
            return "Mage";
        }
        public override List<Tuple<string, ConsoleColor, int>> Stats(){
            var Stats = base.Stats();
            Stats.Add(new Tuple<string, ConsoleColor, int>("Mana", System.ConsoleColor.Blue, Mana));

            return Stats;
        }


    }
    
}
