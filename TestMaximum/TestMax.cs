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
        public void GivenStringInput_WhenTestMax_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaXString("Rehan", "Mahesh", "Jeo");
            Assert.AreEqual(actual, "Rehan");
        }
    }
}
