using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PTStorage.Equipment.Meinberg;
using PTStorage.Equipment.Antenna;
using PTStorage.Equipment.Cable;
using PTStorage.Equipment.Clock;
using PTStorage.Equipment.Sedov;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateElemetsTest()
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
    }
}
