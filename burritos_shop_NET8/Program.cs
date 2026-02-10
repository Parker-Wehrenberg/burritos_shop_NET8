using System;

partial class Program
{

    /* Go to Tools > Options.
     * In the search bar at the top left of the window, type IntelliCode.
     * Find C# user model predictions (or "Whole line completions") and set it to Disabled.
     * */

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("=== Burritos Shop Break Even Points Calculator ===");
            Console.WriteLine("1) Using For Loop");
            Console.WriteLine("2) Using While Loop");
            Console.WriteLine("3) Using Do-While Loop");
            Console.WriteLine("4) Exit");
            Console.Write("\nSelect an option: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                using_for_loop();
            }
            else if (input == "2")
            {
                using_while_loop();
            }
            else if (input == "3")
            {
                using_dowhile_loop();
            }
            else if (input == "4")
            {
                Console.WriteLine("Exiting program...");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key to try again.");
                Console.ReadKey();
            }
        }
    }

    // --- Using For Loop ---

    static void using_for_loop()
    {

        /* A food truck sells burritos for $9 each.
         * Minimum cost per month is $1200 .
         * The unit cost per burrito is $3.80.
         * 
         * Write a program that:
         * 
         * Starts from 0 burritos sold.
         * Keeps increasing the number of burritos sold by 1 each time.
         * Calculates revenue, cost, and profit (revenue - cost).
         * Stops and reports the first number of burritos where the truck makes profit (revenue > cost).
         * 
         * Expected output:
         * ...
         * After selling 229 burritos: profit -9.20.
         * After selling 230 burritos: profit -4.00
         * ------------------------------------
         * Success! Profit reached.
         * Number of Burritos: 231 
         * Revenue: $2,079.00 
         * Cost: $2,077.80 
         * Profit: $1.20
         * 
        */


        Console.WriteLine("Calculating the break-even point using for loop ... ");
        Console.WriteLine("------------------------------------");

        // Please Enter Your For Loop Codes Here
        decimal unitprice = 9.00m;
        decimal unitcost = 3.80m;
        decimal minimumcost = 1200.00m;

       int itemsold= 0;

        decimal revenue = 0.00m;
        decimal cost = 0.00m;
        decimal profit = 0.00m;

        for (itemsold = 0; ; itemsold++)
        {
             revenue = itemsold * unitprice;
             cost = minimumcost + (itemsold * unitcost);
             profit = revenue - cost;
            if (profit <= 0)
            {
                Console.WriteLine($"After selling {itemsold} burritos: profit {profit:C2}.");
            }
            else
            {
                break;
            }
        }


                Console.WriteLine("------------------------------------");
                Console.WriteLine("Success! Profit reached.");
                Console.WriteLine($"Number of Burritos: {itemsold}");
                Console.WriteLine($"Revenue: {revenue:C2}");
                Console.WriteLine($"Cost: {cost:C2}");
                Console.WriteLine($"Profit: {profit:C2}");
                
            }
        }


Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    

    // --- Using While Loop ---

    static void using_while_loop()
    {
        Console.WriteLine("Calculating the break-even point using while loop ... ");
        Console.WriteLine("------------------------------------");

        // Please Enter Your While Loop Codes Here



        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();

    }

    // --- Using Do-While Loop ---

    static void using_dowhile_loop()
    {
        Console.WriteLine("Calculating the break-even point using do-while loop ... ");
        Console.WriteLine("------------------------------------");

        // Please Enter Your Do-While Loop Codes Here



        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
