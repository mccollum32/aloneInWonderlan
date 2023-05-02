using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMethodLibrary
{
    class Room
    {
        private int _idNumber;
        private string _name;
        private string _description;
        private string _exit;
        private string _list;

        public Room (int idNumber, string name, string description, string exit , string list)
        {
            _idNumber = idNumber;
            _name = name;
            _description = description;
            _exit = exit;
            _list = list;
        }

    }
}
