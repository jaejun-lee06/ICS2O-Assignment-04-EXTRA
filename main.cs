
// Created by: Jaejun Lee
// Created on: Apr 2022
//
// This program calculates the cost of a pizza

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the pizza cost
        const double TAX_RATE = 1.13;
        string sizeChoice;
        double toppingChoice;
        double sizePrice;
        double toppingPrice;
        double totalCost;

        // input
        Console.WriteLine("Pizza Order, with CSharp");
        Console.WriteLine("");

        void pizzaSize()
        {
            Console.WriteLine("Which pizza would you like to order? (Write L or XL)");
            Console.WriteLine("");
            Console.WriteLine("Large (L): $6.00");
            Console.WriteLine("Extra Large (XL): $10.00");
            sizeChoice = Console.ReadLine();

            if (sizeChoice == "L")
            {
                sizePrice = 6.00;
            }
            else if (sizeChoice == "XL")
            {
                sizePrice = 10.00;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please write L or XL");
                pizzaSize();
            }
        }

        void pizzaToppings()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("How many toppings would you like to order? (1-4)");
            Console.WriteLine("");
            Console.WriteLine("1 topping ($1.00)");
            Console.WriteLine("2 toppings ($1.75)");
            Console.WriteLine("3 toppings ($2.50)");
            Console.WriteLine("4 toppings ($3.35)");
            toppingChoice = Convert.ToDouble(Console.ReadLine());
            if (toppingChoice == 1)
            {
                toppingPrice = 1.00;
            }
            else if (toppingChoice == 2)
            {
                toppingPrice = 1.75;
            }
            else if (toppingChoice == 3)
            {
                toppingPrice = 2.50;
            }
            else if (toppingChoice == 4)
            {
                toppingPrice = 3.35;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please write a number 1-4");
                pizzaToppings();
            }
        }

        // process
        pizzaSize();
        pizzaToppings();

        Console.WriteLine("");
        totalCost = (sizePrice + toppingPrice) * TAX_RATE;

        // output
        Console.WriteLine("The cost of a " + sizeChoice + "Large" + " " + toppingChoice + " topping" + " pizza is $" + totalCost.ToString("0.00") + ".");

        Console.WriteLine("\nDone.");
    }
}