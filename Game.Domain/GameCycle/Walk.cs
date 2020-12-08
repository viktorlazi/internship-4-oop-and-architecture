using System.Collections.Generic;
using Game.Domain.Helper;
using System;
using Game.Data.Global;
using Game.Data.Enum;

namespace Game.Domain.GameCycle{
    public static class Walk{
        public static void Screen(){

            while(true){
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
        }
    }
}