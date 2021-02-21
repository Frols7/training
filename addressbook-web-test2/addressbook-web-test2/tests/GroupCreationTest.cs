﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTest
{
    [TestFixture]
    public class GroupCreationTest : TestBase
    {
        [Test]
        public void GroupCreationTest1()
        {
            GroupData group = new GroupData("aa1");
            group.Header = "aa2";
            group.Footer = "aa2";
            
            app.Groups.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest1()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            
            app.Groups.Create(group);
        }
    }
}
