using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFirstCase()
        {
            double argX = 0.5;
            double argB = 1;
            double argC = 1;
            double argA = 1;
            double result = Programm.Min(argX,argA,argB,argC);
            double expected = 2.125;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CheckSecondCase()
        {
            double argX = 0.7;
            double argB = -1;
            double argC = 1;
            double argA = 1;
            double result = Programm.Min(argX, argA, argB, argC);
            double expected = 1;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CheckThirdCase()
        {
            double argX = 0.7;
            double argB = 1;
            double argC = 1;
            double argA = 1;
            double result = Programm.Min(argX, argA, argB, argC);
            double expected = 1.4;
            Assert.AreEqual(expected, result);
        }
    }
}
