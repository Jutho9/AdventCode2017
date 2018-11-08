using System;
using System.Linq;

namespace Solutions
{
    public class DayOne
    {
        public static void Captcha()
        {
            var input = Console.ReadLine().ToCharArray();   // parse input to char[]
            var list = input.Select(i => Int32.Parse(i.ToString())).ToArray();  // convert char[] to int[]      
            Console.WriteLine("Next digits: {0}", Yup(list));
            Console.WriteLine("Halfway around: {0}", Nope(list));
        }

        public static int Yup(int[] list)
        {
            int sum = 0;  // return value

            var prev = list.Last(); // prev element, starting with last due to circular list            
            foreach (var x in list)
            {
                if (x == prev)
                {
                    sum += prev;
                }
                prev = x;
            }
            return sum;
        }

        public static int Nope(int[] list)
        {
            int sum = 0;

            int i = 0;
            while(i < list.Length/2)
            {
                if (list[i] == list[(list.Length/2)+i]) // if digit equal to the halfway around
                {
                    sum += list[i]*2; // add number *2 (due to two same)
                }

                i++;
            }

            return sum;
        }

    }
}