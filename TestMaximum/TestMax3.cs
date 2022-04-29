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
        public void GivenMaxNumInPositionThree_WhenTestMax_ShouldRAETURNMaxNum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(19, 32, 39);
            Assert.AreEqual(actual, 39);
        }
    }
}
