using System;
using InstrumentalToolsHW;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MinusRectangle()
        {
            Figure F = null;
            try
            {
                F = new Rectangle(-10.0, 17.8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Assert.IsNull(F);
            }
        }

        [TestMethod]
        public void MinusRound()
        {
            Figure F = null;
            try
            {
                F = new Round(-10.0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Assert.IsNull(F);
            }
        }

        [TestMethod]
        public void MinusTriangle()
        {
            Figure F = null;
            try
            {
                F = new Triangle(-10.0, 10.0, 10.0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Assert.IsNull(F);
            }
        }

        [TestMethod]
        public void PerimeterTest()
        {
            Figure F1 = new Round(10);
            Figure F2 = new Rectangle(3, 4);
            Figure F3 = new Triangle(3, 4, 5);
            Assert.IsTrue(System.Math.Abs(62.83185307 - F1.Perimeter()) < 0.00000001);
            Assert.AreEqual(14.0, F2.Perimeter());
            Assert.AreEqual(12.0, F3.Perimeter());
        }

        [TestMethod]
        public void SizeTest()
        {
            Figure F1 = new Round(10);
            Figure F2 = new Rectangle(3, 4);
            Figure F3 = new Triangle(3, 4, 5);
            Assert.IsTrue(System.Math.Abs(314.159265 - F1.Size()) < 0.000001);
            Assert.AreEqual(12.0, F2.Size());
            Assert.AreEqual(6.0, F3.Size());
        }
    }
}
