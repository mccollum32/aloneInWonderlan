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
        public int _idNumber;
        public string _name;
        public string _description;
        public string _exit ;           
        public string[] roomList = {"Entry hallway", "Hallway", "Kitchen", "Backyard", "Street", "Home" }; 
        
        
    }
}
