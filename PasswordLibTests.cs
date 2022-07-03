using Microsoft.VisualStudio.TestTools.UnitTesting;
using DanekTerminator195;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanekTerminator195.Tests
{
    [TestClass()]
    public class PasswordLibTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            string password = "PassEigh";
            bool expected = true;
            string permit;
            bool actual = PasswordLib.CheckPass(password);
            if (actual == true) permit = "Ваш пароль подходит"; else permit = "Ваш пароль не подходит";
            PasswordLib.PasswordCW(password, permit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_More20Symbols_ReturnsFalse()
        {
            string password = "PassMoreThenTwentySymbols";
            string permit;
            bool actual = PasswordLib.CheckPass(password);
            if (actual == true) permit = "Ваш пароль подходит"; else permit = "Ваш пароль не подходит";
            PasswordLib.PasswordCW(password, permit);
            Assert.IsFalse(actual);
        }


        [TestMethod()]
        public void Check_HasDigits_ReturnsTrue()
        {
            string password = "Pass4asDigs";
            bool expected = true;
            string permit;
            bool actual = PasswordLib.CheckPass(password);
            if (actual == true) permit = "Ваш пароль подходит"; else permit = "Ваш пароль не подходит";
            PasswordLib.PasswordCW(password, permit);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_HasDigits_ReturnsFalse()
        {
            string password = "Passwithchars";
            string permit;
            bool actual = PasswordLib.CheckPass(password);
            if (actual == true) permit = "Ваш пароль подходит"; else permit = "Ваш пароль не подходит";
            PasswordLib.PasswordCW(password, permit);
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_HasSpecSymb_ReturnsTrue()
        {
            string password = "ThisPassHasSpec%^&";
            bool expected = true;
            string permit;
            bool actual = PasswordLib.CheckPass(password);
            if (actual == true) permit = "Ваш пароль подходит"; else permit = "Ваш пароль не подходит";
            PasswordLib.PasswordCW(password, permit);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_HasSpecSymb_ReturnsFalse()
        {
            string password = "nospecsymbols";
            string permit;
            bool actual = PasswordLib.CheckPass(password);
            if (actual == true) permit = "Ваш пароль подходит"; else permit = "Ваш пароль не подходит";
            PasswordLib.PasswordCW(password, permit);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_HasUpperLowerCase_ReturnsTrue()
        {
            string password = "HasUpperCase";
            bool expected = true;
            string permit;
            bool actual = PasswordLib.CheckPass(password);
            if (actual == true) permit = "Ваш пароль подходит"; else permit = "Ваш пароль не подходит";
            PasswordLib.PasswordCW(password, permit);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_HasUpperLowerCase_ReturnsFalse()
        {
            string password = "hasonlylower";
            string permit;
            bool actual = PasswordLib.CheckPass(password);
            if (actual == true) permit = "Ваш пароль подходит"; else permit = "Ваш пароль не подходит";
            PasswordLib.PasswordCW(password, permit);

            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void Check_AllRequirements_ReturnsTrue()
        {
            string password = "ThisPassCanBeTake8_";
            bool expected = true;
            string permit;
            bool actual = PasswordLib.CheckPass(password);
            if (actual == true) permit = "Ваш пароль подходит"; else permit = "Ваш пароль не подходит";
            PasswordLib.PasswordCW(password, permit);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
