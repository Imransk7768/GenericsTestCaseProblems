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
        public void GivenFloatMaxNumInPositionOne_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(57.4f, 28.3f, 36.9f);
            Assert.AreEqual(actual, 57.4f);
        }
    }
}
