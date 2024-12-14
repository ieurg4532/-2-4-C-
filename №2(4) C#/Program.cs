using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4__C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter:\n1, alfa\n2, beta\n3, gamma\n");
            Console.Write("Enter variant: ");
            string variant = Console.ReadLine();

            double z;
            switch (variant)
            {
                case "1":
                case "alfa":
                    if (a + Math.Sin(x) < 0)
                    {
                        Console.WriteLine("Error: the number under the root is negative, cannot be calculated.");
                    }
                    else
                    {
                        z = Math.Sqrt(a + Math.Sin(x));
                        Console.WriteLine($"Result: {z}");
                    }
                    break;
                case "2":
                case "beta":
                    if (Math.Sin(a * x) < 0)
                    {
                        Console.WriteLine("Error: the number under the root is negative, cannot be calculated.");
                    }
                    else
                    {
                        z = Math.Sqrt(Math.Sin(a * x));
                        Console.WriteLine($"Result: {z}");
                    }
                    break;
                case "3":
                case "gamma":
                    if ( a - x < 0)
                    {
                        Console.WriteLine("The logarithm is defined only for positive numbers. a - x is negative");
                    }
                    else
                    {
                        z = Math.Log(a-x);
                        Console.WriteLine($"Result: {z}");
                    }
                    break;
            }
        }
    }
}
