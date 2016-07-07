using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BaseTestClass
    {

        public TestContext Context { get; set; }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            Console.WriteLine("Class init");
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            Console.WriteLine("ClassCleanup");
        }

        [TestInitialize()]
        public void Initialize()
        {
            Console.WriteLine($"TestMethodInit{Context.TestName}");
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Console.WriteLine("TestMethodCleanup");
        }
    }
}
