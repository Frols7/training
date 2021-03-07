using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTest
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }

        public ContactHelper RemoveContact(int s)
        {
            SelectContact(s);
            DeleteContact();
            manager.Navigator.GoToContactPage();
            return this;
        }
        public ContactHelper SelectContact(int s)
        {
            driver.FindElement(By.XPath("//input[@id][" + (s+1) + "]")).Click();
            return this;
        }

        private List<ContactData> contactCache = null;
        public List<ContactData> GetContactList()
        {
           if (contactCache == null)
            {
                contactCache = new List<ContactData>();
                manager.Navigator.GoToContactPage();
                ICollection<IWebElement> elementscontacts = driver.FindElements(By.XPath("//tr[@name='entry']"));
                foreach (IWebElement elementcontact in elementscontacts)
                {
                    contactCache.Add(new ContactData(elementcontact.Text));
                }
            }
            return new List<ContactData>(contactCache);
        }

        public ContactHelper DeleteContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            contactCache = null;
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public ContactHelper CreateContact(ContactData contact)
        {
            AddNewContact();
            CreatNewContact(contact);
            ReturToHomePage();
            return this;
        }

        public ContactHelper ModifyContact(int e, ContactData newContact)
        {
            EditContact(e);
            ClearLastFirstName();
            UpdateContact(newContact);
            ReturToHomePage();
            return this;
        }

        public ContactHelper ClearLastFirstName()
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("lastname")).Clear();
            return this;
        }

        public ContactHelper UpdateContact(ContactData contact)
        {
            Type(By.Name("firstname"), contact.FirstName);
            Type(By.Name("lastname"), contact.LastName);
            driver.FindElement(By.Name("update")).Click();
            contactCache = null;
            return this;
        }

        public ContactHelper EditContact(int e)
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])[" + (e+1) + "]")).Click();
            //driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }
        public ContactHelper CreatNewContact(ContactData contact)
        {
            Type(By.Name("firstname"), contact.FirstName);
            Type(By.Name("lastname"), contact.LastName);
            driver.FindElement(By.Name("submit")).Click();
            contactCache = null;
            return this;
        }
        public ContactHelper ReturToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;

        }
        public ContactHelper AddNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;

        }
    }
}