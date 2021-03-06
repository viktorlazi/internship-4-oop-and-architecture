using System.Collections.Generic;
using System;
using Game.Domain.Helper;
using Game.Data.Models.Entity;
using Game.Data.Global;
using Game.Data.Models.Entity.PlayerClass;
using Game.Data.Models.Entity.NpcClass;
namespace Game.Domain.GameCycle{
    public static class Fight{
        public static void Screen(){
            Entity opponent = DungeonData.NextAliveNpc();
            DungeonData.NewFightLog("\n");
            DungeonData.NewFightLog("Fight (" + (DungeonData.GetNumberOfDeadNpcs()+1) + "): " + opponent.ToString());
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
                            DisplayText.ColorLine("But you ressurected. 50% HP returned", ConsoleColor.Green);
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
                opponent.Stunned=false;
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
                    if(p.Hp <= 0){
                        System.Console.WriteLine("Aaaand... you killed yourself in a charge");
                    }
                    DungeonData.Log(ConsoleColor.Green, "You charge " + enemy.ToString() + " for " + dmg + " and lose 10% hp \t\t" + p.Hp + " | " + enemy.Hp);
                }else{
                    var dmg = p.Hit(enemy);
                    DisplayText.ColorLine("You crush your enemy dealing " + dmg+ " damage.", ConsoleColor.Green);
                    DungeonData.Log(ConsoleColor.Green, "You hit " + enemy.ToString() + " for " + dmg + "\t\t\t\t\t" + p.Hp + " | " + enemy.Hp);
                }
            }else{
                var dmg = p.Hit(enemy);
                DisplayText.ColorLine("You crush your enemy dealing " + dmg + " damage.", ConsoleColor.Green);
                DungeonData.Log(ConsoleColor.Green, "You hit " + enemy.ToString() + " for " + dmg + "\t\t\t\t\t" + p.Hp + " | " + enemy.Hp);
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
            if(p.GrantXp(enemy.Xp)){
                System.Console.WriteLine("You leveled up! +20% max stats");
                UserInput.EnterToContinue();
            }
            p.RegenerateAfterFight();
            if(enemy is Witch){
                SideEnemies(enemy);
            }
            DungeonData.RemoveFirstEnemyVisual();
            if(DungeonData.EnemyLines!=null){
                DungeonData.EnemyLines.RemoveAt(0);
            }
            if(DungeonData.NextAliveNpc() == null){
                End.Won = true;
                End.GameEnded = true;
                UserInput.EnterToContinue();
                return;
            }
        }
        static void LoseFight(){
            End.GameEnded = true;
            End.Won = false;
        }
        static void SideEnemies(Entity enemy){
            List<Entity> sideEnemies = ((Witch)enemy).SpawnFriends();
            foreach(var e in sideEnemies){
                DungeonData.EnemyLines.Insert(0, DungeonData.EnemyLines[0]);
                DungeonData.Npcs.Insert(DungeonData.Npcs.IndexOf((Npc)enemy) + 1, (Npc)e);
            }
            System.Console.WriteLine("A brute and a goblin rise from the witch dead body! You will have to defeat them before moving on to other enemies");
            UserInput.EnterToContinue();
        }   
    }
}