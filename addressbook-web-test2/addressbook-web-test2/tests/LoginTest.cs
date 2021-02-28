using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTest
{
    [TestFixture]
    public class LoginTest : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            app.Auth.LoginOut();

            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            app.Auth.LoginOut();

            AccountData account = new AccountData("admin", "123456");
            app.Auth.Login(account);
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }

    }
}
