using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTest
{
    [TestFixture]
    public class GroupCreationTest : TestBase
    {
        [Test]
        public void GroupCreationTest1()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupPage();
            InitNewGroupCreation();
            GroupData group = new GroupData("aa2");
            group.Header = "aa2";
            group.Footer = "aa2";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            LoginOut();
        }
    }
}
