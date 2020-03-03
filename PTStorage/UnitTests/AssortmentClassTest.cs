using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PTStorage;
using PTStorage.Equipment;
using PTStorage.Equipment.Antenna;
using PTStorage.Equipment.Cable;
using PTStorage.Equipment.Clock;
using PTStorage.Equipment.Meinberg;
using PTStorage.Equipment.Sedov;
using PTStorage.Options;

namespace UnitTests
{
    [TestClass]
    public class AssortmentClassTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assortment assortment = new Assortment();
        }

        [TestMethod]
        public void ADDTest()
        {
            Assortment assortment = new Assortment();

            assortment.AddElement(new Server());
            Assert.AreEqual(1, assortment.Servers.Count);

            assortment.AddElement(new Antenna());
            Assert.AreEqual(1, assortment.Antennas.Count);

            assortment.AddElement(new Cable());
            Assert.AreEqual(1, assortment.Cables.Count);

            assortment.AddElement(new Clock());
            Assert.AreEqual(1, assortment.Clocks.Count);

            assortment.AddElement(new Converter());
            Assert.AreEqual(1, assortment.Converters.Count);

            assortment.AddElement(new Receiver());
            Assert.AreEqual(1, assortment.Receivers.Count);

            assortment.AddElement(new SDU());
            Assert.AreEqual(1, assortment.Sdus.Count);

            assortment.AddElement(new SedovServer());
            Assert.AreEqual(1, assortment.SedovServers.Count);
        }

        [TestMethod]
        public void PreNameTest()
        {
            Assortment assortment = new Assortment();
            List<Option> t = new List<Option>();
            t.Add(OptionManager.GetOption("AD10-AD10"));
            t.Add(OptionManager.GetOption("GNS-HQ"));
            t.Add(OptionManager.GetOption("TC-2-2"));
            t.Add(OptionManager.GetOption("LNE"));
            assortment.AddElement(new Server("Test", "SimpleTest", 2, 8,t));
            Assert.AreEqual(PreName.STV+"Test", assortment.Servers[0].Name);

            assortment.AddElement(new Server("Test", "SimpleTest", 2, 8, t,true));
            Assert.AreEqual(PreName.USCHV + "Test", assortment.Servers[1].Name);

            assortment.AddElement(new Antenna("Test", "SimpleTest", 2, 8));
            Assert.AreEqual(PreName.ANTENNA + "Test", assortment.Antennas[0].Name);

            assortment.AddElement(new Cable("Test", "SimpleTest", 2, 8));
            Assert.AreEqual(PreName.CABLE + "Test", assortment.Cables[0].Name);

            assortment.AddElement(new Clock("Test", "SimpleTest", 2, 8));
            Assert.AreEqual(PreName.CLOCK + "Test", assortment.Clocks[0].Name);

            assortment.AddElement(new Converter("Test", "SimpleTest", 2, 8));
            Assert.AreEqual(PreName.SDUPlus + "Test", assortment.Converters[0].Name);

            assortment.AddElement(new Receiver("Test", "SimpleTest", 2, 8));
            Assert.AreEqual(PreName.RECEIVER + "Test", assortment.Receivers[0].Name);

            assortment.AddElement(new SDU("Test", "SimpleTest", 2, 8));
            Assert.AreEqual(PreName.SDUPlus + "Test", assortment.Sdus[0].Name);

            assortment.AddElement(new SedovServer("Test", "SimpleTest", 2, 8));
            Assert.AreEqual(PreName.STV + "Test", assortment.SedovServers[0].Name);
        }

    }
}
