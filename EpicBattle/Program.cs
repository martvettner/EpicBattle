using System;
using System.Dynamic;
using System.Globalization;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Retakas", "Luke Skywalker", "Superman", "Maria Under", "Mart Laar" };
            string[] villians = { "Goblin Raks", "Plankton", "Pede Roosa", "Mingi Ahv", "Valdis" };

            string hero = GetChar(heroes);
            string villian = GetChar(villians);
            int HeroHP = GetHP();
            int villianHP = GetHP();

            Console.WriteLine($"{hero} with {HeroHP} HP will fight {villian} with " + 
                $"{villianHP} HP");

             WinGenerator(HeroHP, villianHP);            

            Console.ReadLine();
        }
        public static string GetChar(string[] array)
        {
            Random rd = new Random();
            string randomstring = array[rd.Next(0, array.Length)];
            return randomstring;
        }
        public static int GetHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);            
            return HP;            
        }
        public static void WinGenerator(int HeroHP, int villianHP)
        {
            while (HeroHP > 0 && villianHP > 0)
            {
                Random rnd = new Random();
                HeroHP = HeroHP - rnd.Next(0, 4);
                villianHP = villianHP - rnd.Next(0, 4);
            }
            if (HeroHP == 0)
            {
                Console.WriteLine("Dark side won this time");
            }
            else
            {
                Console.WriteLine("Hero saves the day!");
            }
        

        }
        public static int Hit(string Char)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, 4);
            Console.WriteLine($"{Char} hit {strike}!");

            if(strike == 3)
            {
                Console.WriteLine($"Awsome! {Char} made critical hit");
            }
            else if (strike == 0)
            {
                Console.WriteLine($"Bad luck {Char} missed the target");
            }
            return strike;
        }
    }
}
