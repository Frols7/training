using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTest
{
    [TestFixture]

    public class GroupRemoveTest : AuthTestBase
    {
        [Test]
        public void GroupRemoveTest1()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.CheckGroup();
            app.Groups.Remove(0);

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);

        }
    }
}
