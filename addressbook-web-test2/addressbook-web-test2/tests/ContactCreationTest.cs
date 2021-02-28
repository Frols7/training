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
    public class ContactCreationTest : AuthTestBase
    {
        [Test]
        public void TheUntitledTestCaseTest()
        {
            ContactData contact = new ContactData("Petro");
            contact.LastName = "Petrovich";

            app.Contacts.CreateContact(contact);
        }
    }
}
