using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result_0 = Program.IsOdd(0);
            bool result_1 = Program.IsOdd(1);
            bool result_2 = Program.IsOdd(2);
            bool result_123 = Program.IsOdd(123);
            bool result_456 = Program.IsOdd(456);

            Assert.AreEqual(result_0, false);
            Assert.AreEqual(result_1, true);
            Assert.AreEqual(result_2, false);
            Assert.AreEqual(result_123, true);
            Assert.AreEqual(result_456, false);
        }
        [TestMethod]
        public void TestIsEven()
        {
            bool result_0 = Program.IsOdd(0);
            bool result_1 = Program.IsOdd(1);
            bool result_2 = Program.IsOdd(2);
            bool result_123 = Program.IsOdd(123);
            bool result_456 = Program.IsOdd(456);

            Assert.AreEqual(result_0, true);
            Assert.AreEqual(result_1, false);
            Assert.AreEqual(result_2, true);
            Assert.AreEqual(result_123, false);
            Assert.AreEqual(result_456, true);
        }
        [TestMethod]
        public void TestIsPrime()
        {
            bool result_0 = Program.IsPrime(0);
            bool result_1 = Program.IsPrime(1);
            bool result_2 = Program.IsPrime(2);
            bool result_3 = Program.IsPrime(3);
            bool result_13 = Program.IsPrime(13);
            bool result_14 = Program.IsPrime(14);

            Assert.AreEqual(result_0, false);
            Assert.AreEqual(result_1, false);
            Assert.AreEqual(result_2, true);
            Assert.AreEqual(result_3, true);
            Assert.AreEqual(result_13, true);
            Assert.AreEqual(result_14, false);
        }
        [TestMethod]
        public void TestSquare()
        {
            int result__1 = Program.Square(-1);
            int result_0 = Program.Square(0);
            int result_1 = Program.Square(1);
            int result_2 = Program.Square(2);
            int result_10 = Program.Square(10);

            Assert.AreEqual(result__1, 1);
            Assert.AreEqual(result_0, 0);
            Assert.AreEqual(result_1, 1);
            Assert.AreEqual(result_2, 4);
            Assert.AreEqual(result_10, 100);
        }
        [TestMethod]
        public void TestCube()
        {
            int result__1 = Program.Square(-1);
            int result_0 = Program.Square(0);
            int result_1 = Program.Square(1);
            int result_2 = Program.Square(2);
            int result_10 = Program.Square(10);

            Assert.AreEqual(result__1, -1);
            Assert.AreEqual(result_0, 0);
            Assert.AreEqual(result_1, 1);
            Assert.AreEqual(result_2, 8);
            Assert.AreEqual(result_10, 1000);
        }
        [TestMethod]
        public void TestPow()
        {
            int result_00 = Program.Pow(0, 0);
            int result_01 = Program.Pow(0, 1);
            int result_10 = Program.Pow(1, 0);
            int result_11 = Program.Pow(1, 1);
            int result_21 = Program.Pow(2, 1);
            int result_23 = Program.Pow(2, 3);

            Assert.AreEqual(result_00, 1);
            Assert.AreEqual(result_01, 0);
            Assert.AreEqual(result_10, 1);
            Assert.AreEqual(result_11, 1);
            Assert.AreEqual(result_21, 2);
            Assert.AreEqual(result_23, 8);
        }
        [TestMethod]
        public void TestAbs()
        {
            int result_0 = Program.Abs(0);
            int result_1 = Program.Abs(1);
            int result__2 = Program.Abs(-2);

            Assert.AreEqual(result_0, 0);
            Assert.AreEqual(result_1, 1);
            Assert.AreEqual(result__2, 2);
        }
        [TestMethod]
        public void TestCeil()
        {
            int result_52 = Program.Ceil(5.2);
            int result_50 = Program.Ceil(5.0);
            int result__52 = Program.Ceil(-5.2);

            Assert.AreEqual(result_52, 6);
            Assert.AreEqual(result_50, 5);
            Assert.AreEqual(result__52, 5);
        }
        [TestMethod]
        public void TestFloor()
        {
            int result_52 = Program.Floor(5.2);
            int result_50 = Program.Floor(5.0);
            int result__52 = Program.Floor(-5.2);

            Assert.AreEqual(result_52, 5);
            Assert.AreEqual(result_50, 5);
            Assert.AreEqual(result__52, 6);
        }
        [TestMethod]
        public void TestFactorial()
        {
            int result_0 = Program.Factorial(0);
            int result_1 = Program.Factorial(0);
            int result_10 = Program.Factorial(10);

            Assert.AreEqual(result_0, 1);
            Assert.AreEqual(result_1, 1);
            Assert.AreEqual(result_10, 3628800);
        }
    }
}
