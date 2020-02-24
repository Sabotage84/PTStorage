using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PTStorage;
using PTStorage.Equipment;
using PTStorage.Equipment.Antenna;
using PTStorage.Equipment.Cable;
using PTStorage.Equipment.Clock;
using PTStorage.Equipment.Meinberg;
using PTStorage.Equipment.Sedov;

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

    }
}
