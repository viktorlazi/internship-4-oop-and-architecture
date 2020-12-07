
namespace Game.Data.Global
{
    public static class DefaultStartValues
    {      
        public static int WarriorHp = 75;
        public static int WarriorDmg = 6;

        public static int RangerHp = 100;
        public static int RangerDmg = 9;
        public static int RangerCritDmg = RangerDmg+4;
        public static double RangerCritChance = 0.3;
        public static double RangerStunChance = 0.1;
        
        public static int MageHp = 125;
        public static int MageDmg = 14;
        public static int MageMana = 100;

        public static int GoblinHp = 45;
        public static int GoblinDmg = 5;

        public static int WitchHp = 55;
        public static int WitchDmg = 4;
        public static double WitchSpawnChance = 0.1;

        public static int BruteHp = 200;
        public static int BruteDmg = 13;
        public static double BruteSlamChance = 0.2;
        public static double BruteSlamDmg = 0.3;
        public static double BruteSpawnChance = 0.35;


    }
}
