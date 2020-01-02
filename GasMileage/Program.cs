using System;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter # of miles driven: ");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of gas used in gallons: ");
            double gallons = double.Parse(Console.ReadLine());
            double mpg = miles / gallons;
            Console.WriteLine("Your miles per gallon is: " + mpg);
            Console.ReadLine();

        }
    }
}
