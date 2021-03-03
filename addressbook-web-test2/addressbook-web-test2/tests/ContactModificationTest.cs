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
            app.Contacts.CheckContact();

            ContactData contact = new ContactData("New");
            contact.LastName = "Type";

            app.Contacts.ModifyContact(5, contact);
        }
    }
}
