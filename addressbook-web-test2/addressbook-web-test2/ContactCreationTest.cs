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
    public class ContactCreationTest : TestBase
    {
        [Test]
        public void TheUntitledTestCaseTest()
        {
            navigator.OpenHomePage();
            loginHelper.Login(new AccountData ("admin", "secret"));
            contactHelper.AddNewContact();
            ContactData contact = new ContactData("Vova");
            contact.LastName = "Vovanich";
            contactHelper.CreatNewContact(contact);
            contactHelper.ReturToHomePage();
            loginHelper.LoginOut();
        }
    }
}
