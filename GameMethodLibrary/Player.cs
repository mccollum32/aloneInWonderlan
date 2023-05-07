using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMethodLibrary
{
    public class Player
    {
        public static Random rand = new Random();

        //Player Information / Stats
        public static string playerName;

        //Players Current Weapon state / Weapons [weapon stats]
        public static int weaponSelection;
        public static string weaponOption;
        public static int weaponPOW;

        // Random Weapon choices
        public static string weapon;
        public static string weaponPower;
        public static string[] weaponList = { "short sword", "Long sword", "Kitana sword", "Battle Axe", "Dagger" };
        public static string[] weaponStrength = { "100", "70", "80", "50", "0" };
        public static int weaponPick = rand.Next(weaponList.Length);
        public static int weaponPow = rand.Next(weaponStrength.Length);

        public void PlayerName()
        {
            playerName = Console.ReadLine();            
        }

        public void WeaponSelect()
        {
            Console.WriteLine("Select a Weapon: \n[1].Knife \n[2]Screwdriver\n[3]Baseball bat\n[4]B.B gun( 2 clips)\n[5]Brick\n[6]Hands.\n[7]Exit.");
            Console.WriteLine("********************");
            int weaponSelection = Convert.ToInt32(Console.ReadLine());

            if (weaponSelection == 1)
            {
                weaponOption = "Knife";
                weaponPOW = 100;
                Console.WriteLine("Player chose: \n" + weaponOption + "\nWeapon Strength: " + weaponPOW);
                Console.WriteLine("********************");
            }
            else if (weaponSelection == 2)
            {
                weaponOption = "Screwdriver";
                weaponPOW = 50;
                Console.WriteLine("Player chose: \n" + weaponOption + "\nWeapon Strength: " + weaponPOW);
                Console.WriteLine("********************");
            }
            else if (weaponSelection == 3)
            {
                weaponOption = "Baseball bat";
                weaponPOW = 80;
                Console.WriteLine("Player chose: \n" + weaponOption + "\nWeapon Strength: " + weaponPOW);
                Console.WriteLine("********************");

            }
            else if (weaponSelection == 4)
            {
                weaponOption = "B.B Gun(2 clips)";
                weaponPOW = 0;
                Console.WriteLine("Player chose: \n" + weaponOption + "\nWeapon Strength: " + weaponPOW);
                Console.WriteLine("********************");
            }
            else if (weaponSelection == 5)
            {
                weaponOption = "Brick";
                weaponPOW = 70;
                Console.WriteLine("Player chose: \n" + weaponOption + "\nWeapon Strength: " + weaponPOW);
                Console.WriteLine("********************");
            }
            else if (weaponSelection == 6)
            {
                weaponOption = "Hands";
                weaponPOW = 0;
                Console.WriteLine("Player chose: \n" + weaponOption + "\nWeapon Strength: " + weaponPOW);
                Console.WriteLine("********************");
            }
            else
            {
                Console.WriteLine("No Weapon Selected!");
                Console.WriteLine("********************");
            }
        }

        public void WeaponRandom()
        {
            weapon = weaponList[rand.Next(weaponList.Length)];
            Console.WriteLine($"Randomly seleceted weapon: {weaponList[weaponPick]} \nWeapon Strength: {weaponStrength[weaponPow]}");
        }
    }
}
