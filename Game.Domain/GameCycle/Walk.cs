using System.Collections.Generic;
using Game.Domain.Helper;
using System;
using Game.Data.Global;
using Game.Data.Enum;


namespace Game.Domain.GameCycle{
    public static class Walk{
        public static void Screen(){

            while(!InEnemyLine()){
                DisplayText.PrintDungeon(PlayerData.Player1.Position);
                var OvajJezikJeRetardiran = PlayerData.Player1.Position;
                switch(UserInput.ReadDirection()){
                    case Direction.Up: MoveAround.Up(ref OvajJezikJeRetardiran, ref DungeonData.Visual); break;
                    case Direction.Down: MoveAround.Down(ref OvajJezikJeRetardiran, ref DungeonData.Visual); break;
                    case Direction.Right: MoveAround.Right(ref OvajJezikJeRetardiran, ref DungeonData.Visual); break;
                    case Direction.Left: MoveAround.Left(ref OvajJezikJeRetardiran, ref DungeonData.Visual); break;
                }
                PlayerData.Player1.Position = OvajJezikJeRetardiran;
            }

            DisplayText.PrintDungeon(PlayerData.Player1.Position);
            System.Console.WriteLine("An enemy is attacking you! Quickly prepare for battle!");

            UserInput.EnterToContinue();
        }


        public static bool InEnemyLine(){
            var pos = PlayerData.Player1.Position;

            foreach(var enemyLine in DungeonData.EnemyLines){
                if(pos >= 14*enemyLine){
                    return true;
                }
            }
            return false;
        }
    }
}