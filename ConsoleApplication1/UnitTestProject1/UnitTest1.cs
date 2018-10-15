﻿using System;
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
        }
        [TestMethod]
        public void TestAbs()
        {
        }
        [TestMethod]
        public void TestCeil()
        {
        }
        [TestMethod]
        public void TestFloor()
        {
        }
        [TestMethod]
        public void TestFractorial()
        {
        }
    }
}
