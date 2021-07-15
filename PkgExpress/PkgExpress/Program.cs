using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkgExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("What is the weight of the package?");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            if (pkgWeight > 50)
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(-1);
            }
            else if (pkgWeight <= 50)
            {
                Console.WriteLine("WIDTH");
            }
            //string result = pkgWeight <= 50 ? "Please continue to next step." : "Package to heavy to be shipped via Package Express. Have a good day.";
            //Console.WriteLine(result);
            //Console.ReadLine();

            // WIDTH
            Console.WriteLine("What is the package width?");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            if (pkgWidth > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(-1);
            }
            else if (pkgWidth <= 50)
            {
                Console.WriteLine("HEIGHT");
            }

            // HEIGHT
            Console.WriteLine("What is the height of the package?");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            if (pkgHeight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(-1);
            }
            else if (pkgHeight <= 50)
            {
                Console.WriteLine("LENGTH");
            }

            // LENGTH
            Console.WriteLine("What is the packages length?");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            if (pkgLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(-1);
            }
            else if (pkgLength <= 50)
            {
                Console.WriteLine("Calculating shipping cost...");
            }


            int dimension = pkgWidth * pkgHeight * pkgLength;
            int dimWeight = dimension * pkgWeight;
            int shipCost = dimWeight / 100;
            Console.WriteLine(Convert.ToString("Your estimated total for shiping this package is: " + "$" + shipCost));
            Console.ReadLine();
        }
    }
}
