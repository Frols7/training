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
        public ContactHelper(IWebDriver driver) : base(driver)
        {
        }
        public void CreatNewContact(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.FirstName);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);
            driver.FindElement(By.Name("submit")).Click();
        }
        public void ReturToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }
        public void AddNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
    }
}
