using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameMethodLibrary
{
    public static class GameLab
    {
        public static void Menu()
        {
            Console.WriteLine("***---***---Alone In Wonderland---***---***");
            Console.WriteLine("");
            Console.WriteLine("Choose from the following options. ");
            Console.WriteLine(" Main Menu \n 1. Display Rooms   \n 2. Display Weapon \n 3. Display Potion \n 4. Display Treasures \n 5. Display Items \n 6. Display Mobs \n 7. Exit");
            Console.WriteLine("");
            Console.WriteLine("***---------*******************---------***");
        }
        public static void Rooms()
        {
            Console.WriteLine("1. Entry way");
            Console.WriteLine("2. Hallway");
            Console.WriteLine("3. Kitchen");
            Console.WriteLine("4. Backyard");
            Console.WriteLine("5. Street");
        }
        public static void Weapons()
        {
            Console.WriteLine("1. Knife");
            Console.WriteLine("2. Screwdriver");
            Console.WriteLine("3. Baseball bat");
            Console.WriteLine("4. None (Hands)");
        }
        public static void Treasure()
        {
            Console.WriteLine("1. Gold");
            Console.WriteLine("2. Jewlery");
            Console.WriteLine("3. Diamond");
        }
        public static void Items()
        {
            Console.WriteLine("1. Key");
            Console.WriteLine("2. Repel");
            Console.WriteLine("3. Documents");
            Console.WriteLine("4. Bottle");
        }
        public static void Mobs()
        {
            Console.WriteLine("1. Wild bear");
            Console.WriteLine("2. Looters");
            Console.WriteLine("3. Fungal Mob");
            Console.WriteLine("4. Infected foot soliders (3)");
            Console.WriteLine("5. Wild Dogs");
        }
        public static void Potions()
        {
            Console.WriteLine("1. Partial Potion");
            Console.WriteLine("2. Super Potion");
        }
    }
}

//Items
//Mobs