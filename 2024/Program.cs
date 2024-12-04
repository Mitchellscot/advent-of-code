using advent_of_code;
using System;

namespace _2024
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] input1 = File.ReadAllLines("./Resources/input1.txt");
            //Console.WriteLine(DayOne.ProblemOne(input1));
            //Console.WriteLine(DayOne.ProblemTwo(input1));
            //string[] input2 = File.ReadAllLines("./Resources/input2.txt");
            //string[] input2 = new string[] { "7 6 4 2 1", "1 2 7 8 9", "9 7 6 2 1", "1 3 2 4 5", "8 6 4 4 1", "1 3 6 7 9" };
            string input3 = File.ReadAllText("./Resources/input3.txt");
            //Console.WriteLine(DayTwo.ProblemOne(input2));
            //Console.WriteLine(DayTwo.ProblemTwo(input2));
            Console.WriteLine(DayThree.ProblemOne(input3));
        }
    }
}
