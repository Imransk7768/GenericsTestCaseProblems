using FindMaxProblems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class TestMax
    {
        [Test]
        public void GivenIntInput_WhenTestMax_FirstPosition_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(56, 32, 31);
            Assert.AreEqual(actual, 56);
        }
    }
}
