using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Math;

namespace NUnit
{
    [TestFixture]
    public class DailyClass1 : BaseClass1
    {
        int firstNumber = Int32.Parse(Data.firsNumber2);
        int secondNumber = Int32.Parse(Data.secondNumber2);
        int result;
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
        [Timeout(1)]
        [Description("This test doing check sum. Zero number")]
        public void TestCheckSumWithZero()
        {
            Assert.AreEqual(((long)firstNumber + (long)secondNumber), calc.Sum(firstNumber, secondNumber));
        }

        [Test]
        [Timeout(40)]
        [Description("This test doing check sum. Big int")]
        public void TestCheckSumWithBigInt()
        {
            Assert.AreEqual((long)(Int32.MaxValue) + (long)(Int32.MaxValue), calc.Sum((long)(Int32.MaxValue), (long)(Int32.MaxValue)));
        }



        [Test]
        [Timeout(200)]
        [Description("This test doing check multiplication")]
        [TestCase(4, 3, 12)]
        [TestCase(1, 2, 2)]
        public void TestCheckMultiplication1(int n, int d, int q)
        {
            Assert.AreEqual(((long)(Int32.MaxValue) * (long)(Int32.MaxValue)), calc.Multiplication((Int32.MaxValue), (Int32.MaxValue)));
            Assert.AreEqual(q, n * d);
        }

        [Test]
        [Timeout(300)]
        [Description("This test doing check division.Zero number")]
        public void TestCheckDivisionWithZero()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Division(firstNumber, secondNumber));
        }
    }
}

