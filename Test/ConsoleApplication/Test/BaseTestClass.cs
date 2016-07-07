using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
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
            public  void Initialize()
            {
                Console.WriteLine($"TestMethodInit{Context.TestName}");
            }

            [TestCleanup()]
            public  void Cleanup()
            {
                Console.WriteLine("TestMethodCleanup");
            }
        }
    
}
