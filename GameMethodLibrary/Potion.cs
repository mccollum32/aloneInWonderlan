using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMethodLibrary
{
    public class Potion
    {        
        public string[] potionGroup = {"Partial Potion (50% Health)" , "Super Potion (Full Health)", "Antidote", "Repellent Spray (2 mins)" };
        public string potionPickup;
        public int potionPickupReg;


        public double potionPrices;
        public int potionCost;

        public void RandomPickup()
        {
            Random rand = new Random();
            potionPickup = potionGroup[rand.Next(potionGroup.Length)];
            Console.WriteLine("You found: " + potionGroup[rand.Next(potionGroup.Length)]);
        }

        public void PotionCost()
        {
            switch (potionCost)
            {
                case 1:
                    potionPrices = 20.00;
                    Console.WriteLine("The cost of the Partial Potion (50% Health): \n$." + potionPrices);
                    break;
                case 2:
                    potionPrices = 45.00;
                    Console.WriteLine("The cost of the Super Potion (Full Health)): \n$." + potionPrices);
                    break;
                case 3:
                    potionPrices = 15.00;
                    Console.WriteLine("The cost of the Antidote: \n$." + potionPrices);
                    break;
                case 4:
                    potionPrices = 75.00;
                    Console.WriteLine("The cost of the Repellent Spray (2 mins): \n$." + potionPrices);
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }


        }

        public void Pickup()
        {
            Console.WriteLine("What are you here to pick up? ");
            potionPickupReg = Convert.ToInt32(Console.ReadLine());

            switch (potionPickupReg)
            {

                case 1:
                    Console.WriteLine(potionGroup[0]);
                    break;
                case 2:
                    Console.WriteLine(potionGroup[1]);
                    break;
                case 3:
                    Console.WriteLine(potionGroup[2]);
                    break;
                case 4:
                    Console.WriteLine(potionGroup[3]);
                    break;
                default:
                    Console.WriteLine("That is not listed try again.");
                    break;
            }

        }
    }
}
