using System;
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
            app.Contacts.CheckContact();

            List<ContactData> oldContact = app.Contacts.GetContactList();

            app.Contacts.RemoveContact(0);

            List<ContactData> newContact = app.Contacts.GetContactList();

            oldContact.RemoveAt(0);
            Assert.AreEqual(oldContact, newContact);
        }
    }
}
