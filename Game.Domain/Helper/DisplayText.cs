using System;
namespace Game.Domain.Helper{
    public static class DisplayText{
        public static void Color(string text, ConsoleColor color){
            Console.ForegroundColor = color;
            System.Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ColorLn(string text, ConsoleColor color){
            Console.ForegroundColor = color;
            System.Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Color(string text, ConsoleColor color, ConsoleColor backColor){
            Console.ForegroundColor = color;
            Console.BackgroundColor = backColor;
            System.Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ColorLn(string text, ConsoleColor color, ConsoleColor backColor){
            Console.ForegroundColor = color;
            Console.BackgroundColor = backColor;
            System.Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}