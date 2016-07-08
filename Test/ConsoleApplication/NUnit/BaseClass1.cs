using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace NUnit
{
    [TestFixture]
    public class BaseClass1
    {
        [TestFixtureSetUp]
        public void InitTest()
        {
            Console.WriteLine("Class init");
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
    }
}
