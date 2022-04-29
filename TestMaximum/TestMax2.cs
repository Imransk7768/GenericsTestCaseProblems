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
        public void GivenStringMaxNumInPositionTwo_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaXString("Reliance", "Tata", "Birla");
            Assert.AreEqual(actual, "Tata");
        }
    }
}
