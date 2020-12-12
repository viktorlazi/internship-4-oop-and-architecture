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
        public static Npc NextAliveNpc(){
            foreach(var npc in Npcs){
                if(npc.IsAlive()){
                    return npc;
                }
            }
            return null;
        }

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
        "#### X      #\n"+
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
        public static void ResetVisual(){
            Visual = new String(
            //14x24
            "#############\n"+
            "#     $     #\n"+
            "#     $$$$$$#\n"+
            "##      &&% #\n"+
            "#$$ X  %%%% #\n"+
            "# #     ##&/#\n"+
            "#### X      #\n"+
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
        }
        public static void RemoveFirstEnemyVisual(){
            var firstX = DungeonData.Visual.IndexOf('X',EnemyLines[0]*14,14);
            if(firstX != -1){
                Visual = Visual.Remove(firstX, 1);
                Visual = Visual.Insert(firstX, " ");
            }
        }
        public static string AllNpcsToString(){
            var result = "";
            foreach(var e in Npcs){
                result += e.ToString();
                result += " - ";
            }
            return result;
        }
        public static List<Tuple<ConsoleColor, string>> FightLog = new List<Tuple<ConsoleColor, string>>(){};

        public static void Log(ConsoleColor color, string msg){
            DungeonData.FightLog.Add(new Tuple<ConsoleColor, string>(color, msg));
        }
        public static void NewFightLog(string msg){
            DungeonData.FightLog.Add(new Tuple<ConsoleColor, string>(ConsoleColor.White, msg));
        }
    }
}
