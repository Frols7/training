﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTest
{
    [TestFixture]

    public class GroupRemoveTest : TestBase
    {
        [Test]
        public void GroupRemoveTest1()
        {
            app.Groups.Remove(1);
        }
    }
}
