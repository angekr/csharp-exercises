using System;

namespace OutputArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{1, 1, 2, 3, 5, 8};
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}
