using System.Collections.Generic;
using System;
using Game.Domain.Helper;
using Game.Data.Models.Entity;
using Game.Data.Global;
using Game.Data.Models.Entity.PlayerClass;
using Game;
using Game.Data.Models.Entity.NpcClass;
namespace Game.Domain.GameCycle{
    public static class Fight{
        public static void Screen(){
            DungeonData.FightLog.Clear();
            Entity opponent = DungeonData.NextAliveNpc();
            if(opponent == null){
                End.GameEnded = true;
                End.Won = true;
                return;
            }
            Player player = PlayerData.Player1;
            Console.Clear();
            while(true){
                if(!player.IsAlive()){
                    DisplayText.ColorLine("You died. Tragedy.", ConsoleColor.Red);
                    if(player is Mage){
                        if(((Mage)player).Has2Lifes){
                            ((Mage)player).Ressurect();
                            DisplayText.ColorLine("But you ressurected, jebe se tebe.", ConsoleColor.Green);
                        }else{
                            DisplayText.ColorLine("Again... Dissapointment.", ConsoleColor.Blue);
                            LoseFight();
                            return;
                        }
                    }else{
                        LoseFight();
                        return;
                    }
                    UserInput.EnterToContinue();
                }
                if(!opponent.IsAlive()){
                    DisplayText.ColorLine("You killed the " + opponent.ToString(), ConsoleColor.Green);
                    UserInput.EnterToContinue();
                    WinFight(player, opponent);
                    return;
                }
                
                if(ChooseAttacker(player, opponent)){
                    Attack(player, opponent);
                }else{
                    Defend(player, opponent);
                }
                
                UserInput.EnterToContinue();
            }
        }
        static void GameHeader(Player you, Entity enemy){
            DisplayText.DashWall();
            System.Console.Write("You: "); DisplayText.ColorLine(you.ToString(), PlayerData.Player1.DisplayColor, ConsoleColor.DarkGray); 
            DisplayText.PlayerStats(PlayerData.Player1);
            DisplayText.DashWall();
            System.Console.Write("Enemy: "); DisplayText.ColorLine(enemy.ToString(), enemy.DisplayColor, ConsoleColor.DarkGray); 
            DisplayText.EnemyStats(enemy);
            System.Console.WriteLine();
            DisplayText.DashWall();
            DisplayText.DashWall();
        }

        static bool ChooseAttacker(Player player, Entity opponent){
            if(player.Stunned){
                DisplayText.ColorLine("You are stunned", ConsoleColor.Red);
                return false;
            }
            if(opponent.Stunned){
                DisplayText.ColorLine("You stunned your enemy, so you get to attack again", ConsoleColor.Green);
                return true;
            }

            while(true){
                Console.Clear();
                GameHeader(player, opponent);
                var playerStrat = UserInput.Strategy();
                var npcStrat = Npc.Strategy();

                System.Console.Write("Enemy played: ");

                if(playerStrat == Data.Enum.Strategy.DirectAttack){
                    switch(npcStrat){
                        case Data.Enum.Strategy.DirectAttack: DisplayText.ColorLine("The same as you", ConsoleColor.Gray); break;
                        case Data.Enum.Strategy.SideAttack: DisplayText.ColorLine("Side Attack", ConsoleColor.Green); return true;
                        case Data.Enum.Strategy.CounterAttack: DisplayText.ColorLine("Counter Attack", ConsoleColor.Red); return false;
                    }
                }else if(playerStrat == Data.Enum.Strategy.SideAttack){
                    switch(npcStrat){
                        case Data.Enum.Strategy.DirectAttack: DisplayText.ColorLine("Direct Attack", ConsoleColor.Red); return false;
                        case Data.Enum.Strategy.SideAttack: DisplayText.ColorLine("The same as you", ConsoleColor.Gray); break;
                        case Data.Enum.Strategy.CounterAttack: DisplayText.ColorLine("Counter Attack", ConsoleColor.Green); return true;
                    }
                }else if(playerStrat == Data.Enum.Strategy.CounterAttack){
                    switch(npcStrat){
                        case Data.Enum.Strategy.DirectAttack: DisplayText.ColorLine("Direct Attack", ConsoleColor.Green); return true;
                        case Data.Enum.Strategy.SideAttack: DisplayText.ColorLine("Side Attack", ConsoleColor.Red); return false;
                        case Data.Enum.Strategy.CounterAttack: DisplayText.ColorLine("The same as you", ConsoleColor.Gray); break;
                    }
                }
                System.Console.WriteLine("Try again");
                UserInput.EnterToContinue();              
            }
        }
        static void Attack(Player p, Entity enemy){
            DisplayText.ColorLine("You outplayed your enemy!", ConsoleColor.Yellow);
            if(p is Warrior){
                DisplayText.ColorLine("If you want to charge your enemy type 'charge', enter for normal attack", ConsoleColor.Magenta);
                if(Console.ReadLine() == "charge"){
                    var dmg = ((Warrior)p).Charge(enemy);
                    DisplayText.ColorLine("You charge your enemy with " + dmg + " damage at the cost of 10% HP", ConsoleColor.Yellow);
                    DungeonData.Log(ConsoleColor.Green, "You charge " + enemy.ToString() + " for " + dmg + " and lose 10% hp \t\t\t\t" + p.Hp + " | " + enemy.Hp);
                }else{
                    var dmg = p.Hit(enemy);
                    DisplayText.ColorLine("You crush your enemy dealing " + dmg+ " damage.", ConsoleColor.Green);
                    DungeonData.Log(ConsoleColor.Green, "You hit " + enemy.ToString() + " for " + dmg + "\t\t\t\t" + p.Hp + " | " + enemy.Hp);
                }
            }else{
                var dmg = p.Hit(enemy);
                DisplayText.ColorLine("You crush your enemy dealing " + dmg + " damage.", ConsoleColor.Green);
                DungeonData.Log(ConsoleColor.Green, "You hit " + enemy.ToString() + " for " + dmg + "\t\t\t\t" + p.Hp + " | " + enemy.Hp);
            }
        }
        static void Defend(Player p, Entity enemy){
            DisplayText.ColorLine("You got outplayed.", ConsoleColor.Yellow);
            var dmg = enemy.Hit(p);
            DisplayText.ColorLine(
                enemy.ToString() + " hits you dealing " + dmg + " damage.", ConsoleColor.Red
            );
            DungeonData.Log(ConsoleColor.Red, "You get hit by " + enemy.ToString() + " for " + dmg + "\t\t\t\t" + p.Hp + " | " + enemy.Hp);
        }       
        static void WinFight(Player p, Entity enemy){
            p.GrantXp(enemy.Xp);
            DungeonData.RemoveFirstEnemyVisual();
            if(DungeonData.EnemyLines.Count > 0){
                DungeonData.EnemyLines.RemoveAt(0);
            }else{
                End.Won = true;
                End.GameEnded = true;
            }
            p.RegenerateAfterFight();
        }
        static void LoseFight(){
            End.GameEnded = true;
            End.Won = false;
        }
    }
}