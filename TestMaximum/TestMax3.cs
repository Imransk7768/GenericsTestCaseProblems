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
        public void GivenFloatMaxNumInPositionThree_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(26.9f, 34.5f, 97.5f);
            Assert.AreEqual(actual, 97.5f);
        }
    }
}
