using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Dict_Ref_Advanced
{
    public class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string, List<string>>();
            var input = Console.ReadLine();
            while (input != "end")
            {
                var inputParams = input
                    .Split(new char[] { ' ', '-', '>', ',' }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var name = inputParams[0];
                var intValues = inputParams.Skip(1).ToList();
                var number = -1;
                var anotherKey = string.Empty;

                foreach (var intValue in intValues)
                {
                    var isInt = int.TryParse(intValue, out number); //if value is given
                    var numToStr = string.Empty;

                    if (isInt)
                    {
                        if (!result.ContainsKey(name)) //save all names as keys
                        {
                            result[name] = new List<string>();
                        }
                        numToStr = number.ToString();
                        result[name].Add(numToStr);
                    }
                    else //if another key is given
                    {
                        var secondKey = intValues[0];
                        if (result.ContainsKey(secondKey)) //if second key dosent exist
                        {
                            if (!result.ContainsKey(name)) //save all names as keys
                            {
                                result[name] = new List<string>();
                            }
                            result[name] = result[secondKey]; // add value to second key
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} === {string.Join(", ", item.Value)}");
            }
        }
    }
}