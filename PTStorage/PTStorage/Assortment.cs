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
            else if(eq is Antenna)
            {
                antennas.Add((Antenna)eq);
            }
            else if (eq is Cable)
            {
                cables.Add((Cable)eq);
            }
            else if(eq is Clock)
            {
                clocks.Add((Clock)eq);
            }
            else if (eq is Converter)
            {
                converters.Add((Converter)eq);
            }
            else if (eq is Receiver)
            {
                receivers.Add((Receiver)eq);
            }
            else if(eq is SDU)
            {
                sdus.Add((SDU)eq);
            }
            else if (eq is SedovServer)
            {
                sedovServers.Add((SedovServer)eq);
            }
        }

    }
}
