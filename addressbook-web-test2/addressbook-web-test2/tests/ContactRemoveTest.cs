﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTest
{
    [TestFixture]
    public class ContactRemoveTest : AuthTestBase
    {
        [Test]
        public void ContactRemoveTest1()
        {
            app.Contacts.RemoveContact(1);
        }
    }
}