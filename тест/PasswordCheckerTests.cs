using Microsoft.VisualStudio.TestTools.UnitTesting;
using mak1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mak1.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            // Arrange

            string password = "ASDqwe123$";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.validatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_4Symbols_ReturnsFalse()
        {
            // Arrange

            string password = "Qw$1";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.validatePassword(password);

            // Assert
            Assert.IsFalse (actual);
        }
        [TestMethod()]
        public void Check_21Symbols_ReturnsFalse()
        {
            // Arrange

            string password = "Qwertyuiodsadasdsada$";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.validatePassword(password);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Numbers_ReturnsTrue()
        {
            // Arrange

            string password = "Fsjafjasgfjsa123#";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.validatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_NumbersNot_ReturnsFalse()
        {
            // Arrange

            string password = "Fsjafjasgfjsa";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.validatePassword(password);

            // Assert
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void SpecialSymbols_ReturnsTrue()
        {
            // Arrange

            string password = "Djsmiavhnu$123";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.validatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SpecialSymbolsNot_ReturnsFalse()
        {
            // Arrange

            string password = "Djsmiavhnu";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.validatePassword(password);

            // Assert
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void ZaglavnBukva_ReturnsTrue()
        {
            // Arrange

            string password = "Fdasdds123%";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.validatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ZaglavnBukvaNot_ReturnsFalse()
        {
            // Arrange

            string password = "dgdsjgiasiny";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.validatePassword(password);

            // Assert
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void StrochnieBukvi_ReturnsTrue()
        {
            // Arrange

            string password = "Fdasdds123%";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.validatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void StrochnieBukviNot_ReturnsFalse()
        {
            // Arrange

            string password = "FADADFAFA";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.validatePassword(password);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}