using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Letter_Repetition
{
   public class Program
    {
       public static void Main()
        {
            var entry = Console.ReadLine();
            var dict = new Dictionary<char, int>();
            var result = entry.ToCharArray();
            foreach (var character in result)
            {
                if (!dict.ContainsKey(character))
                {
                    dict[character] = 1;
                }
                else
                {
                    dict[character]++;
                }
            }
            foreach (var character in dict)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}