using System;
using NUnit.Framework;

namespace TestPaint
{
    [TestFixture]
    public class UnitTest
    {

        [SetUp]
        public void SetUp()
        {
            
        }

        [TestCase("Green")]
        [TestCase("Blue")]
        [TestCase("Red")]
        public void TestDataColorAction(string color)
        {
            
            //Assert.AreEqual();
        }

        [TestCase("Rectangle" )]
        [TestCase("Line")]
        [TestCase("Ellipse")]
        [TestCase("RRect")]
        public void TestDataTypeAction(string type)
        {
            //Assert.AreEqual();
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(10)]
        public void TestDataStrokeWidthAction(int width)
        {
            //Assert.AreEqual();
        }
    }
}
