using System;

namespace PatternSlidingWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = SmallestSubarrayWithaGivenSum.FindSmallestSubarray();
            Console.WriteLine($"Smallest Subarray with a given sum! - {output}");
        }
    }
}
