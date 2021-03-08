using System.Data;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Marathon;

namespace MarathonTests
{
    [TestClass]
    public class MarathonTests
    {
        [TestMethod]
        public void AutorizationTest()
        {
            string Login = "Scorcher@yandex.ru";
            string Password = "Qwerty1";
            string expectedRole = "R";
            string CurrentRole = String.Empty;

            DBConnection.Connect();
            DBConnection.Authorization(Login, Password);
            CurrentRole = DBConnection.Role;

            Assert.AreEqual(expectedRole, CurrentRole);
        }

        [TestMethod]
        public void GetUserId()
        {
            string CurrentEmail = "Scorcher@yandex.ru";
            DBConnection.GetEmail = CurrentEmail;
            int CurrentUserID;
            int ExpectedUserID = 5114;

            DBConnection.Connect();
            CurrentUserID = Convert.ToInt32(DBConnection.GetUserID());

            Assert.AreEqual(CurrentUserID, ExpectedUserID);
        }

        [TestMethod]
        public void GetMarathon()
        {
            string CurrentEmail = "Scorcher@yandex.ru";
            bool expectedFR = true;
            bool expectedSM = false;
            bool expectedFM = false;

            DBConnection.Connect();
            DBConnection.GetEmail = CurrentEmail;
            DBConnection.GetMarathon(DBConnection.GetEmail);

            Assert.AreEqual(expectedFR, DBConnection.FR);
            Assert.AreEqual(expectedSM, DBConnection.SM);
            Assert.AreEqual(expectedFM, DBConnection.FM);
        }
    }
}
