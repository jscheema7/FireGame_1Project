using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGame_1Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_1Project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Winner win = new Winner();
            if (win.winTest(1) == 1) {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);

            }
        }
    }
}