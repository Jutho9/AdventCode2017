using System;

namespace Solutions
{
    public class DayThree
    {
        public static long Manhatten()
        {   
            int goal = 277678;
            int width = 1;        // width of square (also the bot right number(highest) and moves taken(-1))!!
            long size = 1;        // elements in square

            while (size < goal)
            {
                width += 2;    // for every move to next square parameter
                size = (long)Math.Pow(width, 2);  // size = width^2
            }

            long dis = width - ((size - goal) % width) - 1;    // finding the distance, with use of modulus

            return dis;
        }
    }
}