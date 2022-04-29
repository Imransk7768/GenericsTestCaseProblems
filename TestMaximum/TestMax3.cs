using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMaxProblems;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMax3
    {
        [Test]
        public void GivenStringMaxNumInPositionThree_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaXString("Orient", "Goldmedal", "Parcos");
            Assert.AreEqual(actual, "Parcos");
        }
    }
}
