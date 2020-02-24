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
            Assert.AreEqual(1, assortment.servers.Count);

            assortment.AddElement(new Antenna());
            Assert.AreEqual(1, assortment.antennas.Count);

            assortment.AddElement(new Cable());
            Assert.AreEqual(1, assortment.cables.Count);

            assortment.AddElement(new Clock());
            Assert.AreEqual(1, assortment.clocks.Count);

            assortment.AddElement(new Converter());
            Assert.AreEqual(1, assortment.converters.Count);

            assortment.AddElement(new Receiver());
            Assert.AreEqual(1, assortment.receivers.Count);

            assortment.AddElement(new SDU());
            Assert.AreEqual(1, assortment.sdus.Count);

            assortment.AddElement(new SedovServer());
            Assert.AreEqual(1, assortment.sedovServers.Count);


        }

    }
}
