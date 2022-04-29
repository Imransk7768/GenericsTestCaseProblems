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
        public void GivenStringMaxNumInPositionOne_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaXString("Reliance", "Google", "Jio");
            Assert.AreEqual(actual, "Reliance");
        }
    }
}
