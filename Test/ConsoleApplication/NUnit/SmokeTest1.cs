using System;
using Math;
using NUnit.Framework;

namespace NUnit
{
    [TestFixture]
    public class SmokeTest1 : BaseClass1
    {

        int firstNumber = Int32.Parse(Data.firstNumber1);
        int secondNumber = Int32.Parse(Data.secondNumber1);

        Calculator calc;

        [TestFixtureSetUp]
        public void InitTest()
        {
            Console.WriteLine("Class init");
            calc = new Calculator();
        }

        [TestFixtureTearDown]
        public void Cleanup()
        {
            Console.WriteLine("ClassCleanup");
        }

        [SetUp]
        public void Init()
        {
            Console.WriteLine($"TestName{TestContext.CurrentContext.Test.Name}");
        }

        [TearDown]
        public void Dispose()
        {
            Console.WriteLine("TestMethodCleanup");
        }

        [Test]
        [Timeout(20)]
        [Description("This test doing check sum.Normal data")]
        public void TestCheckSum1()
        {
            Assert.AreEqual(((long)firstNumber + (long)secondNumber), calc.Sum(firstNumber, secondNumber));
        }

        [Test]
        [Timeout(20)]
        [Description("This test doing check sum. Normal data")]
        public void TestCheckSum2()
        {
            Assert.AreEqual(((long)secondNumber + (long)firstNumber), calc.Sum(secondNumber, firstNumber));
        }


        [Test]
        [Timeout(20)]
        [Description("This test doing check subtraction. Normal data")]
        public void TestCheckSubtraction1()
        {
            Assert.AreEqual(((long)firstNumber - (long)secondNumber), calc.Subtraction(firstNumber, secondNumber));
        }

        [Test]
        [Timeout(20)]
        [Description("This test doing check subtraction. Normal data")]
        public void TestCheckSubtraction2()
        {
            Assert.AreEqual(((long)secondNumber - (long)firstNumber), calc.Subtraction(secondNumber, firstNumber));
        }

        [Test]
        [Timeout(100)]
        [Description("This test doing check multiplication. Normal data")]
        public void TestCheckMultiplication1()
        {
            Assert.AreEqual(((long)firstNumber * (long)secondNumber), calc.Multiplication(firstNumber, secondNumber));
        }


        [Test]
        [Timeout(10)]
        [Description("This test doing check multiplication. Normal data")]
        public void TestCheckMultiplication2()
        {
            Assert.AreEqual(((long)secondNumber * (long)firstNumber), calc.Multiplication(secondNumber, firstNumber));
        }

        [Test]
        [Timeout(10)]
        [Description("This test doing check division . Normal data")]
        public void TestCheckDivision1()
        {
            Assert.AreEqual(((double)firstNumber / (double)secondNumber), calc.Division(firstNumber, secondNumber));
        }

        [Test]
        [Ignore("Ignore a test")]
        [Timeout(10)]
        [Description("This test doing check division. Normal data")]
        public void TestCheckDivision2()
        {
            Assert.AreEqual(((double)secondNumber / (double)firstNumber), calc.Division(secondNumber, firstNumber));
        }
    }
}
    