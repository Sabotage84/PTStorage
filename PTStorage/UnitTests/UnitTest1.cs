using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PTStorage.Equipment.Meinberg;
using PTStorage.Equipment.Antenna;
using PTStorage.Equipment.Cable;
using PTStorage.Equipment.Clock;
using PTStorage.Equipment.Sedov;
using PTStorage.Equipment.Misc;

namespace UnitTests
{
    [TestClass]
    public class EqClassesTest
    {
        [TestMethod]
        public void CreateEmptyElemetsTest()
        {
            Server server=new Server();
            SDU sdu = new SDU();
            Converter converter = new Converter();
            Receiver receiver = new Receiver();
            SedovServer sedovServer = new SedovServer();
            Clock clock = new Clock();
            Cable cable = new Cable();
            Antenna antenna = new Antenna();
        }

        [TestMethod]
        public void CreateParametrizedSetrverTest()
        {
            Server server = new Server("Test","SimpleTest",2,8);
            Assert.AreEqual("Test", server.Name);
            Assert.AreEqual("SimpleTest", server.Description);
            Assert.AreEqual(2, server.EntryPrice);
            Assert.AreEqual(8, server.Price);
            Assert.AreEqual(4, server.Coefficient);
        }

        [TestMethod]
        public void CreateParametrizedSDUTest()
        {
            SDU testEl = new SDU("Test", "SimpleTest", 2, 8);
            Assert.AreEqual("Test", testEl.Name);
            Assert.AreEqual("SimpleTest", testEl.Description);
            Assert.AreEqual(2, testEl.EntryPrice);
            Assert.AreEqual(8, testEl.Price);
            Assert.AreEqual(4, testEl.Coefficient);
        }

        [TestMethod]
        public void CreateParametrizedConverterTest()
        {
            Converter testEl = new Converter("Test", "SimpleTest", 2, 8);
            Assert.AreEqual("Test", testEl.Name);
            Assert.AreEqual("SimpleTest", testEl.Description);
            Assert.AreEqual(2, testEl.EntryPrice);
            Assert.AreEqual(8, testEl.Price);
            Assert.AreEqual(4, testEl.Coefficient);
        }
        [TestMethod]
        public void CreateParametrizedReceiverTest()
        {
            Receiver testEl = new Receiver("Test", "SimpleTest", 2, 8);
            Assert.AreEqual("Test", testEl.Name);
            Assert.AreEqual("SimpleTest", testEl.Description);
            Assert.AreEqual(2, testEl.EntryPrice);
            Assert.AreEqual(8, testEl.Price);
            Assert.AreEqual(4, testEl.Coefficient);
        }
        [TestMethod]
        public void CreateParametrizedSedovSetrverTest()
        {
            SedovServer testEl = new SedovServer("Test", "SimpleTest", 2, 8);
            Assert.AreEqual("Test", testEl.Name);
            Assert.AreEqual("SimpleTest", testEl.Description);
            Assert.AreEqual(2, testEl.EntryPrice);
            Assert.AreEqual(8, testEl.Price);
            Assert.AreEqual(4, testEl.Coefficient);
        }
        [TestMethod]
        public void CreateParametrizedClockTest()
        {
            Clock testEl = new Clock("Test", "SimpleTest", 2, 8);
            Assert.AreEqual("Test", testEl.Name);
            Assert.AreEqual("SimpleTest", testEl.Description);
            Assert.AreEqual(2, testEl.EntryPrice);
            Assert.AreEqual(8, testEl.Price);
            Assert.AreEqual(4, testEl.Coefficient);
        }
        [TestMethod]
        public void CreateParametrizedCableTest()
        {
            Cable testEl = new Cable("Test", "SimpleTest", 2, 8);
            Assert.AreEqual("Test", testEl.Name);
            Assert.AreEqual("SimpleTest", testEl.Description);
            Assert.AreEqual(2, testEl.EntryPrice);
            Assert.AreEqual(8, testEl.Price);
            Assert.AreEqual(4, testEl.Coefficient);
        }
        [TestMethod]
        public void CreateParametrizedAntennaTest()
        {
            Antenna testEl = new Antenna("Test", "SimpleTest", 2, 8);
            Assert.AreEqual("Test", testEl.Name);
            Assert.AreEqual("SimpleTest", testEl.Description);
            Assert.AreEqual(2, testEl.EntryPrice);
            Assert.AreEqual(8, testEl.Price);
            Assert.AreEqual(4, testEl.Coefficient);
        }

        [TestMethod]
        public void VerificationConstructorTest()
        {
            Server server = new Server("Test", "SimpleTest", 2, 8);
            Assert.AreEqual(false, server.PossibilityOfVerification);
            server=new Server("Test", "SimpleTest", 2, 8, true);
            Assert.AreEqual(true, server.PossibilityOfVerification);

            SedovServer sedovServer = new SedovServer("Test", "SimpleTest", 2, 8);
            Assert.AreEqual(false, sedovServer.PossibilityOfVerification);
            sedovServer = new SedovServer("Test", "SimpleTest", 2, 8, true);
            Assert.AreEqual(true, sedovServer.PossibilityOfVerification);

        }

        [TestMethod]
        public void CreateParametrizedMiscTest()
        {
            Misc testEl = new Misc("Test", "SimpleTest", 2, 8);
            Assert.AreEqual("Test", testEl.Name);
            Assert.AreEqual("SimpleTest", testEl.Description);
            Assert.AreEqual(2, testEl.EntryPrice);
            Assert.AreEqual(8, testEl.Price);
            Assert.AreEqual(4, testEl.Coefficient);
        }


    }
}
