using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int>()
            {
                1,2,3
            };
            var list2 = new List<int>()
            {
                2,3
            };

            var difference = Difference.DifferenceMethodSyntax(list1,list2);

            Console.WriteLine("Difference between lists (Method Syntax):");
            foreach (var element in difference)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

            var differences = Difference.DifferenceQuerySyntax(list1,list2);

            Console.WriteLine("Difference between lists (Query syntax):");
            foreach (var element in differences)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

        }
    }
}
