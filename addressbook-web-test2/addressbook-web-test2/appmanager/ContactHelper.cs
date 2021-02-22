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

        public ContactHelper RemoveContact(int m)
        {
            SelectContact(m);
            DeleteContact();
            return this;

        }

        public ContactHelper SelectContact(int m)

        {
            driver.FindElement(By.XPath("//input[@id='" + m + "']")).Click();
            return this;
        }

        public ContactHelper DeleteContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
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
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.FirstName);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper EditContact(int e)
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])[" + e + "]")).Click();
            return this;
        }
        public ContactHelper CreatNewContact(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.FirstName);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);
            driver.FindElement(By.Name("submit")).Click();
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
