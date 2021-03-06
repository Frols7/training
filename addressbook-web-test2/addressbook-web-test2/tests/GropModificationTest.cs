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
            app.Groups.CheckGroup();

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            GroupData newData = new GroupData("new");
            newData.Header = "type";
            newData.Footer = "res";

            app.Groups.Modifai(0, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

            //List<GroupData> newGroups = app.Groups.GetGroupList();
            //Assert.AreEqual(oldGroups.Count, newGroups.Count);

        }
    }
}
