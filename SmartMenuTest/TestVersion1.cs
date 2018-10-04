using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartMenuLibrary2;

namespace SmartMenuTest
{
    [TestClass]
    public class TestVersion1
    {
        private SmartMenu smartMenu;

        [TestInitialize]
        public void SetupForTest()
        {
            smartMenu = new SmartMenu();
            smartMenu.LoadMenu("MenuSpec.txt");
        }

        [TestMethod]
        public void ShouldCheckTitle()
        {
            Assert.AreEqual("Min Fantastiske Menu", smartMenu.Title());
        }

        [TestMethod]
        public void ShouldCheckMenuValg()
        {
            Assert.AreEqual("(Tryk paa menupunkt eller 0 for at afslutte)", smartMenu.MenuValg());
        }

        [TestMethod]
        public void ShouldCheckMenuPunkt()
        {
            Assert.AreEqual("1. Goer dette", smartMenu.MenuPunkt());
        }

        [TestMethod]
        public void ShouldCheckMenuId()
        {
            Assert.AreEqual("1", smartMenu.MenuId());
        }
    }
}
