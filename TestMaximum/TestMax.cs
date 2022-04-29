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
        public void GivenFloatInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(9.9f, 6.6f, 3.3f);
            Assert.AreEqual(actual, 9.9f);
        }
    }
}
