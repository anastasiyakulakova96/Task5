using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Threading.Tasks;
using Math;

namespace UnitTestProject1
{
   
        [TestClass]
        public class DailyTest : BaseTestClass
        {
            int firstNumber = Int32.Parse(Data.firstNumber2);
            int secondNumber = Int32.Parse(Data.secondNumber2);

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            Console.WriteLine("Class init ");
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            Console.WriteLine("ClassCleanup");
        }

        [TestInitialize()]
        public void Initialize()
        {
            Console.WriteLine("TestMethodInit");
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Console.WriteLine("TestMethodCleanup");
        }

        Calculator calc = new Calculator();

            [TestMethod]
            [Timeout(1)]
            [Description("This test doing check sum. Zero number")]
            [Owner("user")]
            public void TestCheckSumWithZero()
            {
                Assert.AreEqual(((long)firstNumber + (long)secondNumber), calc.Sum(firstNumber, secondNumber));
            }

            [TestMethod]
            [Timeout(20)]
            [Description("This test doing check sum. Big int")]
            [Owner("user")]
            public void TestCheckSumWithBigInt()
            {
                Assert.AreEqual(((long)(Int32.MaxValue) + (long)(Int32.MaxValue)), calc.Sum((Int32.MaxValue), (Int32.MaxValue)));
            }

            [TestMethod]
            [Timeout(20)]
            [Description("This test doing check subtraction.Zero number")]
            [Owner("user")]
            public void TestCheckSubtractionWithZero()
            {
                Assert.AreEqual(((long)firstNumber - (long)secondNumber), calc.Subtraction(firstNumber, secondNumber));
            }

            [TestMethod]
            [Timeout(20)]
            [Description("This test doing check subtraction. Big int")]
            [Owner("user")]
            public void TestCheckSubtractionWithBigInt()
            {
                Assert.AreEqual(((long)(Int32.MaxValue) - (long)(Int32.MaxValue)), calc.Subtraction((Int32.MaxValue), (Int32.MaxValue)));
            }


            [TestMethod]
            [Timeout(10)]
            [Description("This test doing check multiplication.Zero number")]
            [Owner("user")]
            public void TestCheckMultiplicationWithZero()
            {
                Assert.AreEqual(((long)firstNumber * (long)secondNumber), calc.Multiplication(firstNumber, secondNumber));
            }

            [TestMethod]
            [Timeout(10)]
            [Description("This test doing check multiplication. Big int")]
            [Owner("user")]
            public void TestCheckMultiplicationWithBigInt()
            {
                Assert.AreEqual(((long)(Int32.MaxValue) * (long)(Int32.MaxValue)), calc.Multiplication((Int32.MaxValue), (Int32.MaxValue)));
            }



            [TestMethod]
            [Timeout(1000)]
            [Description("This test doing check division.Zero number")]
            [Owner("user")]
            [ExpectedException(typeof(DivideByZeroException))]
            public void TestCheckDivisionWithZero()
            {
                Assert.AreEqual(((int)firstNumber / (int)secondNumber), calc.Division(firstNumber, secondNumber));
            }

            [TestMethod]
            [Timeout(10)]
            [Description("This test doing check division.Big int")]
            [Owner("user")]
            public void TestCheckDivisionWithBigInt()
            {
                Assert.AreEqual(((long)(Int32.MaxValue) / (long)(Int32.MaxValue)), calc.Division((Int32.MaxValue), (Int32.MaxValue)));
            }

        }
    }

