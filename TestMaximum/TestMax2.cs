using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMaxProblems;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMax2
    {
        [Test]
        public void GivenMaxNumInPositionTwo_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(36, 83, 19);
            Assert.AreEqual(actual, 83);
        }
    }
}
