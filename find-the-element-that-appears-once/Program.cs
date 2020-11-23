using System;

namespace find_the_element_that_appears_once
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 100, 1, 34, 4, 1, 100, 34 };
            Console.WriteLine(SingleNumber(nums));
        }

        static int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (int n in nums)
                result ^= n;
            return result;
        }
    }
}
