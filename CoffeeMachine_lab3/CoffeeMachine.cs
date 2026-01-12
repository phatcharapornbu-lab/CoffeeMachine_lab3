
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_lap3
{
    internal class CoffeeMachine
    {
        int coffee = 0;
        int water = 0;
        int chocolate = 0;
        int milk = 0;
        // constructor
        public CoffeeMachine(int coffee, int water, int chocolate, int milk)
        {
            this.coffee = coffee;
            this.water = water;
            this.chocolate = chocolate;
            this.milk = milk;
        }
        public void Buyblackcoffee(int amount)
        {
            int requiredWater = 300 * amount;
            int requiredCoffee = 20 * amount;

            if (water >= requiredWater && coffee >= requiredCoffee)
            {
                this.water -= requiredWater;
                this.coffee -= requiredCoffee;
                Console.WriteLine($"Your {amount} cup(s) of black coffee are ready.");
            }
            else
            {
                Console.WriteLine("Not enough ingredients to make black coffee.");
            }
        }
        public void Buymocha(int amount)
        {
            int requiredWater = 300 * amount;
            int requiredCoffee = 20 * amount;
            int requiredChocolate = 10 * amount;
            if (water >= requiredWater && coffee >= requiredCoffee && chocolate >= requiredChocolate)
            {
                this.water -= requiredWater;
                this.coffee -= requiredCoffee;
                this.chocolate -= requiredChocolate;
                Console.WriteLine($"Your {amount} cup(s) of Mocha are ready.");
            }
            else
            {
                Console.WriteLine("Not enough ingredients to make Mocha.");
            }
        }
        public void Buylatte(int amount)
        {
            int requiredWater = 300 * amount;
            int requiredCoffee = 20 * amount;
            int requiredMilk = 10 * amount;
            if (water >= requiredWater && coffee >= requiredCoffee && milk >= requiredMilk)
            {
                this.water -= requiredWater;
                this.coffee -= requiredCoffee;
                this.milk -= requiredMilk;
                Console.WriteLine($"Your {amount} cup(s) of Latte are ready.");
            }
            else
            {
                Console.WriteLine("Not enough ingredients to make Latte.");
            }
        }
        public void Buychocolate(int amount)
        {
            int requiredWater = 300 * amount;
            int requiredChocolate = 20 * amount;
            if (water >= requiredWater && chocolate >= requiredChocolate)
            {
                this.water -= requiredWater;
                this.chocolate -= requiredChocolate;
                Console.WriteLine($"Your {amount} cup(s) of Latte are ready.");
            }
            else
            {
                Console.WriteLine("Not enough ingredients to make Chocolate.");
            }
        }
        public void ShowStock()
        {
            Console.WriteLine("Current stock: ");
            Console.WriteLine("coffee: " + this.coffee);
            Console.WriteLine("Water: " + this.water);
            Console.WriteLine("Chocolate: " + this.chocolate);
            Console.WriteLine("milk: " + this.milk);
        }
        public void IncreaseStock(int coffee, int water, int chocolate, int milk)
        {
            this.coffee += coffee;
            this.water += water;
            this.chocolate += chocolate;
            this.milk += milk;
            ShowStock();
        }
    }
}

