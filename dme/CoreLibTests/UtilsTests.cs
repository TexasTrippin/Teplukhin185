using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Tests
{
    [TestClass()]
    public class UtilsTests
    {
        [TestMethod()]
        public void CheckPasswordTestTrue()
        {
            string password = "Admin1*df";
            string expected = "Хороший пароль";
            string actual = Utils.CheckPassword(password);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod()]
        public void CheckPasswordTestFalse ()
        {
            string password = "Aq1$";
            bool expected = false;
            string actual = Utils.CheckPassword(password);
            Assert.IsFalse(expected, actual);
        }
    }
}