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
            Servers = new List<Server>();
            Antennas = new List<Antenna>();
            Cables = new List<Cable>();
            Clocks = new List<Clock>();
            Converters = new List<Converter>();
            Receivers = new List<Receiver>();
            Sdus = new List<SDU>();
            SedovServers = new List<SedovServer>();

        }

        public List<Server> Servers { get => servers; set => servers = value; }
        public List<Antenna> Antennas { get => antennas; set => antennas = value; }
        public List<Cable> Cables { get => cables; set => cables = value; }
        public List<Clock> Clocks { get => clocks; set => clocks = value; }
        public List<Converter> Converters { get => converters; set => converters = value; }
        public List<Receiver> Receivers { get => receivers; set => receivers = value; }
        public List<SDU> Sdus { get => sdus; set => sdus = value; }
        public List<SedovServer> SedovServers { get => sedovServers; set => sedovServers = value; }

        public void AddElement(BaseEquip eq)
        {
            if (eq is Server)
            {
                Servers.Add((Server)eq);
                Servers.Sort();
            }
            else if(eq is Antenna)
            {
                Antennas.Add((Antenna)eq);
                Antennas.Sort();
            }
            else if (eq is Cable)
            {
                Cables.Add((Cable)eq);
                Cables.Sort();
            }
            else if(eq is Clock)
            {
                Clocks.Add((Clock)eq);
                Clocks.Sort();
            }
            else if (eq is Converter)
            {
                Converters.Add((Converter)eq);
                Converters.Sort();
            }
            else if (eq is Receiver)
            {
                Receivers.Add((Receiver)eq);
                Receivers.Sort();
            }
            else if(eq is SDU)
            {
                Sdus.Add((SDU)eq);
                Sdus.Sort();
            }
            else if (eq is SedovServer)
            {
                SedovServers.Add((SedovServer)eq);
                SedovServers.Sort();
            }
        }

    }
}
