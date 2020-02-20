using PTStorage.Equipment;
using PTStorage.Equipment.Antenna;
using PTStorage.Equipment.Cable;
using PTStorage.Equipment.Clock;
using PTStorage.Equipment.Meinberg;
using PTStorage.Equipment.Sedov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage
{
    public class Assortment
    {
        List<Server> servers;
        List<Antenna> antennas;
        List<Cable> cables;
        List<Clock> clocks;
        List<Converter> converters;
        List<Receiver> receivers;
        List<SDU> sdus;
        List<SedovServer> sedovServers;

        public Assortment()
        {
            servers = new List<Server>();
            antennas = new List<Antenna>();
            cables = new List<Cable>();
            clocks = new List<Clock>();
            converters = new List<Converter>();
            receivers = new List<Receiver>();
            sdus = new List<SDU>();
            sedovServers = new List<SedovServer>();

        }

        public void AddElement(BaseEquip eq)
        {
            if (eq is Server)
            {
                servers.Add((Server)eq);
            }
        }

    }
}
