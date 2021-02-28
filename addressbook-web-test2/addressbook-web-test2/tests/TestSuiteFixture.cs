using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTest
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
        [SetUp]
        public void IntilApplicationManager()
        {
            ApplicationManager app = ApplicationManager.GetInstance();
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]

        public void StopApplicationManager()
        {
            ApplicationManager.GetInstance().Auth.LoginOut();
        }
    }
}
