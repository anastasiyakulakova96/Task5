using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Threading.Tasks;
using Math;

namespace UnitTestProject1
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class SmokeTest : BaseTestClass
    {

        int firstNumber = Int32.Parse(Data.firstNumber1);
        int secondNumber = Int32.Parse(Data.secondNumber1);

        Calculator calc = new Calculator();

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            Console.WriteLine($"Class init {context.TestName}");
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

        [TestMethod]
        [Timeout(20)]
        [Description("This test doing check sum.Normal data")]
        [Owner("user")]
        public void TestCheckSum1()
        {
            Assert.AreEqual(((long)firstNumber + (long)secondNumber), calc.Sum(firstNumber, secondNumber));
        }

        [TestMethod]
        [Timeout(20)]
        [Description("This test doing check sum. Normal data")]
        [Owner("user")]
        public void TestCheckSum2()
        {
            Assert.AreEqual(((long)secondNumber + (long)firstNumber), calc.Sum(secondNumber, firstNumber));
        }


        [TestMethod]
        [Timeout(20)]
        [Description("This test doing check subtraction. Normal data")]
        [Owner("user")]
        public void TestCheckSubtraction1()
        {
            Assert.AreEqual(((long)firstNumber - (long)secondNumber), calc.Subtraction(firstNumber, secondNumber));
        }

        [TestMethod]
        [Timeout(20)]
        [Description("This test doing check subtraction. Normal data")]
        [Owner("user")]
        public void TestCheckSubtraction2()
        {
            Assert.AreEqual(((long)secondNumber - (long)firstNumber), calc.Subtraction(secondNumber, firstNumber));
        }

        [TestMethod]
        [Timeout(100)]
        [Description("This test doing check multiplication. Normal data")]
        [Owner("user")]
        public void TestCheckMultiplication1()
        {
            Assert.AreEqual(((long)firstNumber * (long)secondNumber), calc.Multiplication(firstNumber, secondNumber));
        }


        [TestMethod]
        [Timeout(10)]
        [Description("This test doing check multiplication. Normal data")]
        [Owner("user")]
        public void TestCheckMultiplication2()
        {
            Assert.AreEqual(((long)secondNumber * (long)firstNumber), calc.Multiplication(secondNumber, firstNumber));
        }

        [TestMethod]
        [Timeout(10)]
        [Description("This test doing check division . Normal data")]
        [Owner("user")]
        public void TestCheckDivision1()
        {
            Assert.AreEqual(((double)firstNumber / (double)secondNumber), calc.Division(firstNumber, secondNumber));
        }

        [TestMethod]
        [Ignore]
        [Timeout(10)]
        [Description("This test doing check division. Normal data")]
        [Owner("user")]
        public void TestCheckDivision2()
        {
            Assert.AreEqual(((double)secondNumber / (double)firstNumber), calc.Division(secondNumber, firstNumber));
        }
    }
}
