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
            ContactData contact = new ContactData("Vova");
            contact.LastName = "Vovanich";

            app.Contacts.CreateContact(contact);
        }
    }
}
