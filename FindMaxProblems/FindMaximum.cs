using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblems
{
    public class FindMaximum
    {
        public string FindMaXString(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("First Value is Greater : " + first);
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("Second Value is Greater : " + second);
                return second;
            }
            else
            {
                Console.WriteLine("Third Value is Greater : " + third);
                return third;
            }
        }
    }
}
