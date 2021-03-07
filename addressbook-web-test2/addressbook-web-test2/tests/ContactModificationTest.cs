using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTest
{
    [TestFixture]
    public class ContactModificationTest : AuthTestBase
    {
        [Test]
        public void ContactModificationTest1()
        {
            ContactData contact = new ContactData("New");
            contact.LastName = "Type";
           
            app.Contacts.CheckContact();

            List<ContactData> oldContact = app.Contacts.GetContactList();

            app.Contacts.ModifyContact(0, contact);

            List<ContactData> newContact = app.Contacts.GetContactList(); 
            //Assert.AreEqual(oldContact, newContact);
            Assert.AreEqual(oldContact.Count, newContact.Count);
        }
    }
}
