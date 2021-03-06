using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
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

            List<ContactData> oldContact = app.Contacts.GetContactList();

            app.Contacts.CreateContact(contact);

            List<ContactData> newContact = app.Contacts.GetContactList();

            newContact.RemoveAt(0);
            Assert.AreEqual(oldContact, newContact);  
            //Assert.AreEqual(oldContact.Count +1, newContact.Count);

        }
    }
}
