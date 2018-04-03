using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversions;

namespace ConsoleTests.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MyTestMethodTest()
        {
            Console.WriteLine(Weight.GramsToLBSandOZ(1770));
            
            Assert.IsTrue(true);
        }
    }
}