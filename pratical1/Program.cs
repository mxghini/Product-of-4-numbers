using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratical1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no1, no2, no3, no4, ans;
            Console.Write("First Number ");
            no1 = int.Parse(Console.ReadLine());
            Console.Write("Second Number ");
            no2 = int.Parse(Console.ReadLine());
            Console.Write("Third Number ");
            no3 = int.Parse(Console.ReadLine());
            Console.Write("Fourth Number ");
            no4 = int.Parse(Console.ReadLine());
            ans = no1 * no2 * no3 * no4;
            Console.WriteLine("Product of numbers are " + ans);
            Console.ReadKey();

        }
    }
}
