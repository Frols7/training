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
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupPage();
            app.Groups.InitNewGroupCreation();
            GroupData group = new GroupData("aa2");
            group.Header = "aa2";
            group.Footer = "aa2";
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitGroupCreation();
            app.Groups.ReturnToGroupsPage();
            app.Auth.LoginOut();
        }
    }
}
