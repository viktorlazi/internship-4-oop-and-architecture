using Game.Data;
using Game.Data.Models.Entity;
using System.Collections.Generic;
using System.Text;
using System;

namespace Game.Data.Global
{
    public static class DungeonData
    {      
        //public static List<Entity> Entities = new List<Entity>();
        public static List<Npc> Npcs = new List<Npc>();

        public static List<int> EnemyLines = new List<int> (){
            4,6,8,10,12,14,16,18,20,22
        };

        public static String Visual = new String(

        //14x24
        "#############\n"+
        "#     $     #\n"+
        "#     $$$$$$#\n"+
        "##      &&% #\n"+
        "#$$ X  %%%% #\n"+
        "# #     ##&/#\n"+
        "#    X      #\n"+
        "#     $$%   #\n"+
        "#  X    ###$#\n"+
        "#           #\n"+
        "#$$%%$%  X  #\n"+
        "#  $%%$%    #\n"+
        "#     %  X  #\n"+
        "#    ##%    #\n"+
        "#     ##  X #\n"+
        "#    ####   #\n"+
        "#         X #\n"+
        "#  %%%$%    #\n"+
        "# X #$%$#$$$#\n"+
        "#      %%%% #\n"+
        "##$$  X     #\n"+
        "# $$        #\n"+
        "##########X##\n"+
        "########## ##\n"
        );

        
        public static string AllNpcsToString(){
            var result = "";
            foreach(var e in Npcs){
                result += e.ToString();
                result += " - ";
            }
            return result;
        }

    }
}
