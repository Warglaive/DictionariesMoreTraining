using System;
using System.Collections.Generic;

namespace _02.Dict_Ref
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, int>();
            while (input!="end")
            {
                var inputParts = input
                .Split(new[] { ' ', '=' }
            , StringSplitOptions.RemoveEmptyEntries);
                bool isInt = false;
                var name = inputParts[0];
                var secondName = string.Empty;
                var number = 0;
                isInt = int.TryParse(inputParts[1], out number);
                if (isInt == false)
                {
                    secondName = inputParts[1];
                    if (result.ContainsKey(secondName))
                    {
                        result[name] = result[secondName];
                    }
                }
                if (isInt == true)
                {
                    result[name] = number;
                }
                input = Console.ReadLine();
            }
            foreach (var KVP in result)
            {
                Console.WriteLine($"{KVP.Key} === {KVP.Value}");
            }
        }
    }
}