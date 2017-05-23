using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Odd_Occurrences
{
    public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine().ToLower().Split().ToList();
            var dict = new Dictionary<string, int>();
            var result = new List<string>();
            foreach (var word in input)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }
            }
            foreach (var word in dict)
            {
                if (word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
