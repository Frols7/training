﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTest
{
    [TestFixture]
    public class ContactModificationTest : TestBase
    {
        [Test]
        public void ContactModificationTest1()
        {
            ContactData contact = new ContactData("Andrei");
            contact.LastName = "Petrovrerer";

            app.Contacts.ModifyContact(5, contact);
        }
    }
}