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
        public void GivenFloatMaxNumInPositionTwo_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(18.5f, 67.3f, 34.6f);
            Assert.AreEqual(actual, 67.3f);
        }
    }
}
