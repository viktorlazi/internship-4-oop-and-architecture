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
            MaxHp = Hp;
            MaxMana = Mana;
        }
        
        public int Mana {get;set;}
        public int MaxMana{get;set;}
        public bool Has2Lifes {get;set;} = true;

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
        public override List<Tuple<string, ConsoleColor, string>> Stats(){
            var Stats = base.Stats();
            Stats.Add(new Tuple<string, ConsoleColor, string>("Mana", System.ConsoleColor.Blue, Mana.ToString() + "/" + MaxMana));

            return Stats;
        }

        public override int Hit(Entity enemy){
            int amount = base.Hit(enemy);
            Mana -= amount;
            return amount;
        }
        public bool Ressurect(){
            if(Has2Lifes){
                Hp = DefaultStartValues.MageHp/2;
                Has2Lifes = false;
                return true;
            }else{
                return false;
            }
        }
    }
}
