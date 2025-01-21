using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class MyClassTests
    {
        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(5, MyClass.Sum(3, 2));
        }
    }
}