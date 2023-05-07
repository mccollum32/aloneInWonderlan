using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMethodLibrary
{
    public class Mob
    {
        public string[] infectedType = { "Wild bear", "Looters", "Fungal Mob", "Infected foot soliders (3)", "Wild Dogs" };
        public int[] infectedHP = {100, 50, 35 , 10, 25};
        public string mob1;
        public int mobHP;
        public Random rand = new Random();
        public int mob;
        

        public void InfectedEncounter()
        {
            Random rand = new Random();
            mob1 = infectedType[rand.Next(infectedType.Length)];            
            Console.WriteLine($"You have encountered! {mob1}");
        }
        public void InfectedType()
        {
            Console.WriteLine("From a distance there seems to be: ");
            mob = Convert.ToInt32(Console.ReadLine());
            switch (mob)
            {
                case 1:
                    Console.WriteLine(infectedType[0] , infectedHP[0]);
                    break;
                case 2:
                    Console.WriteLine(infectedType[1], infectedHP[1]);
                    break;
                case 3:
                    Console.WriteLine(infectedType[2], infectedHP[2]);
                    break;
                case 4:
                    Console.WriteLine(infectedType[3], infectedHP[3]);
                    break;
                case 5:
                    Console.WriteLine(infectedType[4], infectedHP[4]);
                    break;
                default:
                    Console.WriteLine("Must be your imagination! ");
                    break;
            }
        }
    }
}
