using System;
using System.Collections.Generic;

namespace SumEven
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){1,2,7,13,88,33,12,8,67,4,9};
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);

            }
            
            Console.WriteLine(SumEven(numbers));
            Console.ReadLine();
            static double SumEven(List<int> nums)
            {
                double sum = 0;
                for (int i = 0; i < nums.Count; i++)
                {
                    
                    
                    if (nums[i]%2 == 0)
                    {
                       sum += nums[i];
                    }
                    
                }
                return sum;          
            }
        }
        
    }
}
