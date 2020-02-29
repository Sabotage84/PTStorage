﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PTStorage.Options;

namespace UnitTests
{
    [TestClass]
    public class OptionsTests
    {
        [TestMethod]
        public void OptionCtorTest()
        {
            Option option = new Option();
            Option op = new Option("TC", 2);
            Assert.AreEqual("TC-2-2", op.FullName);
            op= new Option ("LNE",2);
            Assert.AreEqual("2LNE", op.FullName);
            op = new Option("GE", 3);
            Assert.AreEqual("3GE", op.FullName);
            op = new Option("FS", 2);
            Assert.AreEqual("FS-2", op.FullName);
            op = new Option("TC");
            Assert.AreEqual("TC-1-1", op.FullName);
        }

        [TestMethod]
        public void OptionLoadTest()
        {
            OptionManager.TestMeth();
            Assert.AreEqual(3, OptionManager.AllOptions.Count);
        }

        [TestMethod]
        public void OptionLoadWithotFileTest()
        {
            OptionManager.TestMeth();
            Assert.AreEqual(16, OptionManager.AllOptions.Count);
        }

        [TestMethod]
        public void AddOptionTest()
        {
            OptionManager.TestMeth();
            int t = OptionManager.AllOptions.Count;
            OptionManager.AddOption(new Option("GNS-HQ"));
            Assert.AreEqual(t+1, OptionManager.AllOptions.Count);
            OptionManager.AddOption(new Option("GNS-HQ"));
            Assert.AreEqual(t + 1, OptionManager.AllOptions.Count);
        }


    }
}
