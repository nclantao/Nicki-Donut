using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicki_Donut
{
    internal class NickiDonut
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine();
                Console.Write("Please enter your name:");
                string name = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Hello, " + name);
                Console.WriteLine("Welcome to Nicki Donut!");

                bool isExiting = false;
                while (!isExiting)
                {
                    Console.WriteLine();
                    Console.WriteLine("   MENU");
                    Console.WriteLine("1. Strawberry Sprinkle Donut");
                    Console.WriteLine("2. Ube Cheese Donut");
                    Console.WriteLine("3. Rainbow Sprinkle Donut");
                    Console.WriteLine("4. Choco Frosted");
                    Console.WriteLine("5. Vanilla Kreme");
                    Console.WriteLine();

                    bool isValidInput = false;

                    while (!isValidInput)
                    {
                        Console.Write("Select your order (1-5):");
                        int donutOrder = Convert.ToInt32(Console.ReadLine());

                        if (donutOrder >= 1 && donutOrder <= 5)
                        {
                            isValidInput = true;
                            Console.WriteLine();
                            Console.WriteLine("Do you want to put some add-ons? (yes/no)");
                            Console.Write("Pick your choice: ");
                            string input = Console.ReadLine();

                            if (input.ToLower() == "yes")
                            {
                                Console.WriteLine();
                                Console.WriteLine("ADD-ONS");
                                Console.WriteLine("1. Royal Float");
                                Console.WriteLine("2. Coffee Jelly");
                                Console.WriteLine("3. Four Seasons Juice");
                                Console.WriteLine("4. Cappuccino Iced Coffee");
                                Console.WriteLine("5. Mango Graham Shake");

                                Console.WriteLine();
                                Console.Write("Select your order (1-5): ");
                                int AddOnOrder = Convert.ToInt32(Console.ReadLine());

                                if (AddOnOrder >= 1 && AddOnOrder <= 5)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Thank you for your order, " + name + "!");
                                    Console.WriteLine();
                                    Console.WriteLine("Your Order:");
                                    Console.WriteLine();
                                    Console.WriteLine($"{DonutName(donutOrder)} with {AddonName(AddOnOrder)}");
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Invalid add on selection. Please try again.");
                                    isValidInput = false;
                                }
                            }
                            else if (input.ToLower() == "no")
                            {
                                Console.WriteLine();
                                Console.WriteLine("Thank you and come again, " + name + "!");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid input. Please try again.");
                                isValidInput = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid donut selection. Please try again.");
                            isValidInput = false;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Do you want to order again? (yes/no)");
                    string choice = Console.ReadLine();

                    if (choice != "yes")
                    {
                        isExiting = true;
                        Console.WriteLine();
                        Console.WriteLine("Happy to serve you!");
                        break;
                    }
                }
            }

            static string DonutName(int DonutOrderNumber)
            {
                switch (DonutOrderNumber)
                {
                    case 1:
                        return "Strawberry Sprinkle Donut";
                    case 2:
                        return "Ube Cheese Donut";
                    case 3:
                        return "Rainbow Sprinkle Donut";
                    case 4:
                        return "Choco Frosted";
                    case 5:
                        return "Vanilla Kreme";
                    default:
                        return "UNKNOWN ITEM";
                }
            }

            static string AddonName(int AddOnOrderNumber)
            {
                switch (AddOnOrderNumber)
                {
                    case 1:
                        return "Royal Float";
                    case 2:
                        return "Coffee Jelly";
                    case 3:
                        return "Four Seasons Juice";
                    case 4:
                        return "Cappuccino Iced Coffee";
                    case 5:
                        return "Mango Graham Shake";
                    default:
                        return "UNKNOWN ITEM";
                }
            }
        }
    }
}