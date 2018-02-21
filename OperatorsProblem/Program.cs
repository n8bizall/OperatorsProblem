using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    static void Main(String[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine());
        int tip_percent = Convert.ToInt32(Console.ReadLine());
        int tax_percent = Convert.ToInt32(Console.ReadLine());


        double tip = ((Convert.ToDouble(tip_percent) / 100) * meal_cost);
        double tax = ((Convert.ToDouble(tax_percent) / 100) * meal_cost);
        double totalCost = (meal_cost + tip + tax);

        int roundedTotal = Convert.ToInt32(Math.Round(totalCost, 0));

        Console.WriteLine($"The total meal cost is {roundedTotal} dollars.");
        Console.ReadKey();

    }

}