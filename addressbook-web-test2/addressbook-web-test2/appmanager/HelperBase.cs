using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTest
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected IWebDriver driver;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }

        public void Type(By locator, string text)
        {
            if (text != null)
            {
                driver.FindElement(locator).Click();
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void CheckGroup()
        {
            if (IsElementPresent(By.Name("selected[]")))
            {
                return;
            }
            else
            {
                GroupData group = new GroupData("qwesdasd");
                group.Header = "qwqw";
                group.Footer = "asdsdad";
                manager.Groups.Create(group);
            }
        }
        public void CheckContact()
        {
            if (IsElementPresent(By.Name("selected[]")))
            {
                return;
            }
            else
            {
                ContactData contact = new ContactData("Frol");
                contact.LastName = "Sergeevich";
                manager.Contacts.CreateContact(contact);

            }
        }
    }
}