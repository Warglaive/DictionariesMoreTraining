using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Exam_Shopping
{
    public class Program
    {
       public static void Main()
        {
            var products = Console.ReadLine();
            var inventory = new Dictionary<string, int>();
            while (products != "shopping time") 
            {
                var productsParts = products
                    .Split(new string[] { "stock", " " }
                , StringSplitOptions.RemoveEmptyEntries).ToList();
                var product = productsParts[0];
                var quantityIn = int.Parse(productsParts[1]);
                if (!inventory.ContainsKey(product))
                {
                    inventory[product] = quantityIn;
                }
                else
                {
                    inventory[product] += quantityIn;
                }
                products = Console.ReadLine();
            }
            var buyProducts = Console.ReadLine();//buy
            while (buyProducts != "exam time")
            {
                var buyProductsParts = buyProducts
                    .Split(new string[] { "buy", " " }
                , StringSplitOptions.RemoveEmptyEntries).ToList();
                var product = buyProductsParts[0];
                var quantityOut = int.Parse(buyProductsParts[1]);
                if (!inventory.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (inventory[product] <= 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    if (quantityOut > inventory[product]) 
                    {
                        inventory[product] -= inventory[product];
                    }
                    else
                    {
                        inventory[product] -= quantityOut;
                    }
                }
                buyProducts = Console.ReadLine();
            }
            foreach (var product in inventory)
            {
                if (product.Value <= 0)
                {
                    continue;
                }
                Console.WriteLine($"{product.Key} -> {product.Value}");
            }
        }
    }
}