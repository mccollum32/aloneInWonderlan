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
        public static int randO;
        public static string name;
        public static int chooseRoom;
        public static string exit ;           
        public static string[] roomList = {"Entry hallway", "Hallway", "Kitchen", "Backyard", "Street", "Home" }; 
        
        public void ChooseRoom()
        {            
            chooseRoom = new Random().Next(1, 6);
            if (chooseRoom == 1)
            {
                name = "Entry hallway";
            }
            else if (chooseRoom == 2)
            {
                name = "Hallway";
            }
            else if (chooseRoom == 3)
            {
                name = "Kitchen";
            }
            else if (chooseRoom == 4)
            {
                name = "Backyard";
            }
            else if (chooseRoom == 5)
            {
                name = "Street";
            }
            else { name = "Home"; }
        }
    }
}
