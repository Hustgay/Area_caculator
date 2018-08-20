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
    public class RectangleTests
    {
       
        [TestMethod()]
        public void InputTwoPositiveNumb()
        {
            var Rectangle_Area1 = new Rectangle { Length = 2,Width=2 };
            Assert.AreEqual(Rectangle_Area1.Area, 4);
        }

        [TestMethod()]
        public void InputZero()
        {
            var Rectangle_Area2 = new Rectangle { Length = 0, Width = 0 };
            Assert.AreEqual(Rectangle_Area2.Area, 0);
        }

        [TestMethod()]
        public void InputTwoPassiveNumb()
        {
            var Rectangle_Area3 = new Rectangle { Length = -2, Width = -2 };
            Assert.AreEqual(Rectangle_Area3.Area, 0);
        }

        [TestMethod()]
        public void InputTwoWord()
        {
            var Rectangle_Area3 = new Rectangle { Length = 'a', Width = 'b' };
            Assert.IsInstanceOfType(Rectangle_Area3.Area, typeof(double));
        }

        [TestMethod]
        [ExpectedException(typeof(System.OverflowException))]
        public void AddTwoLargeNumber()
        {
            var Rectangle_Area4 = new Rectangle { Length = double.MaxValue, Width = double.MaxValue };
        }

    }
}
