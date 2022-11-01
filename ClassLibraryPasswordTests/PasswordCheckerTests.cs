using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            //Arrage.
            string password = "ASqw12$$";
            bool expected = true;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_4Symbols_ReturnsTrue()
        {
            //Arrage.
            string password = "Aq1$";
            

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_30Symbols_ReturnsFalse()
        {
            //Arrage.
            string password = "ASDqwe123$ASDqwe123$ASDqwe123$";
            bool expected = false;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithDigits_ReturnsTrue()
        {
            //Arrage.
            string password = "ASDqwe1$";
            bool expected  = true;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithoutDigits_ReturnsFalse()
        {
            //Arrage.
            string password = "ASDqweASD$";
            bool expected = false;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithSpecSymbols_ReturnsTrue()
        {
            //Arrage.
            string password = "Aqwe123$";
            bool expected = true;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithoutSpecSymbols_ReturnsFalse()
        {
            //Arrage.
            string password = "ASDqwe123";
            bool expected = false;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithCapsSymbols_ReturnsTrue()
        {
            //Arrage.
            string password = "Aqwe123$";
            bool expected = true;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithoutCapsSymbols_ReturnsFalse()
        {
            //Arrage.
            string password = "asdqwe123$";
            bool expected = false;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_ReturnsTrue()
        {
            //Arrage.
            string password = "ASDq123$";
            bool expected = true;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_ReturnsFalse()
        {
            //Arrage.
            string password = "ASDQWE123$";
            bool expected = false;

            //Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}