using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace addressbook_web_test2
{
    [TestClass]
    public class SquareAndCircleTest
    {
        [TestMethod]
        public void TestMethodSquare()
        {
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            Square s3 = s1;

            Assert.AreEqual(s1.Size, 5);
            Assert.AreEqual(s2.Size, 10);
            Assert.AreEqual(s3.Size, 5);

            s3.Size = 15;

            Assert.AreEqual(s3.Size, 15);

            s2.Colored = true;

            Assert.AreEqual(s2.Colored, true);
        }

        public void TestMethodCirkle()
        {
            Circle r1 = new Circle(100);
            Circle r2 = new Circle(200);
            Circle r3 = r1;

            Assert.AreEqual(r1.Radius, 100);
            Assert.AreEqual(r3.Radius, 100);

            r3.Radius = 50;
            Assert.AreEqual(r3.Radius, 50);


        }

    }
}
