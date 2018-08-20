using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area_Caculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Caculator.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void InputTwoPositiveNumb()
        {
            var Triangle_Area1 = new Triangle { Height = 2, Base_side = 2 };
            Assert.AreEqual(Triangle_Area1.Area, 2);
        }
        [TestMethod()]
        public void InputZero()
        {
            var Triangle_Area2 = new Triangle { Height = 0, Base_side = 0 };
            Assert.AreEqual(Triangle_Area2.Area, 0);
        }
        [TestMethod()]
        public void InputTwoPassiveNumb()
        {
            var Triangle_Area3 = new Triangle { Height = -2, Base_side = -2 };
            Assert.AreEqual(Triangle_Area3.Area, 0);
        }
        [TestMethod()]
        public void InputTwoWord()
        {
            var Triangle_Area3 = new Triangle { Height = 'a', Base_side = 'b' };
            Assert.IsInstanceOfType(Triangle_Area3.Area, typeof(double));
        }
        [TestMethod]
        [ExpectedException(typeof(System.OverflowException))]
        public void AddTwoLargeNumber()
        {
            var Triangle_Area4 = new Triangle { Height = double.MaxValue, Base_side = double.MaxValue };
        }
    }
}