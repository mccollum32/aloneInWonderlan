using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMethodLibrary;

/**
* Feb 26 23
* CSC 153
* McCollum Joseph
* Console strategy based game gives the user the choice to choose from the menu options using a switch statement.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {                      
            GameLab.Menu();

            double rooms = 5;
            double weapon = 4;
            double treasure = 3;
            double items = 4.0;
            double mob = 5.0;
            double potions = 2.0;

            string menuOptions;
            menuOptions = Console.ReadLine();

            switch (menuOptions)
            {
                case "1":
                    Console.WriteLine("Display Rooms: " + rooms);
                    GameLab.Rooms();
                    break;
                case "2":
                    Console.WriteLine("Display Weapons: " + weapon);
                    GameLab.Weapons();
                    break;
                case "3":
                    Console.WriteLine("Display potion: " + potions);
                    GameLab.Potions();
                    break;
                case "4":
                    Console.WriteLine("Display Treasures: " + treasure);
                    GameLab.Treasure();
                    break;
                case "5":
                    Console.WriteLine("Display Items: " + items);
                    GameLab.Items();
                    break;
                case "6":
                    Console.WriteLine("Display Mobs: " + mob);
                    GameLab.Mobs();
                    break;
                case "7":
                    Console.WriteLine("Exit");
                    break;
            }
            Console.ReadLine();

        }
    }
}
