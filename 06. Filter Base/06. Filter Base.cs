using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Filter_Base
{
    public class Program
    {
        public static void Main()
        {
            var ages = new Dictionary<string, string>();
            var salaries = new Dictionary<string, string>();
            var positions = new Dictionary<string, string>();
            var input = Console.ReadLine();
            while (input != "filter base")
            {
                var inputParts = input
                    .Split(new string[] { "->", " " }
                , StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var name = inputParts[0];
                var age = 0;
                var isInt = int.TryParse(inputParts[1], out age);
                var salary = 0.0;
                bool isDouble = false;
                var position = String.Empty;
                if (!isInt)
                {
                    isDouble = double.TryParse(inputParts[1], out salary);
                }
                if (!isDouble && !isInt)
                {
                    position = inputParts[1];
                }
                //Save only name -> Age in names Dict.;
                if (!isDouble && position == string.Empty)
                {
                    ages[name] = age.ToString();
                }
                //Save only salary;
                else if (!isInt && position == string.Empty)
                {
                    salaries[name] = salary.ToString("f2"); //Format salary print.
                }
                //Save only position;
                else if (!isInt && !isDouble)
                {
                    positions[name] = position;
                }
                input = Console.ReadLine();
            }
            var lastInput = Console.ReadLine();
            //Print
            if (lastInput == "Age")
            {
                foreach (var age in ages)
                {
                    Console.WriteLine($"Name: {age.Key}");
                    Console.WriteLine($"Age: {age.Value}");
                    Console.WriteLine(new string('=',20));
                }
            }
            else if (lastInput == "Salary")
            {
                foreach (var salary in salaries)
                {
                    Console.WriteLine($"Name: {salary.Key}");
                    Console.WriteLine($"Salary: {salary.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (lastInput == "Position")
            {
                foreach (var position in positions)
                {
                    Console.WriteLine($"Name: {position.Key}");
                    Console.WriteLine($"Position: {position.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}