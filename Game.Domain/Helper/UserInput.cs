using System;
using Game.Data.Enum;
namespace Game.Domain.Helper{
    public static class UserInput{
        public static void EnterToContinue(){
            System.Console.WriteLine();
            DisplayText.Color(" - enter - ", ConsoleColor.DarkGray);
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

        public static Game.Data.Enum.Strategy Strategy(){

            while(true){
                Console.WriteLine("Choose strategy! (0 - Direct Attack, 1 - Side Attack, 2 - Counter Attack");
                var input = Console.ReadLine();
                try{
                    switch(int.Parse(input)){
                        case 0: return Game.Data.Enum.Strategy.DirectAttack;
                        case 1: return Game.Data.Enum.Strategy.SideAttack;
                        case 2: return Game.Data.Enum.Strategy.CounterAttack;
                        default: break;
                    }
                }catch{}
                System.Console.WriteLine("Invalid input");
                
            }
        }
    }
}