using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area_Caculator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Area_Caculator.Tests
{
    [TestClass()]
    public class CircleTests
    {

        [TestMethod()]
        public void InputOnePositiveNumb()
        {
            var Circle_Area1 = new Circle { Diameter = 1 };
            Assert.AreEqual(Circle_Area1.Area, 3.1415926 * 1 * 1 / 4);
        }

        [TestMethod()]
        public void InputZero()
        {
            var Circle_Area2 = new Circle { Diameter = 0 };
            Assert.AreEqual(Circle_Area2.Area, 0);
        }

        [TestMethod()]
        public void InputOnePassiveNumb()
        {
            var Circle_Area3 = new Circle { Diameter = -1 };
            Assert.AreEqual(Circle_Area3.Area, 0);
        }

        [TestMethod()]
        public void InputOneWord()
        {
            var Circle_Area3 = new Circle { Diameter = 'a' };
            Assert.IsInstanceOfType(Circle_Area3.Area, typeof(double));
        }

    }
}
