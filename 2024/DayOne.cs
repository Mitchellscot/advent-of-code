using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_of_code
{
    public static class DayOne
    {
        public static int ProblemOne(string[] input)
        {
            List<int> left = input.Select(x => x.Split("   ")[0]).Select(int.Parse).Order().ToList();
            List<int> right = input.Select(x => x.Split("   ")[1]).Select(int.Parse).Order().ToList();
            int total = 0;
            foreach (int i in left)
            {
                var difference = Math.Abs(i - right[left.IndexOf(i)]);
                total += difference;
            }
            return total;
        }
        public static int ProblemTwo(string[] input)
        {
            List<int> left = input.Select(x => x.Split("   ")[0]).Select(int.Parse).Order().ToList();
            List<int> right = input.Select(x => x.Split("   ")[1]).Select(int.Parse).Order().ToList();
            return left.Select(l => l * right.Count(r => r == l)).Sum();
        }
    }
}
