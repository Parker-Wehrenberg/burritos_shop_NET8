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
         * Starts from 0 burritos sold.
         * Keeps increasing the number of burritos sold by 1 each time.
         * Calculates revenue, cost, and profit (revenue - cost).
         * Stops and reports the first number of burritos where the truck makes profit (revenue > cost).
         */

        Console.WriteLine("Calculating the break-even point using for loop ... ");
        Console.WriteLine("------------------------------------");

        decimal unitprice = 9.00m;
        decimal unitcost = 3.80m;
        decimal minimumcost = 1200.00m;

        int itemsold;
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
                // Found first profitable number of burritos (itemsold)
                break;
            }
        }

        Console.WriteLine("------------------------------------");
        Console.WriteLine("Success! Profit reached.");
        Console.WriteLine($"Number of Burritos: {itemsold}");
        Console.WriteLine($"Revenue: {revenue:C2}");
        Console.WriteLine($"Cost: {cost:C2}");
        Console.WriteLine($"Profit: {profit:C2}");

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }

    // --- Using While Loop ---
    static void using_while_loop()
    {
        Console.WriteLine("Calculating the break-even point using while loop ... ");
        Console.WriteLine("------------------------------------");

        decimal unitprice = 9.00m;
        decimal mincost = 1200.00m;
        decimal unitcost = 3.80m;

        int itemsold = 0;
        decimal revenue = 0.00m;
        decimal cost = 0.00m;
        decimal profit = 0.00m;

        // Evaluate current profit and print until profit > 0
        while (true)
        {
            revenue = itemsold * unitprice;
            cost = mincost + (itemsold * unitcost);
            profit = revenue - cost;

            if (profit <= 0)
            {
                Console.WriteLine($"After selling {itemsold} burritos: profit {profit:C2}.");
                itemsold++;
                continue;
            }

            // profit > 0, break and show summary
            break;
        }

        Console.WriteLine("------------------------------------");
        Console.WriteLine("Success! Profit reached.");
        Console.WriteLine($"Number of Burritos: {itemsold}");
        Console.WriteLine($"Revenue: {revenue:C2}");
        Console.WriteLine($"Cost: {cost:C2}");
        Console.WriteLine($"Profit: {profit:C2}");

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }

    // --- Using Do-While Loop ---
    static void using_dowhile_loop()
    {
        Console.WriteLine("Calculating the break-even point using do-while loop ... ");
        Console.WriteLine("------------------------------------");

        decimal unitprice = 9.00m;
        decimal mincost = 1200.00m;
        decimal unitcost = 3.80m;

        int itemsold = 0;
        decimal revenue = 0.00m;
        decimal cost = 0.00m;
        decimal profit = 0.00m;

        // Evaluate then decide to continue; loop will run at least once
        do
        {
            revenue = itemsold * unitprice;
            cost = mincost + (itemsold * unitcost);
            profit = revenue - cost;

            Console.WriteLine($"After selling {itemsold} burritos: profit {profit:C2}.");

            if (profit > 0)
            {
                break;
            }

            itemsold++;
        }
        while (true);

        Console.WriteLine("------------------------------------");
        Console.WriteLine("Success! Profit reached.");
        Console.WriteLine($"Number of Burritos: {itemsold}");
        Console.WriteLine($"Revenue: {revenue:C2}");
        Console.WriteLine($"Cost: {cost:C2}");
        Console.WriteLine($"Profit: {profit:C2}");

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}
