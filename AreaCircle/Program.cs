using System;

namespace AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            double pi = 3.14;
            do
            {
                Console.WriteLine("Enter a radius: ");
                radius = double.Parse(Console.ReadLine()); if (radius <= 0)
                {
                    Console.WriteLine("That is an invalid radius");
                }

            } while (radius <= 0);
            //if (radius <= 0)
            //{
              //  Console.WriteLine("That is an invalid radius");
                //Console.ReadLine();
            //}
            
                area = pi * radius * radius;
                Console.WriteLine("The area of a circle with radius " + radius + " is " + area);
                Console.ReadLine();
            
        }
    }
}
