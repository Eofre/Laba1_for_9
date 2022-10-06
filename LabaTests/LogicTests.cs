using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void MinTest()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 0, 67 };
            var message = Logic.Min(numbers);
            Assert.AreEqual("Наименьшие числа равны 0 и 1", message);
      }

        [TestMethod()]
        public void MaxTest()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 0, 67 };
            var message = Logic.Max(numbers);
            Assert.AreEqual("Наибольшие числа равны 67 и 6", message);
        }
    }
}