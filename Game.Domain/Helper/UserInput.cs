using System;
using Game.Data.Enum;
namespace Game.Domain.Helper{
    public static class UserInput{
        public static void EnterToContinue(){
            System.Console.WriteLine();
            Console.ReadLine();
        }

        public static Direction ReadDirection(){
            Console.Write("Wasd to move: ");
            var input = Console.ReadLine();
            switch(input){
                case "W": return Direction.Up;
                case "w": return Direction.Up;
                case "A": return Direction.Left;
                case "a": return Direction.Left;
                case "S": return Direction.Down;
                case "s": return Direction.Down;
                case "D": return Direction.Right;
                case "d": return Direction.Right;
                default: return Direction.NoDirection;
            }
        }
    }
}