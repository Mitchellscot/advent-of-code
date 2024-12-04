using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace advent_of_code
{
    public class DayThree
    {
        public static int ProblemOne(string inputString)
        {
            string pattern = @"mul\((\d+),(\d+)\)";
            int total = 0;
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                int num1 = int.Parse(match.Groups[1].Value);
                int num2 = int.Parse(match.Groups[2].Value);
                int result = num1 * num2;
                total += result;
            }
            Console.WriteLine($"Total: {total}");
            return total;
        }
        //public static int ProblemTwo(string input)
        //{

        //}
    }
}
