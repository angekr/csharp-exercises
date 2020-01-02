using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            Console.WriteLine("Enter the lenghth of your rectangle:");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of your rectangle:");
            width = double.Parse(Console.ReadLine());
            area = length * width;
            Console.WriteLine("The area of the rectangle is " + area);
            Console.ReadLine();


        }
    }
}
