using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine_lap3;

namespace CoffeeMachine_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create object
            CoffeeMachine CoffeeMachineA = new CoffeeMachine(10000, 10000, 10000, 10000);
            bool isRuning = true;

            while (isRuning)
            {
                //menu interface
                Console.WriteLine("------------------------");
                Console.WriteLine("Wellocome to Coffee Machine");
                Console.WriteLine("------------------------");
                Console.WriteLine("1 : Buy Black Coffee");
                Console.WriteLine("2 : Buy Mocha");
                Console.WriteLine("3 : But Latte");
                Console.WriteLine("4 : Buy chocoLate");
                Console.WriteLine("5 : Show stock");
                Console.WriteLine("6 : Increase stock");
                Console.WriteLine("0 : Exit program");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        {
                            Console.WriteLine(" Input your amont to buy ");
                            string amount = Console.ReadLine();
                            int IAmount = Int32.Parse(amount);
                            CoffeeMachineA.Buyblackcoffee(IAmount);
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine(" Input your amont to buy ");
                            string amount = Console.ReadLine();
                            int IAmount = Int32.Parse(amount);
                            CoffeeMachineA.Buymocha(IAmount);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine(" Input your amont to buy ");
                            string amount = Console.ReadLine();
                            int IAmount = Int32.Parse(amount);
                            CoffeeMachineA.Buylatte(IAmount);
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine(" Input your amont to buy ");
                            string amount = Console.ReadLine();
                            int IAmount = Int32.Parse(amount);
                            CoffeeMachineA.Buychocolate(IAmount);
                            break;
                        }
                    case "5":
                        {
                            CoffeeMachineA.ShowStock();
                            break;
                        }

                    case "6":
                        {
                            CoffeeMachineA.IncreaseStock(5000, 5000, 5000, 5000);
                            break;
                        }

                    case "0":
                        Console.WriteLine("Thank you! Goodbye.");
                        isRuning = false; // เปลี่ยนค่าเป็น false เพื่อออกจาก while loop
                        break;
                    default:
                        Console.WriteLine("Wrong input Try again");
                        break;
                }

            }
        }
    }
}