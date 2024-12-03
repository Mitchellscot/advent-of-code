using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_of_code
{
    public static class DayTwo
    {
        public static int ProblemOne(string[] input)
        {
            bool IsIncreasingByOneOrTwoOrThree(List<int> report)
            {
                for (int i = 0; i < report.Count - 1; i++)
                {
                    int diff = report[i + 1] - report[i];
                    if (diff == 1 || diff == 2 || diff == 3)
                        continue;
                    else return false;

                }
                return true;
            }
            bool IsDecreasingByOneOrTwoOrThree(List<int> report)
            {
                for (int i = 0; i < report.Count - 1; i++)
                {
                    int diff = report[i] - report[i + 1];
                    if (diff == 1 || diff == 2 || diff == 3)
                        continue;
                    else return false;
                }
                return true;
            }

            int count = 0;
            foreach (var str in input)
            {
                var reports = str.Split(' ').Select(int.Parse).ToList();
                if (IsIncreasingByOneOrTwoOrThree(reports) || IsDecreasingByOneOrTwoOrThree(reports))
                    count++;
            }
            return count;
        }
        public static int ProblemTwo(string[] input)
        {
            bool IsIncreasingByOneOrTwoOrThree(List<int> report, bool offByOne)
            {
                for (int i = 0; i < report.Count - 1; i++)
                {
                    if (offByOne && report[i] == report[i + 1])
                        continue;
                    int diff = report[i + 1] - report[i];
                    if (diff == 1 || diff == 2 || diff == 3)
                        continue;
                    else return false;

                }
                return true;
            }
            bool IsDecreasingByOneOrTwoOrThree(List<int> report, bool offByOne)
            {
                for (int i = 0; i < report.Count - 1; i++)
                {
                    if (offByOne && report[i] == report[i + 1])
                        continue;
                    int diff = report[i] - report[i + 1];
                    if (diff == 1 || diff == 2 || diff == 3)
                        continue;
                    else return false;
                }
                return true;
            }
            int count = 0;
            foreach (var str in input)
            {
                var reports = str.Split(' ').Select(int.Parse).ToList();
                if (reports.Distinct().Count() - reports.Count > 1)
                    continue;
                var offByOne = reports.Distinct().Count() == reports.Count - 1;

                var isAscending = reports.SequenceEqual(reports.OrderBy(x => x));
                var isDescending = reports.SequenceEqual(reports.OrderByDescending(x => x));
                if (isAscending)
                {
                    if (IsIncreasingByOneOrTwoOrThree(reports, offByOne))
                        count++;
                }
                if (isDescending)
                {
                    if (IsDecreasingByOneOrTwoOrThree(reports, offByOne))
                        count++;
                }
                if (!isAscending && !isDescending)
                {
                    bool dampenerUsed = false;
                    if (reports[0] < reports[1])
                        isAscending = true;
                    else isDescending = true;
                    if (isAscending)
                    {
                        for (int i = 0; i < reports.Count - 1; i++)
                        {
                            if (reports[i] > reports[i + 1] && !dampenerUsed)
                            {
                                dampenerUsed = true;
                                reports.RemoveAt(i);
                                i--;
                                continue;
                            }
                            else if (reports[i] - reports[i + 1] < 4 && reports[i] - reports[i + 1] != 0)
                            {
                                if (i == reports.Count - 2)
                                    count++;
                                continue;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < reports.Count - 1; i++)
                        {
                            if (reports[i] < reports[i + 1] && !dampenerUsed)
                            {
                                dampenerUsed = true;
                                reports.RemoveAt(i);
                                i--;
                                continue;
                            }
                            else if (reports[i] - reports[i + 1] < 4 &&
                                    reports[i] - reports[i + 1] != 0)
                            {
                                continue;
                            }
                            else if (i == reports.Count - 1)
                            {
                                if (i == reports.Count - 2)
                                    count++;
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }
    }
}
