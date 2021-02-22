using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTest
{
    [TestFixture]
    public class GropModifacationTest : TestBase
    {
        [Test]
        public void GropModifacationTest1()
        {
            GroupData newData = new GroupData("eee");
            newData.Header = "www";
            newData.Footer = "fff";

            app.Groups.Modifai(1, newData);
        }
    }
}
