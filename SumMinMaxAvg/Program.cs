using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой числа: ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int sum = nums.Sum();
            int min = nums.Min();
            int max = nums.Max();
            double avg = nums.Average();

            Console.WriteLine("------------------------");
            Console.WriteLine($"First element:{nums[0]}");
            Console.WriteLine($"Sum:{sum}");
            Console.WriteLine($"Min:{min}");
            Console.WriteLine($"Max:{max}");
            Console.WriteLine($"Avg:{avg}");
            Console.WriteLine($"First element:{nums[0]}");
        }
    }
}
