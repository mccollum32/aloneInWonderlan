using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameMethodLibrary;
using System.IO;
using System.Threading;

/**
* Feb 26 23
* CSC 153
* McCollum Joseph
* Console strategy based game with survival strategy and a mix of horror. Still adding more to this one as I make the story up. Will be making changes
* in the near future to get the game to flow well. Added Classes/Methods/Switch statements/ If else statements/ Random.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Room _room = new Room();
            Potion potion = new Potion();
            Mob infected = new Mob();

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
                else if (choices == 7)
                {
                    bool stop = false;
                    while(stop == false)
                    {
                        Console.WriteLine("You are stuck in Wonderland! Everything around is in ruind. You have to find a way back home to safety and back to your family!");
                        Thread.Sleep(1500);
                        Console.WriteLine("What is your name? ");
                        Thread.Sleep(1500);
                        player.PlayerName();
                        Console.WriteLine($"Welcome to your new last day in wonderland!");

                    }
                    stop = true;
                    Console.WriteLine("The Player is dead! GAME OVER!" + stop);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Input! Try again.");
                }
            }
            
            Console.ReadKey();
        }
    }    
}
