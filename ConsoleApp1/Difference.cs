using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDifference
{
    class Difference
    {
        /// <summary>
        /// Método que devuelve los elementos diferneciales entre dos listas utilizando method syntax.
        /// </summary>
        public static IEnumerable<int> DifferenceMethodSyntax(List<int> list1, List<int> list2)
        {
            if (list1.Count == 0)
            {
                throw new ArgumentException("List1 cannot be empty");
            }
            if (list2.Count == 0)
            {
                throw new ArgumentException("List2 cannot be empty");
            }
            return list1.Where(number => !list2.Contains(number));
        }
        /// <summary>
        /// Método que devuelve los elementos diferneciales entre dos listas utilizando query syntax.
        /// </summary>
        public static IEnumerable<int> DifferenceQuerySyntax(List<int> list1, List<int> list2)
        {
            if (list1.Count == 0)
            {
                throw new ArgumentException("List1 cannot be empty");
            }
            if (list2.Count == 0)
            {
                throw new ArgumentException("List2 cannot be empty");
            }
            /*var difference = from number in list1
                         join r in list2 
                         on number equals r into numbers
                         where !numbers.Any()
                         select number;*/
            var differences = from number in list1
                              where !list2.Contains(number)
                              select number;
            return differences;
        }
    }
}
