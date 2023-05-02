using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMethodLibrary;
using System.IO;

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
            bool end = false;

            int choices;
            choices = Convert.ToInt32(Console.ReadLine());

            while (end == false)
            {
                switch (choices)
                {
                    case 1:
                        Console.WriteLine("**********");
                        Console.WriteLine("Rooms: " + rooms);
                        GameLab.Rooms();
                        break;
                    case 2:
                        Console.WriteLine("**********");
                        Console.WriteLine("Weapons: " + weapon);
                        GameLab.Weapons();
                        break;
                    case 3:
                        Console.WriteLine("**********");
                        Console.WriteLine("Potions: " + potions);
                        GameLab.Potions();
                        break;
                    case 4:
                        Console.WriteLine("**********");
                        Console.WriteLine("Treasure: " + treasure);
                        GameLab.Treasure();
                        break;
                    case 5:
                        Console.WriteLine("**********");
                        Console.WriteLine("Items: " + items);
                        GameLab.Items();
                        break;
                    case 6:
                        Console.WriteLine("**********");
                        Console.WriteLine("Mobs: " + mob);
                        GameLab.Mobs();
                        break;
                    case 7:
                        Console.WriteLine("**********");
                        Console.WriteLine("Starting Game. ");
                        GameLoop.GameRun();
                        break;
                    case 8:
                        Console.WriteLine("**********");
                        Console.WriteLine("Exiting Program!");
                        break;
                    default:
                        Console.WriteLine("Invalid entry! Try again.");
                        break;
                }
                if (choices == 1 || choices == 2 || choices == 3 || choices == 4 || choices == 5 || choices == 6 || choices == 8)
                {
                    end = true;
                }
                else
                {
                    GameLoop.GameRun();
                }
            }
            
            Console.ReadKey();
        }
    }
    class GameLoop
    {

        public static void GameRun()
        {
            bool end = false;

            while (end == false)
            {
                Console.WriteLine("What is your name? ");
                string name = Console.ReadLine();
                Console.WriteLine("Welcome to WonderLand " + name + " this is a strategy based game so use your brain and dont get carless in there!");
            }
        }
    }
}
