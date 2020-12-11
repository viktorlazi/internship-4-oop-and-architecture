using Game.Data.Global;
using System.Collections.Generic;
using System;
namespace Game.Data.Models.Entity.NpcClass
{
    public class Witch:Npc
    {      
        public Witch(){
            Hp = DefaultStartValues.WitchHp;
            Damage = DefaultStartValues.WitchDmg;
            DisplayColor=DefaultStartValues.WitchColor;
            MaxHp = Hp;
            Xp = DefaultStartValues.WitchXp;
        }
        
        public override int Hit(Entity enemy){
            var random = new Random();
            int randomInt = random.Next(1,100);

            if(randomInt < DefaultStartValues.WitchDjumbusChance){
                Djumbus(DungeonData.Npcs, (Player)enemy);
                return 0;
            }else{
                return base.Hit(enemy);
            }
        }
        public void Djumbus(List<Npc> npcs, Player p){
            Random random;int randomNumber;

            foreach(var npc in npcs){
                random = new Random();
                randomNumber = random.Next(10,100);
                npc.Hp = (int) ((npc.Hp*randomNumber)/100);
            }
            random = new Random();
            randomNumber = random.Next(10,100);
            p.Hp = (int)((p.Hp*randomNumber)/100);
            random = new Random();
            randomNumber = random.Next(10,100);
            Hp = (int)((Hp*randomNumber)/100);
            System.Console.WriteLine("Đumbus!");
        }

        public override string ToString()
        {
            return "Witch";
        }
    }
}
