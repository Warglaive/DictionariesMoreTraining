using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Forum_Topics
{
    public class Program
    {
       public static void Main()
        {
            var result = new Dictionary<string, HashSet<string>>();
            var input = Console.ReadLine();
            while (input != "filter") 
            {
                var inputParts = input
                    .Split(new[] { '-', '>', ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var topic = inputParts[0];
                var tags = inputParts.Skip(1).ToList();

                if (!result.ContainsKey(topic))
                {
                    result[topic] = new HashSet<string>();
                }
                foreach (var item in tags)
                {
                    item.ToString();
                    result[topic].Add(item);
                }
                input = Console.ReadLine();
            }
            var tagsCheck = Console.ReadLine()
                .Split(new[] { ' ', ',' }
            , StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            bool contained = false;
            foreach (var KVP in result.Keys)
            {
                for (int i = 0; i < tagsCheck.Count; i++)
                {
                    if (result[KVP].Contains(tagsCheck[i]))
                    {
                        contained = true;
                    }
                    else
                    {
                        contained = false;
                    }
                    if (tagsCheck.Count >= 2 && contained==false)
                    {
                        i = tagsCheck.Count + 1;
                    }
                }
                if (contained)
                {
                    Console.WriteLine($"{KVP} | #{string.Join(", #",result[KVP])}");
                }
            }
        }
    }
}