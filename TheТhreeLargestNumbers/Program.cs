using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheТhreeLargestNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числа: ");
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine(string.Join(", ", nums.OrderByDescending(x => x).Take(3).ToArray()));
        }
    }
}
