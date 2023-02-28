using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* Feb 26 23
* CSC 153
* McCollum Joseph
* Program description
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int rooms = 5;
            int weapon = 4;
            int treasure = 3;
            double items = 4.0;
            double mob = 5.0;
            double potions = 2.0;

            Console.WriteLine("***---***---Alone In Wonderland---***---***");
            Console.WriteLine("");
            Console.WriteLine("Choose from the following options. ");
            Console.WriteLine(" Main Menu \n 1. Display Rooms   \n 2. Display Weapon \n 3. Display Potion \n 4. Display Treasures \n 5. Display Items \n 6. Display Mobs \n 7. Exit");
            Console.WriteLine("");
            Console.WriteLine("***---------*******************---------***");

            string menuOptions = Console.ReadLine();

            switch (menuOptions)
            {
                case "1":
                    Console.WriteLine("Display Rooms: " + rooms);
                    break;
                case "2":
                    Console.WriteLine("Display Weapons: " + weapon);
                    break;
                case "3":
                    Console.WriteLine("Display potion: " + potions);
                    break;
                case "4":
                    Console.WriteLine("Display Treasures: " + treasure);
                    break;
                case "5":
                    Console.WriteLine("Display Items: " + items);
                    break;
                case "6":
                    Console.WriteLine("Display Mobs: " + mob);
                    break;
                case "7":
                    Console.WriteLine("Exit");
                    break;
            }
            Console.ReadLine();

        }
    }
}
