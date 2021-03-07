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

            GroupData newData = new GroupData("new");
            newData.Header = "type";
            newData.Footer = "res";

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData oldData = oldGroups[0];


            app.Groups.Modifai(0, newData);

            Assert.AreEqual(oldGroups.Count, app.Groups.GetGroupCount());

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData group in newGroups)
            {
                if (group.id == oldData.id)
                {
                    Assert.AreEqual(newData.Name, group.Name);
                }
            }

            //List<GroupData> newGroups = app.Groups.GetGroupList();
            //Assert.AreEqual(oldGroups.Count, newGroups.Count);

        }
    }
}
