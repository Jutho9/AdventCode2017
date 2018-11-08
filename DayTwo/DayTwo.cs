using System;
using System.IO;
using System.Linq;

namespace Solutions
{
    public class DayTwo
    {
        // Linq and Lambda
        private static int[][] array = File.ReadLines(@"/Users/Jutho/Documents/Advent_Programming/Solutions/Solutions/DayTwo/nums.txt")
            .Select(r => r.Split('\t')  // split by tab
                .Select(c => Convert.ToInt32(c)).ToArray()) // convert to int and add to array
                .ToArray(); // add to outer array
        
        public static int Checksum()
        {
            int sum = 0; // sum of all rows
            
            foreach (var row in array)
            {
                int min = row.Min(); // min in array
                int max = row.Max(); // max in array
                sum += max - min;
            }

            return sum;
        }

        public static int EvenDiv()
        {
            int sum = 0;

            foreach (var row in array)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    int j = row.Length - 1; // high
                    while (j >= 0)
                    {
                        if (row[i] % row[j] == 0 && i != j)
                            sum += row[i] / row[j];

                        j--; // move down array
                    }
                }
            }

            return sum;
        }
    }
}