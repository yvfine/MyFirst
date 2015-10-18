using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nisui;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = new int[] { 8, 2, 58, 34, 153, 4 };
            int[] b = new int[] { 2, 4, 8, 34, 58, 153 };
            Program.Sort(a);
            Assert.IsTrue(a.SequenceEqual(b));
        }
    }
}
