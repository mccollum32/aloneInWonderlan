using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameMethodLibrary
{
    public class Room
    {        
        public static string name;
        public static int chooseRoom;
        public static string description;
        public string[] roomNames = { "Entry Hallway", "Hallway", "Kitchen", "Backyard", "Street", "Home" };
        
        public void ChooseRoom()
        {
            Console.WriteLine("Where are you going? ");
            chooseRoom = Convert.ToInt32(Console.ReadLine());

            if (chooseRoom == 1)
            {
                name = "Entry hallway";
                Console.WriteLine("You have entered the Entry Hallway!");
            }
            else if (chooseRoom == 2)
            {
                name = "Hallway";
                Console.WriteLine("You have entered the hallway!");
            }
            else if (chooseRoom == 3)
            {
                name = "Kitchen";
                Console.WriteLine("You have entered the Kitchen");
            }
            else if (chooseRoom == 4)
            {
                name = "Backyard";
                Console.WriteLine("You have entered into to the Backyard");
            }
            else if (chooseRoom == 5)
            {
                name = "Street";
                Console.WriteLine("You are going to the street");
            }
            else { name = "Home"; }
            Console.WriteLine("Going back into the home ");
        }
        public void Description()
        {
            switch (description)
            {
                case "1":
                    Console.WriteLine(roomNames[0]);
                    Console.WriteLine("This hallway has been destroyed by a horde of infected! It still has a few useful items.");
                    break;
                case "2":
                    Console.WriteLine(roomNames[1]);
                    Console.WriteLine("An empty hallway leading you to the kitcken or back outside!");
                    break;
                case "3":
                    Console.WriteLine(roomNames[2]);
                    Console.WriteLine("The Kitcken has usefull items inside be careful when searching through it.");
                    break;
                case "4":
                    Console.WriteLine(roomNames[3]);
                    Console.WriteLine("The backyard is fenced in but your scent is strong so move fast when walking around back here!");
                    break;
                case "5":
                    Console.WriteLine(roomNames[4]);
                    Console.WriteLine("The street has infected roaming around! Go here at your own will");
                    break;
                case "6":
                    Console.WriteLine(roomNames[5]);
                    Console.WriteLine("Home sweet home! This is a save haven for right now unless the horde attacks here!");
                    break;
                default:
                    Console.WriteLine("Invalid Input! Try again");
                    break;
            }
        }
    }
}
