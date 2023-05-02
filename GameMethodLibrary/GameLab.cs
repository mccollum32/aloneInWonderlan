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
            Console.WriteLine(" Main Menu \n 1. Display Rooms   \n 2. Display Weapon \n 3. Display Potion \n 4. Display Treasures \n 5. Display Items \n 6. Display Mobs \n 7. Start Game \n 8. Exit");
            Console.WriteLine("");
            Console.WriteLine("***---------*******************---------***");
        }
        public static void Rooms()
        {
            const string path = "G:/Programming/aloneInWonderlan/ConsoleAppUI/rooms.txt";
            StreamReader read = new StreamReader(path);

            var line = read.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = read.ReadLine();
            }
            read.Close();
        }

        public static void Weapons()
        {
                const string path = "G:/Programming/aloneInWonderlan/ConsoleAppUI/weapon.txt";
                StreamReader read = new StreamReader(path);

                var line = read.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = read.ReadLine();
                }
                read.Close();
        }
        public static void Treasure()
        {
            const string path = "G:/Programming/aloneInWonderlan/ConsoleAppUI/treasure.txt";
            StreamReader read = new StreamReader(path);

            var line = read.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = read.ReadLine();
            }
            read.Close();
        }
        public static void Items()
        {
            const string path = "G:/Programming/aloneInWonderlan/ConsoleAppUI/items.txt";
            StreamReader read = new StreamReader(path);

            var line = read.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = read.ReadLine();
            }
            read.Close();
        }
        public static void Mobs()
        {
            const string path = "G:/Programming/aloneInWonderlan/ConsoleAppUI/mob.txt";
            StreamReader read = new StreamReader(path);

            var line = read.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = read.ReadLine();
            }
            read.Close();     
        }     
        public static void Potions()
        {
            const string path = "G:/Programming/aloneInWonderlan/ConsoleAppUI/potion.txt";
            StreamReader read = new StreamReader(path);

            var line = read.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = read.ReadLine();
            }
            read.Close();
        }
    }
}
