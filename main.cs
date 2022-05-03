
// Created by: Kenny Le
// Created on: Apr 2022
//
// This program calculates the pizza cost

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
        Console.WriteLine("Welcome to Kenny's Pizzeria!");
        Console.WriteLine("Today we will be calculating your pizza order");
        Console.WriteLine("");

        void pizzaSize()
        {
            Console.WriteLine("Please enter the size of pizza you would like (use the abbreviation):");
            Console.WriteLine("");
            Console.WriteLine("Large (L) - $6.00");
            Console.WriteLine("Extra Large (XL) - $10.00");
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
                Console.WriteLine("Please choose a valid size of pizza.");
                pizzaSize();
            }
        }

        void pizzaToppings()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please enter the amount of toppings you would like:");
            Console.WriteLine("");
            Console.WriteLine("One Topping (1) - $1.00");
            Console.WriteLine("Two Toppings (2) - $1.75");
            Console.WriteLine("Three Toppings (3) - $2.50");
            Console.WriteLine("Four Toppings (4) - $3.35");
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
                Console.WriteLine("Please choose a valid amount of toppings.");
                pizzaToppings();
            }
        }

        // process
        pizzaSize();
        pizzaToppings();

        Console.WriteLine("");
        totalCost = (sizePrice + toppingPrice) * TAX_RATE;

        // output
        Console.WriteLine("The cost of a " + sizeChoice + "arge" + " " + toppingChoice + " topping" + " pizza is $" + totalCost.ToString("0.00") + ".");

        Console.WriteLine("\nDone.");
    }
}