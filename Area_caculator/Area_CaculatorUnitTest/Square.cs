using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area_Caculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Area_Caculator.Tests
{
    [TestClass]
        public class TestSquare1
        {
            [TestMethod]
            public void TestMethod()
            {
                var square_test1 = new Square { Side = 2.5 };
                Assert.AreEqual(square_test1.Area, 6.25);
            }
            [TestMethod]
            public void InputNegetiveIntergerSide()
            {
                var square_test2 = new Square { Side = 0 };
                Assert.AreEqual(square_test2.Area, 0);
            }
            [TestMethod]
            [ExpectedException(typeof(FormatException))]
            public void InputNotANumber()
            {
                var square_test3 = new Square { Side = Convert.ToDouble("a") };
            }
        }
    }
