using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Mixed_Phones
{
    public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, string>();
            while (input!="Over")
            {
                var inputParts = input.Split(new[] { ' ', ':' }
                , StringSplitOptions.RemoveEmptyEntries);
                var firstElement = inputParts[0];
                var secondElement = inputParts[1];
                var firstNumber = 0;
                long secondNumber = 0;
                if (int.TryParse(firstElement, out firstNumber))
                {
                    result[secondElement] = firstNumber.ToString();
                }
                else
                {
                    secondNumber = long.Parse(secondElement);
                    result[firstElement] = secondNumber.ToString();
                }
                input = Console.ReadLine();
            }
            foreach (var KVP in result.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{KVP.Key} -> {KVP.Value}");
            }
        }
    }
}