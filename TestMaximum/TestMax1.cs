using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMaxProblems;
using NUnit.Framework;

namespace TestMaximum
{
    public class TestMax1
    {
        [Test]
        public void GivenMaxNumInPositionOne_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(78, 55, 12);
            Assert.AreEqual(actual, 78);
        }
    }
}
