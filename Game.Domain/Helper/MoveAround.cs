using System;
namespace Game.Domain.Helper{
    public static class MoveAround{
        public static bool IsThereAWall(int position, String dungeon){
            switch(dungeon.Substring(position, 1)){
                case "#":
                    return true;
                case "$":
                    return true;
                case "%":
                    return true;
                case "&":
                    return true;
                default:
                    return false;
            }
        }
        public static void Right(ref int playerPosition, ref String dungeon){
            if(!IsThereAWall(playerPosition+1, dungeon)){
                dungeon = dungeon.Remove(playerPosition, 1);
                dungeon = dungeon.Insert(playerPosition, " ");
                playerPosition += 1;        
                dungeon = dungeon.Remove(playerPosition, 1);
                dungeon = dungeon.Insert(playerPosition, "O");
            }
        }
        public static void Left(ref int playerPosition, ref String dungeon){
            if(!IsThereAWall(playerPosition-1, dungeon)){
                dungeon = dungeon.Remove(playerPosition, 1);
                dungeon = dungeon.Insert(playerPosition, " ");
                playerPosition -= 1;        
                dungeon = dungeon.Remove(playerPosition, 1);
                dungeon = dungeon.Insert(playerPosition, "O");
            }
        }

        public static void Up(ref int playerPosition, ref String dungeon){
            if(!IsThereAWall(playerPosition-14, dungeon)){
                dungeon = dungeon.Remove(playerPosition, 1);
                dungeon = dungeon.Insert(playerPosition, " ");
                playerPosition -= 14;        
                dungeon = dungeon.Remove(playerPosition, 1);
                dungeon = dungeon.Insert(playerPosition, "O");
            }
        }
        public static void Down(ref int playerPosition, ref String dungeon){
            if(!IsThereAWall(playerPosition+14, dungeon)){
                dungeon = dungeon.Remove(playerPosition, 1);
                dungeon = dungeon.Insert(playerPosition, " ");
                playerPosition += 14;        
                dungeon = dungeon.Remove(playerPosition, 1);
                dungeon = dungeon.Insert(playerPosition, "O");
            }
        }

        

    }
}