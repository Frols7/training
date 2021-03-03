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
            return this;
        }
        public ContactHelper SelectContact(int s)
        {
            driver.FindElement(By.XPath("//input[@id][" + s + "]")).Click();
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
            Type(By.Name("firstname"), contact.FirstName);
            Type(By.Name("lastname"), contact.LastName);
            return this;
        }

        public ContactHelper EditContact(int e)
        {
            //driver.FindElement(By.XPath("(//img[@alt='Edit'])[" + e + "]")).Click();
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }
        public ContactHelper CreatNewContact(ContactData contact)
        {
            Type(By.Name("firstname"), contact.FirstName);
            Type(By.Name("lastname"), contact.LastName);
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