using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTest
{
    [TestFixture]
    public class GropModifacationTest : AuthTestBase
    {
        [Test]
        public void GropModifacationTest1()
        {
            GroupData newData = new GroupData("new");
            newData.Header = "type";
            newData.Footer = "res";

            app.Groups.Modifai(3, newData);
        }
    }
}
