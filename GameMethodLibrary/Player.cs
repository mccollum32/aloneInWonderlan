using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMethodLibrary
{
    public class Player
    {
        //Player Information / Stats
        public static string playerName;
        public static string group;
        public static string[] groupSelect = {"Elder" , "Adult", "Teen" } ;
        public static double playerHealth = 100;

        //Players Current Weapon state / Weapons [weapon stats]
        public static string weaponName; 
        public static string currentWeapon = string.Empty;
        public static int weaponSelect;
        public static string[] weapons = { "Knife", "Screwdriver", "Baseball bat", "B.B Gun(2 clips)", "Brick" ,"None(Hands)" };
        public static string[] weaponStrength = { "100 - 90", "89 - 70", "69 - 50", "49 - 30", "29 - 10" };
        public static string weaponPower;

        public void PlayerName()
        {
            playerName = Console.ReadLine();            
        }

        public void WeaponSelect()
        {
            weaponSelect = new Random().Next(1, 6); 
            if(weaponSelect == 1)
            {
                weaponName = "Knife";
                weaponPower = "100 - 90";
            }
            else if(weaponSelect == 2)
            {
                weaponName = "Screwdriver";
                weaponPower = "49 - 30";
            }
            else if(weaponSelect == 3)
            {
                weaponName = "Baseball bat";
                weaponPower = "89 - 70";

            }
            else if(weaponSelect == 4)
            {
                weaponName = "B.B Gun(2 clips)";
                weaponPower = "29 - 10";

            }
            else if (weaponSelect == 5)
            {
                weaponName = "Brick";
                weaponPower = "69 - 50";

            }
            else if(weaponSelect == 6)
            {
                weaponName = "None(Hands)";
                weaponPower = "29 - 10";

            }
            else
            {
                currentWeapon = "";
            }
        }
    }
}
